using Qweex.Monads.Either.Type;
using Qweex.Monads.Monads;
using Qweex.Unions;

namespace Qweex.Monads.Either
{
    public static class Applicative
    {
        public static Either<T0, TR> Apply<A0, A1, T0, TI, TR>(
            this TEither<T0, IFunc<TI, TR>>.P<A0> a,
            TEither<T0, TI>.P<A1> fm
        )
            where A0 : TApplicative<IFunc<TI, TR>>.T<T0>.P<A0>
            where A1 : TApplicative<TI>.T<T0>.P<A1>
        {
            return a.Match(
                (l) => new Factory<Either<T0, TR>>(l).Instance(),
                (r) => fm
                    .Match(
                        (ll) =>
                            new Factory<Either<T0, TR>>(ll).Instance(),
                        (rr) =>
                            new Factory<Either<T0, TR>>(r.Execute(rr)).Instance()
                    )
            );
        }
    }
}
