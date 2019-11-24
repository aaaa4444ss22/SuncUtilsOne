using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public interface IBaseOperation<T, K, R>
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns>成功数</returns>
        R Save(T t);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="t">实体</param>
        /// <returns>成功数</returns>
        R Update(T t);


        /// <summary>
        /// 删除数据 
        /// </summary>
        /// <param name="k">主键或关键字</param>
        /// <returns>成功数</returns>
        R Delete(K k);

    }
}
