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

    //public static class Applicative
    //{
    //    public static Either<T0, TR> Apply<A0, A1, T0, TI, TR>(
    //        this TList<IFunc<TI, TR>>.P<A0> a,
    //        TEither<T0, TI>.P<A1> fm
    //    )
    //        where A0 : TEither<T0, IFunc<TI, TR>>.P<A0>, TApplicative<IFunc<TI, TR>>.T<T0>.P<A0>
    //        where A1 : TEither<T0, TI>.P<A1>, TApplicative<TI>.T<T0>.P<A1>
    //    {
    //        return a.Match(
    //            (l) => new Factory<Either<T0, TR>>(l).Instance(),
    //            (r) => fm
    //                .Match(
    //                    (ll) =>
    //                        new Factory<Either<T0, TR>>(ll).Instance(),
    //                    (rr) =>
    //                        new Factory<Either<T0, TR>>(r.Execute(rr)).Instance()
    //                )
    //        );
    //    }
    //}
}
