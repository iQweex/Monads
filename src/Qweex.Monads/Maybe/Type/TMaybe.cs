using System;
using System.Collections.Generic;
using System.Text;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.Maybe.Type
{
    public abstract class TMaybe<TLeft, TRight>
    {
        public abstract class P<E> :
            TUnion<TLeft, TRight>,
            TMonad<TRight>.T<TLeft>.P<E>,
            TFunctor<TRight>.T<TLeft>.P<E>
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
