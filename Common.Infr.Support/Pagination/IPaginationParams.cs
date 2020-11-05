using System;
using System.Linq;

namespace Common.Infr.Support.Pagination
{
    public interface IPaginationParams<TEntity>
    {        
        int Page { get; set; }
        int PageSize { get; set; }
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> OrderBy { get; set; }
    }
}
