using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Common.Domain.Core
{
    public interface IOrderResolver<TEntity, TEnum> where TEnum : Enum
    {
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> Resolve(TEnum columns, bool sortAscending);
    }
}
