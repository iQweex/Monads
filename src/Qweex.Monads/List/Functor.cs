using System;
using System.Linq;
using Qweex.Monads.Either.Type;
using Qweex.Monads.List.Type;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.List
{
    public static class Functor
    {
        public static ListM<T1> Fmap<L0, T0, T1>(
            this TList<T0>.P<L0> list,
            Func<T0, T1> mapper
        )
            where L0 : TList<T0>.P<L0>, TFunctor<T0>.T<EmptyList>.P<L0>
        {
            return list
                .Match(
                    l => new ListM<T1>(new EmptyList()),
                    r => new ListM<T1>(r.Select(mapper))
                );
        }
    }
}
