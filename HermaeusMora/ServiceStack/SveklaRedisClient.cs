using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Redis;

namespace Svekla.ServiceStack
{
    public class SveklaRedisClient : RedisClient
    {
        public SveklaRedisClient(String host)
            : base(host) { }
        public SveklaRedisClient(String host, Int32 port)
            : base(host, port) { }
        public SveklaRedisClient(String host, Int32 port, String password)
            : base(host, port, password) { }
        public SveklaRedisClient(Uri uri)
            : base(uri) { }

        public void JMA()
        {
            
        }
    }
}
