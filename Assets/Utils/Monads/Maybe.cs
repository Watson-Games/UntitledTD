using System;
using System.Diagnostics.Contracts;
using Unity.Burst;

namespace UntitledTD.Utils.Monads
{
    [BurstCompile]
    public readonly struct Maybe<T> where T : struct
    {
        private readonly T? _value;
        private readonly bool _isSome;

        private Maybe(T value)
        {
            _value = value;
            _isSome = true;
        }

        [BurstCompile]
        [Pure]
        public static Maybe<T> Some(T value)
        {
            return new Maybe<T>(value);
        }

        [BurstCompile]
        [Pure]
        public static Maybe<T> None()
        {
            return new Maybe<T>();
        }

        [BurstCompile]
        [Pure]
        public bool IsSome()
        {
            return _isSome;
        }

        [BurstCompile]
        [Pure]
        public bool IsNone()
        {
            return !IsSome();
        }

        [BurstCompile]
        [Pure]
        public T Unwrap()
        {
            if (IsNone())
                throw new Exception("PANIC! Unwrap null value");

            return (T)_value!;
        }
    }
}