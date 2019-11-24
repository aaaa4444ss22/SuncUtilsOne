using Sunc.Utils.One.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public class ResultObject : EntityResult
    {
        public ResultObject() { }

        /**
         * 构造状态
         * @param status
         */
        public ResultObject(ResultStatus status)
        {
            this.Assertion = DiscriminantState(status);
            this.Status = (int)status;
            this.Message = EnumUtil.GetDescription(status);
        }


        public ResultObject(ResultStatus status, String message) : this(status)
        {
            this.Message = message;
        }
        /// <summary>
        /// 构造状态及载体数据
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="objectEninty"></param>
        public ResultObject(ResultStatus status, string message, object objectEninty) : this(status, message)
        {
            this.ObjectEntity = objectEninty;
        }


        public override EntityResult CreateResult(int count, string message)
        {
            return CreateResult(count > 0, message);
        }

        public override EntityResult CreateResult(int count, string message, object objectEntity)
        {
            return CreateResult(count > 0, message, objectEntity);
        }


        public override EntityResult CreateResult(bool assertion, string message)
        {
            return CreateResult(assertion, message, null);
        }


        public override EntityResult CreateResult(bool assertion, string message, object objectEntity)
        {
            ResultStatus status = ResultStatus.Error;
            if (assertion)
            {
                status = ResultStatus.Successfully;
            }
            EntityResult result = new ResultObject(status);
            if (!string.IsNullOrEmpty(message))
            {
                result.Message = message;
            }
            if (objectEntity != null)
            {
                result.ObjectEntity = objectEntity;
            }
            return result;
        }

    }
}
