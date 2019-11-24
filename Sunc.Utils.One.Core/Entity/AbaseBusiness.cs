using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public abstract class AbaseBusiness
    {
        private static ILog logger = LogManager.GetLogger(typeof(AbaseBusiness));

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <param name="objectEntity"></param>
        /// <returns></returns>
        public EntityResult GetResult(int count, String message, Object objectEntity)
        {
            logger.Debug($"getResult(int,String);成功数：{count}，提示消息：{message}");
            return new ResultObject().CreateResult(count, message, objectEntity);
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public EntityResult GetResult(int count, String message)
        {
            logger.Debug($"getResult(int,String);成功数：{count}，提示消息：{message}");
            return new ResultObject().CreateResult(count, message);
        }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public EntityResult GetResult(int count)
        {
            logger.Debug($"getResult(int);成功数：{count}，提示消息：null");
            return GetResult(count, null);
        }

        /// <summary>
        /// 返回并初始化
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public EntityResult GetResult(EntityResult result)
        {
            logger.Debug($"getResult(EntityResult);EntityResult：{result.ToJson()}");
            if (result == null)
            {
                return GetResult(0);
            }
            return result;
        }


    }
}
