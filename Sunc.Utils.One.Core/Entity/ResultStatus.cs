using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    /// <summary>
    /// 状态
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Successfully = 200,

        /// <summary>
        /// 服务器成功处理了请求，但没有返回任何内容，一般用户返回执行结果失败，如插入失败
        /// </summary>
        [Description("服务器成功处理了请求")]
        Success= 204,

        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        Error = 500
    }
}
