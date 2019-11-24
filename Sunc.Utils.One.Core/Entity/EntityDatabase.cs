using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Sunc.Utils.One.Core.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class EntityDatabase : EntityBase
    {
        private readonly static string DATE_FORMATTER = "yyyyMMddHHmmssfff";
        private static long number = 0;
        private static Queue<long> queue = new Queue<long>();
        private static int baseSize = 50000;
        private static readonly object lockOjc = new object();
        private static Timer timer = new Timer();
        /// <summary>
        /// 自动缓存ID
        /// </summary>
        public static void Init(long time = 1000,int count = 50000)
        {
            timer.Interval = time;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            baseSize = count;
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(queue.Count < baseSize)
            {
                int count = baseSize - queue.Count;
                for (int i = 0; i < count; i++)
                {
                    queue.Enqueue(GenerateDateInt());
                }
            }
        }

        /// <summary>
        /// 生成ID
        /// </summary>
        /// <param name="String"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static String GenerateId(string head)
        {
            String id = "";
            if (queue.Count > 0)
            {
                long lg = queue.Dequeue();
                if (lg != 0)
                {
                    id += lg.ToString();
                }
            }
            if (string.IsNullOrEmpty(id))
            {
                id = GenerateDateInt().ToString();
            }
            return (string.IsNullOrEmpty(head) ? "" : head) + id;
        }

        /// <summary>
        /// 生成时间序列
        /// </summary>
        public static long GenerateDateInt()
        {
            lock (lockOjc)
            {
                if (number == 0)
                {
                    number = Convert.ToInt64(DateTime.Now.ToString(DATE_FORMATTER));
                }
                else
                {
                    number++;
                }
                return number;
            }

           
        }
    }
}
