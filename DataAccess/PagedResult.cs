using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WH.Common.Domain.Entities;
using Support.Pagination;

namespace DataAccess
{
    public class PagedResult<TEntity> : IPagedResult<TEntity>
    {
        public PagedResult()
        {
            Page = 1;
            TotalItems = 0;
            PageSize = 1;
            Items = new List<TEntity>();
        }
        public PagedResult(int page, int pageSize, long totalItems, IEnumerable<TEntity> pagination)
        {
            Page = page;
            PageSize = pageSize;
            TotalItems = totalItems;
            Items = pagination;
        }

        public PagedResult(IEnumerable<TEntity> pagination)
        {
            this.Items = pagination.ToList();
            this.Page = 1;
            this.PageSize = this.Items.Count();
            this.TotalItems = this.Items.Count();
        }

        public static async Task<PagedResult<TEntity>> Create(IQueryable<TEntity> query, IPaginationParams<TEntity> paginationParams)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));
            if (paginationParams == null)
                throw new ArgumentNullException(nameof(paginationParams));

            var items = await paginationParams.OrderBy(query).Skip((paginationParams.Page - 1) * paginationParams.PageSize).Take(paginationParams.PageSize).ToListAsync();
            long count = items.Count;
            if (count == paginationParams.PageSize || paginationParams.Page > 1)
                count = await query.LongCountAsync();


            return new PagedResult<TEntity>(paginationParams.Page, paginationParams.PageSize, count, items);
        }

        public int Page { get; set; }
        public int PageSize { get; set; }
        public long TotalItems { get; set; }
        public int TotalPages { get => (int)Math.Ceiling((0D + TotalItems) / PageSize); }
        public int FirstItem { get => (Page - 1) * PageSize + 1; }
        public int LastItem { get => FirstItem + Items.Count() - 1; }
        public bool HasNextPage { get => Page < TotalPages; }
        public bool HasPreviousPage { get => Page > 1; }
        public IEnumerable<TEntity> Items { get; set; }

    }
}
