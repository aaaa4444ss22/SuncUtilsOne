using Sunc.Utils.One.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Extensions
{
    public static class QueryableExtensions
    {
        public static IPageList<T> ToPageLsit<T, Order>(this IQueryable<T> source
            , Expression<Func<T, bool>> whereFunc
            , Expression<Func<T, Order>> orderFunc
            , int pageIndex = 1
            , int pageSize = 10, bool isAsc = true)
        {
            var expression = source.Where(whereFunc.Compile());
            int count = expression.Count();
            var orderExpression = isAsc
                ? expression.OrderBy(orderFunc.Compile())
                : expression.OrderByDescending(orderFunc.Compile());
            var list = orderExpression.Skip((pageIndex-1) *pageSize)
               .Take(pageSize)
               .AsQueryable();
            return new PageList<T>(list, count, pageIndex, pageSize);
        }
    }
}
