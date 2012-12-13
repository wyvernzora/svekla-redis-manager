using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Text;

namespace Svekla.ServiceStack
{
    class RedisCommandsEx
    {
        public static readonly Byte[] CLIENT = "CLIENT".ToUtf8Bytes();
    }
}
