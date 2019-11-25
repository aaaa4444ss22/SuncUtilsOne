using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public abstract class EntityResult : EntityBase
    {
        public int Status { set; get; }
        public bool Assertion { set; get; }

        public string Message { set; get; }


        /// <summary>
        /// 判断状态
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static bool DiscriminantState(ResultStatus status)
        {
            bool flag = false;
            switch (status)
            {
                case ResultStatus.OK:
                    flag = true;
                    break;
            }
            return flag;
        }


        /// <summary>
        /// count 小于等于 0 ：false，count 大于 0 ：true
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public abstract EntityResult CreateResult(int count, String message);

        /// <summary>
        /// 小于等于 0 ：false，count 大于 0 ：true
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="objectEntity"></param>
        /// <returns></returns>
        public abstract EntityResult CreateResult(int count, String message, Object objectEntity);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="assertion"></param>
       /// <param name="message"></param>
       /// <returns></returns>
        public abstract EntityResult CreateResult(bool assertion, String message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assertion"></param>
        /// <param name="message"></param>
        /// <param name="objectEntity"></param>
        /// <returns></returns>
        public abstract EntityResult CreateResult(bool assertion, String message, Object objectEntity);
    }
}
