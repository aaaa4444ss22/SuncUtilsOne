using Sunc.Utils.One.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Utils
{
    public class ResultUtil: AbaseBusiness
    {
        private static AbaseBusiness abaseBusiness;
        static ResultUtil()
        {
            abaseBusiness = new ResultUtil();
        }
        private ResultUtil() { }
        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="objectEntity"></param>
        /// <returns></returns>
        public static EntityResult CreateResult(int count, String message, Object objectEntity)
        {
            return abaseBusiness.GetResult(count, message, objectEntity);
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static EntityResult CreateResult(int count, String message)
        {
            return abaseBusiness.GetResult(count, message);
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static EntityResult CreateResult(int count)
        {
            return abaseBusiness.GetResult(count);
        }

        /// <summary>
        /// 返回并初始化
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static EntityResult CreateResult(EntityResult result)
        {
            return abaseBusiness.GetResult(result);
        }
        /// <summary>
        /// 返回并初始化
        /// </summary>
        /// <param name="resultStatus"></param>
        /// <param name="message"></param>
        /// <param name="objectEntity"></param>
        /// <returns></returns>
        public static EntityResult CreateResult(ResultStatus resultStatus, string message = null, object objectEntity = null)
        {
            return abaseBusiness.GetResult(resultStatus,message,objectEntity);
        }

    }
}
