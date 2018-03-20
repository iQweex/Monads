using System;
using Qweex.Monads.Either.Type;
using Qweex.Monads.Types;
using Qweex.Unions;

namespace Qweex.Monads.Either
{
    public static class Monad
    {
        public static M1 Bind<M0, M1, T0, T1, T2>(
            this TEither<T0, T1>.P<M0> e, Func<T1, 
            TMonad<T2>.T<T0>.P<M1>> fm
        )
            where M0 : TMonad<T1>.T<T0>.P<M0>
        {
            return e
                    .Match(
                        (l) =>
                            new Factory<M1>(l).Instance(),
                        (r) =>
                            (M1)fm(r)
                    );
        }
    }
}