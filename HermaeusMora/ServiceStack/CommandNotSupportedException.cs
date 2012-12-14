using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svekla.ServiceStack
{
    public class CommandNotSupportedException : Exception
    {

        public CommandNotSupportedException(String command, Version current, Version minimum)
        {
            Command = command;
            RedisVersion = current;
            RequiredVersion = minimum;
        }

        public String Command
        { get; set; }

        public Version RedisVersion
        { get; set; }

        public Version RequiredVersion
        { get; set; }
    }
}
