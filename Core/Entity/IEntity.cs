using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entity
{
    /// <summary>
    /// 基础类接口
    /// </summary>
    public interface IEntity : ICloneable
    {
        /// <summary>
        /// 序列化json
        /// </summary>
        /// <returns></returns>
        string ToJson();


    }
}
