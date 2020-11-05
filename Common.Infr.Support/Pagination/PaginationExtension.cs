using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Infr.Support.Pagination
{
    public static class PaginationExtension
    {
        /// <summary>
        /// Convierte una lista paginada en una lista simple.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="paged"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this IPagedResult<T> paged) => paged.Items.ToList();
    }
}
