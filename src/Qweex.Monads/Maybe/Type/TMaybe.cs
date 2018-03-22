using System;
using System.Collections.Generic;
using System.Text;
using Qweex.Monads.Either.Type;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.Maybe.Type
{
    public abstract class TMaybe<TRight>
    {
        public abstract class P<E> :
            TEither<Nothing, TRight>.P<E>
            where E : TUnion<Nothing, TRight>
        {
            protected P(Func<E> factory) : base(factory)
            {
            }

            protected P(Nothing value) : base(value)
            {
            }

            protected P(TRight value) : base(value)
            {
            }
        }
    }

    public abstract class TMaybe
    {
        public abstract class Func<TInput, TResult>
            : TEither<Nothing, IFunc<TInput, TResult>>.P<Func<TInput, TResult>>
        {
            protected Func(Func<Func<TInput, TResult>> factory) : base(factory)
            {
            }

            protected Func(Nothing value) : base(value)
            {
            }

            protected Func(IFunc<TInput, TResult> value) : base(value)
            {
            }
        }
    }
}
