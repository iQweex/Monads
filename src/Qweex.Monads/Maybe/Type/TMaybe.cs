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
        public abstract class TFunc<TInput, TResult>
        {
            public abstract class P<E> 
                : TEither<Nothing>.TFunc<TInput, TResult>.P<E>
                where E : TUnion<Nothing, IFunc<TInput, TResult>>
            {
                protected P(Func<E> factory) : base(factory)
                {
                }

                protected P(Nothing value) : base(value)
                {
                }

                protected P(IFunc<TInput, TResult> value) : base(value)
                {
                }
            }
        }
    }
}
