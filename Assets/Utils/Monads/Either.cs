using System.Diagnostics.Contracts;
using Unity.Burst;

namespace UntitledTD.Utils.Monads
{
    [BurstCompile]
    public readonly struct Either<TL, TR>
        where TL : struct
        where TR : struct
    {
        private readonly Maybe<TL> _left;
        private readonly Maybe<TR> _right;

        private Either(TL left)
        {
            _left = Maybe<TL>.Some(left);
            _right = Maybe<TR>.None();
        }

        private Either(TR right)
        {
            _left = Maybe<TL>.None();
            _right = Maybe<TR>.Some(right);
        }

        [BurstCompile]
        [Pure]
        public static Either<TL, TR> Left(TL left)
        {
            return new Either<TL, TR>(left);
        }

        [BurstCompile]
        [Pure]
        public static Either<TL, TR> Right(TR right)
        {
            return new Either<TL, TR>(right);
        }

        [BurstCompile]
        [Pure]
        public bool IsLeft()
        {
            return _left.IsSome();
        }

        [BurstCompile]
        [Pure]
        public bool IsRight()
        {
            return _right.IsSome();
        }

        [BurstCompile]
        [Pure]
        public bool IsBottom()
        {
            return _left.IsNone() && _right.IsNone();
        }

        [BurstCompile]
        [Pure]
        public TL UnwrapLeft()
        {
            return _left.Unwrap();
        }

        [BurstCompile]
        [Pure]
        public TR UnwrapRight()
        {
            return _right.Unwrap();
        }

        [BurstCompile]
        [Pure]
        public void Deconstruct(out Maybe<TL> left, out Maybe<TR> right)
        {
            left = _left;
            right = _right;
        }
    }
}