using System;
using Qweex.Monads.Monads;
using Qweex.Unions;

namespace Qweex.Monads.Either.Type
{
    public abstract class TEither<TLeft>
    {
        public abstract class Func<TInput, TResult>
            : TEither<TLeft, IFunc<TInput, TResult>>.P<Func<TInput, TResult>>
        {
            public Func(Func<TUnion<TLeft, IFunc<TInput, TResult>>> factory) : base(factory)
            {
            }

            public Func(TLeft value) : base(value)
            {
            }

            public Func(IFunc<TInput, TResult> value) : base(value)
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
        {
            public P(Func<TUnion<TLeft, TRight>> factory) : base(factory)
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