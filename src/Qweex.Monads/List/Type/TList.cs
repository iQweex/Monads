using System;
using System.Collections;
using System.Collections.Generic;
using Qweex.Monads.Types;
using Qweex.Unions;
using Qweex.Unions.Kind2;

namespace Qweex.Monads.List.Type
{

    public abstract class TList
    {
        public abstract class Func<TInput, TResult>
        {
            public abstract class P<L> 
                : TList<IFunc<TInput, TResult>>.P<L>
                where L : TUnion<EmptyList, IEnumerable<IFunc<TInput, TResult>>>
            {
                protected P(Func<L> factory) : base(factory)
                {
                }

                protected P(EmptyList value) : base(value)
                {
                }

                protected P(IEnumerable<IFunc<TInput, TResult>> value) : base(value)
                {
                }
            }
        }
    }

    public abstract class TList<T>
    {
        public abstract class P<L> :
            TUnion<EmptyList, IEnumerable<T>>,
            IEnumerable<T>,
            TMonad<T>.T<EmptyList>.P<L>,
            TFunctor<T>.T<EmptyList>.P<L>,
            TApplicative<T>.T<EmptyList>.P<L>
            where L : TUnion<EmptyList, IEnumerable<T>>
        {
            protected P(Func<L> factory) : base(factory)
            {
            }

            protected P(EmptyList value) : base(value)
            {
            }

            protected P(IEnumerable<T> value) : base(value)
            {
            }

            public IEnumerator<T> GetEnumerator()
            {
                return this
                    .Match(
                        e => new List<T>().GetEnumerator(),
                        r => r.GetEnumerator()
                    );
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}