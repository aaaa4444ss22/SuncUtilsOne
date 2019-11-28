using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public interface IBasePageList<T>
    {
        IPageList<T> GetEntityPageList<Order>(Expression<Func<T, bool>> whereFunc
            , Expression<Func<T, Order>> orderFunc
            , int pageIndex = 1
            , int pageSize = 10, bool isAsc = true);
    }
}
