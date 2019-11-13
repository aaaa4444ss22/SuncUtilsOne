using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNotNull(this object entity)
        {
            return entity != null;
        }
    }
}
