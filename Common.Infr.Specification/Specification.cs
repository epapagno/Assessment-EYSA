using System;
using System.Linq.Expressions;

namespace Common.Infr.Specification
{
    public abstract class Specification<TEntity> : ISpecification<TEntity> where TEntity : class
    {
        public abstract Expression<Func<TEntity, bool>> SatisfiedBy();

        public ISpecification<TEntity> And(ISpecification<TEntity> specification) => new AndSpecification<TEntity>(this, specification);
        public ISpecification<TEntity> Or(ISpecification<TEntity> specification) => new OrSpecification<TEntity>(this, specification);
        public ISpecification<TEntity> Not() => new NotSpecification<TEntity>(this);
        public static Specification<TEntity> operator &(Specification<TEntity> leftSideSpecification, Specification<TEntity> rightSideSpecification) => new AndSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        public static Specification<TEntity> operator |(Specification<TEntity> leftSideSpecification, Specification<TEntity> rightSideSpecification) => new OrSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        public static Specification<TEntity> operator !(Specification<TEntity> specification) => new NotSpecification<TEntity>(specification);
        public static bool operator false(Specification<TEntity> specification) => false;
        public static bool operator true(Specification<TEntity> specification) => false;
    }
}
