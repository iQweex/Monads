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


    public abstract class Maybe
    {
        public class Func<TInput, TResult> 
            : TMaybe.TFunc<TInput, TResult>.P<Func<TInput, TResult>>
        {
            public Func(System.Func<TInput, TResult> func)
                : this(new F<TInput, TResult>(func))
            {

            }
            public Func(Func<Func<TInput, TResult>> factory) : base(factory)
            {
            }

            public Func(Nothing value) : base(value)
            {
            }

            public Func(IFunc<TInput, TResult> value) : base(value)
            {
            }
        }
    }
     
}
