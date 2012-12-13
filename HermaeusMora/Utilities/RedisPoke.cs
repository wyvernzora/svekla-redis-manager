using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using Svekla.Persistence;

namespace Svekla.Utilities
{
    /// <summary>
    /// Very simple redis client for "poking" the server
    /// to see whether its active or whether password is accepted
    /// </summary>
    public class RedisPoke : IDisposable
    {
        public enum Result
        {
            Success,
            Failure,
            Timeout
        }

        TcpClient client;
        String host;
        Int32 port;

        public RedisPoke(String host, Int32 port)
        {
            this.host = host;
            this.port = port;
            this.client = new TcpClient();
        }

        /// <summary>
        /// Pings the target machine
        /// </summary>
        /// <returns>Ping delay</returns>
        public PingReply PingMachine()
        {
            try
            {
                Ping p = new Ping();
                return p.Send(host, GlobalSettings.Instance.PingTimeout);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Connects to the server
        /// </summary>
        /// <returns>True if success; false otherwise</returns>
        public Result Connect()
        {
            try
            {
                client.ReceiveTimeout = GlobalSettings.Instance.PingTimeout;
                client.SendTimeout = GlobalSettings.Instance.PingTimeout;

                IAsyncResult ar = client.BeginConnect(host, port, null, null);
                System.Threading.WaitHandle wh = ar.AsyncWaitHandle;
                try
                {
                    if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(GlobalSettings.Instance.PingTimeout), false))
                    {
                        client.Close();
                        return Result.Timeout;
                    }

                    client.EndConnect(ar);
                }
                finally
                {
                    wh.Close();
                }

                return sendRequest("PING");
            }
            catch
            {
                return Result.Timeout;
            }
        }

        /// <summary>
        /// Tries to authenticate to the redis server
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public Result Authenticate(String password)
        {
            try
            {
                return sendRequest("AUTH", password);
            }
            catch
            {
                return Result.Timeout;
            }
        }

        // utility method, creates and sends a redis request
        private Result sendRequest(params String[] args)
        {
            StringBuilder reqBuilder = new StringBuilder();
            reqBuilder.AppendFormat("*{0}\r\n", args.Length);
            foreach (String s in args)
            {
                reqBuilder.AppendFormat("${0}\r\n", Encoding.UTF8.GetByteCount(s));
                reqBuilder.AppendFormat("{0}\r\n", s);
            }

            Byte[] payload = Encoding.UTF8.GetBytes(reqBuilder.ToString());

            Stream ns = client.GetStream();
            ns.Write(payload, 0, payload.Length);

            try
            {
                Int32 result = ns.ReadByte();
                if (result == '+') return Result.Success;
                else return Result.Failure;
            }
            catch
            {
                return Result.Timeout;
            }
        }

        public void Dispose()
        {
            client.Close();
        }
    }
}
