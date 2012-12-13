using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svekla.ServiceStack
{
    public class RedisClientInfo
    {
        private Dictionary<String, String> _store = new Dictionary<String, String>();

        public String Address
        {
            get
            {
                if (_store.ContainsKey("addr"))
                    return _store["addr"];
                else
                    return "UNKNOWN";
            }
            set
            {
                if (value != null)
                    _store["addr"] = value;
                else
                    _store.Remove("addr");
            }
        }

        public Int32 FileDescriptor
        {
            get
            {
                if (_store.ContainsKey("fd"))
                    return Int32.Parse(_store["fd"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["fd"] = value.ToString();
                else
                    _store.Remove("fd");
            }
        }

        public Int32 Age
        {
            get
            {
                if (_store.ContainsKey("age"))
                    return Int32.Parse(_store["age"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["age"] = value.ToString();
                else
                    _store.Remove("age");
            }
        }

        public Int32 IdleTime
        {
            get
            {
                if (_store.ContainsKey("idle"))
                    return Int32.Parse(_store["idle"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["idle"] = value.ToString();
                else
                    _store.Remove("idle");
            }
        }

        public String Flags
        {
            get
            {
                if (_store.ContainsKey("flags"))
                    return _store["flags"];
                else
                    return "N/A";
            }
            set
            {
                if (value != null)
                    _store["flags"] = value;
                else
                    _store.Remove("flags");
            }
        }

        public Int32 DB
        {
            get
            {
                if (_store.ContainsKey("db"))
                    return Int32.Parse(_store["db"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["db"] = value.ToString();
                else
                    _store.Remove("db");
            }
        }

        public Int32 Subscriptions
        {
            get
            {
                if (_store.ContainsKey("sub"))
                    return Int32.Parse(_store["sub"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["sub"] = value.ToString();
                else
                    _store.Remove("sub");
            }
        }

        public Int32 PatternSubscriptions
        {
            get
            {
                if (_store.ContainsKey("psub"))
                    return Int32.Parse(_store["psub"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["psub"] = value.ToString();
                else
                    _store.Remove("psub");
            }
        }

        public Int32 MultiCommandCount
        {
            get
            {
                if (_store.ContainsKey("multi"))
                    return Int32.Parse(_store["multi"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["multi"] = value.ToString();
                else
                    _store.Remove("multi");
            }
        }

        public Int32 QueryBufferLength
        {
            get
            {
                if (_store.ContainsKey("qbuf"))
                    return Int32.Parse(_store["qbuf"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["qbuf"] = value.ToString();
                else
                    _store.Remove("qbuf");
            }
        }

        public Int32 QueryBufferFree
        {
            get
            {
                if (_store.ContainsKey("qbuf-free"))
                    return Int32.Parse(_store["qbuf-free"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["qbuf-free"] = value.ToString();
                else
                    _store.Remove("qbuf-free");
            }
        }

        public Int32 OutputBufferLength
        {
            get
            {
                if (_store.ContainsKey("obl"))
                    return Int32.Parse(_store["obl"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["obl"] = value.ToString();
                else
                    _store.Remove("obl");
            }
        }

        public Int32 OutputListLength
        {
            get
            {
                if (_store.ContainsKey("oll"))
                    return Int32.Parse(_store["oll"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["oll"] = value.ToString();
                else
                    _store.Remove("oll");
            }
        }

        public Int32 OutputBufferMemory
        {
            get
            {
                if (_store.ContainsKey("omem"))
                    return Int32.Parse(_store["omem"]);
                else
                    return -1;
            }
            set
            {
                if (value >= 0)
                    _store["omem"] = value.ToString();
                else
                    _store.Remove("omem");
            }
        }

        public String Events
        {
            get
            {
                if (_store.ContainsKey("events"))
                    return _store["events"];
                else
                    return "N/A";
            }
            set
            {
                if (value != null)
                    _store["events"] = value;
                else
                    _store.Remove("events");
            }
        }

        public String LastCommand
        {
            get
            {
                if (_store.ContainsKey("cmd"))
                    return _store["cmd"];
                else
                    return "N/A";
            }
            set
            {
                if (value != null)
                    _store["cmd"] = value;
                else
                    _store.Remove("cmd");
            }
        }

        public void CopyTo(RedisClientInfo c)
        {
            c._store.Clear();
            foreach (KeyValuePair<String, String> kvp in _store)
                c._store.Add(kvp.Key, kvp.Value);
        }

        public static RedisClientInfo Parse(String data)
        {
            String[] sdata = data.Split(' ');
            RedisClientInfo rci = new RedisClientInfo();

            foreach (String p in sdata)
            {
                String[] pentry = p.Split(new char[] { '=' }, 2);
                rci._store.Add(pentry[0], pentry[1]);
            }

            return rci;
        }

    }
}
