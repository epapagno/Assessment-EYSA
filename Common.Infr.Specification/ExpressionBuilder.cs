using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Common.Infr.Specification
{
    public static class ExpressionBuilder
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second) => LinqKit.PredicateBuilder.And(first, second);
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second) => LinqKit.PredicateBuilder.Or(first, second);
    }
}
