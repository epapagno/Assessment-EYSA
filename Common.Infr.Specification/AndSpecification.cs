using System;
using System.Linq.Expressions;

namespace Common.Infr.Specification
{
    public sealed class AndSpecification<T> : CompositeSpecification<T> where T : class
    {
        private ISpecification<T> _RightSideSpecification = null;
        private ISpecification<T> _LeftSideSpecification = null;

        public AndSpecification(ISpecification<T> leftSide, ISpecification<T> rightSide)
        {
            this._LeftSideSpecification = leftSide ?? throw new ArgumentNullException(nameof(leftSide));
            this._RightSideSpecification = rightSide ?? throw new ArgumentNullException(nameof(rightSide));
        }

        public override ISpecification<T> LeftSideSpecification => LeftSideSpecification;
        public override ISpecification<T> RightSideSpecification => _RightSideSpecification;

        public override Expression<Func<T, bool>> SatisfiedBy()
        {
            Expression<Func<T, bool>> left = _LeftSideSpecification.SatisfiedBy();
            Expression<Func<T, bool>> right = _RightSideSpecification.SatisfiedBy();

            return left.And(right);
        }
    }
}
