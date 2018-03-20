using System;
using System.Collections.Generic;
using System.Text;
using Qweex.Monads.Either.Type;
using Qweex.Unions;

namespace Qweex.Monads.Maybe.Type
{
    public class Maybe<TRight> : TMaybe<TRight>.P<Maybe<TRight>>
    {
        public Maybe() : this(new Nothing())
        {

        }
        public Maybe(Func<Maybe<TRight>> factory) : base(factory)
        {
        }

        public Maybe(Nothing value) : base(value)
        {
        }

        public Maybe(TRight value) : base(value)
        {
        }
    }
}
