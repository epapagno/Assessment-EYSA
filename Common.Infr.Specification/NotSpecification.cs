using System;
using System.Linq;
using System.Linq.Expressions;

namespace Common.Infr.Specification
{
    public sealed class NotSpecification<TEntity> : Specification<TEntity> where TEntity : class
    {
        Expression<Func<TEntity, bool>> _original;
        public NotSpecification(ISpecification<TEntity> original)
        {
            if (original == null)
                throw new ArgumentNullException(nameof(original));

            _original = original.SatisfiedBy();
        }
        public NotSpecification(Expression<Func<TEntity, bool>> original)
        {
            _original = original ?? throw new ArgumentNullException(nameof(original));
        }
        public override Expression<Func<TEntity, bool>> SatisfiedBy() => Expression.Lambda<Func<TEntity, bool>>(Expression.Not(_original.Body), _original.Parameters.Single());
    }
}
