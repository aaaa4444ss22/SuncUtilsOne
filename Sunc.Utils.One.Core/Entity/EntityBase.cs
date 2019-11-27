using Sunc.Utils.One.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunc.Utils.One.Core.Entity
{
    /// <summary>
    /// 基础类
    /// </summary>
    public abstract class EntityBase:IEntity
    {
        /// <summary>
        /// 通用载体
        /// </summary>
        public object ObjectEntity { set; get; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string ToJson()
        {
            return JsonUtil.ToJson(this);
        }
    }
}
