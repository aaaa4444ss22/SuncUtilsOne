using Sunc.Utils.One.Core.Entity;
using Sunc.Utils.One.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJs
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            IPageList<string> pageList = new List<string>() {"A","B","A", "B", "B", "B","B","D"}
            .AsQueryable().ToPageLsit<string, string>(c => c == "B"
            , c => c, i, 2, true);

            Console.WriteLine(pageList.ToJson());
            while (pageList.Next)
            {
                i++;
                pageList = new List<string>() { "A", "B", "A", "B", "B", "B", "B", "D" }
            .AsQueryable().ToPageLsit<string, string>(c => c == "B"
            , c => c, i, 2, true);
                Console.WriteLine(pageList.ToJson());
            }
            Console.ReadKey();
        }
    }
}
