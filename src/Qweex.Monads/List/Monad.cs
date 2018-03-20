using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qweex.Monads.List.Type;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.List
{
    public static class Monad
    {
        public static L1 Bind<L0, L1, T0, T1>(
            this TList<T0>.P<L0> list,
            Func<T0, TMonad<T1>.T<EmptyList>.P<L1>> k
        )
            where L0 : TList<T0>.P<L0>, TMonad<T0>.T<EmptyList>.P<L0>
            where L1 : TList<T1>.P<L1>
        {
            return list
                .Match(
                    e => new Factory<L1>(new EmptyList()).Instance(),
                    r => new Factory<L1>(
                        list
                            .SelectMany(
                                e => new Factory<L1>(k(e)).Instance()
                            )
                    ).Instance()
                );
        }
    }
}
