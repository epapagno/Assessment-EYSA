using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Common.Infr.Support.Pagination
{
    public class PaginationParams<TEntity> : IPaginationParams<TEntity>
    {
        public PaginationParams(int page, int pageSize, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby)
        {
            if (page <= 0)
                throw new ArgumentException(nameof(page));
            if (pageSize <= 0)
                throw new ArgumentNullException(nameof(pageSize));

            this.Page = page;
            this.PageSize = pageSize;
            this.OrderBy = orderby;
        }

        public Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> OrderBy { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
