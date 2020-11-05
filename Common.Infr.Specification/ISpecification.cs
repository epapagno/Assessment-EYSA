using System;
using System.Linq.Expressions;

namespace Common.Infr.Specification
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> SatisfiedBy();
        ISpecification<TEntity> And(ISpecification<TEntity> specification);
        ISpecification<TEntity> Or(ISpecification<TEntity> specification);
        ISpecification<TEntity> Not();
    }
}
