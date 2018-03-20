using System;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.Either.Type
{
    public abstract class TEither<TLeft>
    {
        public abstract class Func<TInput, TResult>
            : TEither<TLeft, IFunc<TInput, TResult>>.P<Func<TInput, TResult>>
        {
            protected Func(Func<Func<TInput, TResult>> factory) : base(factory)
            {
            }

            protected Func(TLeft value) : base(value)
            {
            }

            protected Func(IFunc<TInput, TResult> value) : base(value)
            {
            }
        }
    }

    public abstract class TEither<TLeft, TRight>
    {
        public abstract class P<E> :
            TUnion<TLeft, TRight>,
            TMonad<TRight>.T<TLeft>.P<E>,
            TFunctor<TRight>.T<TLeft>.P<E>,
            TApplicative<TRight>.T<TLeft>.P<E>
            where E : TUnion<TLeft, TRight>
        {
            public P(Func<E> factory) : base(factory)
            {
            }

            public P(TLeft value) : base(value)
            {
            }

            public P(TRight value) : base(value)
            {
            }
        }
    }
}