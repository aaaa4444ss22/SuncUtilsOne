using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entity
{
    /// <summary>
    /// 基础类
    /// </summary>
    public abstract class EntityBase:IEntity
    {
        /// <summary>
        /// 通用载体
        /// </summary>
        public object EntityObject { set; get; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string ToJson()
        {
            throw new NotImplementedException();
        }
    }
}
