using System;
using System.Collections.Generic;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.List.Type
{
    public abstract class TList<T>
    {
        public abstract class P<L> :
            TUnion<EmptyList, IEnumerable<T>>,
            TMonad<T>.T<EmptyList>.P<L>,
            TFunctor<T>.T<EmptyList>.P<L>,
            TApplicative<T>.T<EmptyList>.P<L>
        {
            protected P(Func<TUnion<EmptyList, IEnumerable<T>>> factory) : base(factory)
            {
            }

            protected P(EmptyList value) : base(value)
            {
            }

            protected P(IEnumerable<T> value) : base(value)
            {
            }
        }
    }
}