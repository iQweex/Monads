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
        {
            public P(Func<TUnion<Nothing, TRight>> factory) : base(factory)
            {
            }

            public P(Nothing value) : base(value)
            {
            }

            public P(TRight value) : base(value)
            {
            }
        }
    }
}
