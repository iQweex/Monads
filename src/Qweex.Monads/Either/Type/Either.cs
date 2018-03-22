using System;
using Qweex.Unions;

namespace Qweex.Monads.Either.Type
{
    public class Either<TLeft, TRight> : TEither<TLeft, TRight>.P<Either<TLeft, TRight>>
    {
        public Either(TLeft t0) : base(t0)
        {
        }

        public Either(TRight t1) : base(t1)
        {
        }
    }

    public class Either<TLeft>
    {
        public abstract class Func<TInput, TResult>
            : TEither<TLeft>.TFunc<TInput, TResult>.P<Func<TInput, TResult>>
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
}