using System.Collections.Generic;

namespace Common.Infr.Support.Pagination
{
    public interface IPagedResult<TEntity>
    {
        /// <summary>
        /// El número de página actual
        /// </summary>
        int Page { get; }
        /// <summary>
        /// La cantidad de filas en cada página.
        /// </summary>
        int PageSize { get; }
        /// <summary>
        /// El total de las filas.
        /// </summary>
        long TotalItems { get; }
        /// <summary>
        /// El total de las páginas.
        /// </summary>
        int TotalPages { get; }
        /// <summary>
        /// El índice del primer elemento en la página.
        /// </summary>
        int FirstItem { get; }
        /// <summary>
        /// En índice del último elemento en la página.
        /// </summary>
        int LastItem { get; }
        /// <summary>
        /// Consulta si hay páginas antes de la página actual.
        /// </summary>
        bool HasPreviousPage { get; }
        /// <summary>
        /// Consulta si hay páginas después de la página actual.
        /// </summary>
        bool HasNextPage { get; }
        IEnumerable<TEntity> Items { get; }
    }
}
