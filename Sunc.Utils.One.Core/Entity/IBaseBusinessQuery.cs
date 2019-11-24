using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public interface IBaseBusinessQuery<T, K>
    {
        /// <summary>
        /// 根据条件字段查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T FindOne(K key);

        /// <summary>
        /// 获取全部数据信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> FindAll();
    }
}
