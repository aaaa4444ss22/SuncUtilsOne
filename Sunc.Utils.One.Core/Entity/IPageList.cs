using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public abstract class IPageList<T> : EntityBase
    {
        public IPageList(IEnumerable<T> source, int count, int pageIndex = 1, int pageSize = 10)
        {

            this.Count = count;
            this.PageSize = (pageSize == 0) ? 1 : pageSize;
            this.PageCount = (count / pageSize) + (count % pageSize == 0 ? 0 : 1);
            this.PageIndex = (pageIndex < 0 || pageIndex > PageCount) ? 1 : pageIndex;

            this.Previous = (PageIndex - 1) >= 1;
            this.Next = (PageIndex + 1) <= PageCount;

            if (source == null || source.Count() == 0)
            {
                this.Source = new List<T>();
                return;
            }
            this.Source = source;
        }

        public IEnumerable<T> Source { get; }

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; } = 1;


        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize { get; } = 10;

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; } = 0;

        /// <summary>
        /// 总数
        /// </summary>
        public int Count { get; } = 0;

        /// <summary>
        /// 上一页
        /// </summary>
        public bool Previous { get; } = false;

        /// <summary>
        /// 下一页
        /// </summary>
        public bool Next { get; } = false;


    }
}
