using System;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.Either.Type
{
    public abstract class TEither<TLeft>
    {
        public abstract class TFunc<TInput, TResult>
        {
            public abstract class P<E>
                : TEither<TLeft, IFunc<TInput, TResult>>.P<E>
                where E : TUnion<TLeft, IFunc<TInput, TResult>>
            {
                protected P(Func<E> factory) : base(factory)
                {
                }

                protected P(TLeft value) : base(value)
                {
                }

                protected P(IFunc<TInput, TResult> value) : base(value)
                {
                }
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