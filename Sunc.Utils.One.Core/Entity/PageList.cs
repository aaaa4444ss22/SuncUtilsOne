using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunc.Utils.One.Core.Entity
{
    public class PageList<T> : IPageList<T>
    {
        public PageList(IEnumerable<T> source, int count, int pageIndex = 1, int pageSize = 10) : base(source, count, pageIndex, pageSize)
        {
        }
    }
}
