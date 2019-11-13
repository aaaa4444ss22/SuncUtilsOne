using Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJt
{
    class Program
    {
        static void Main(string[] args)
        {
            var parms = new Dictionary<string, string>
            {
                { "q", "100" },
                { "auth","org_vip"}
            };
            string body = HttpUtil.Get("https://s.weibo.com/user", parms);

            Console.WriteLine(body);
            Console.ReadKey();
        }
    }
}
