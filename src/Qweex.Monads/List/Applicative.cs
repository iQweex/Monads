using System.Linq;
using Qweex.Monads.List.Type;
using Qweex.Unions;

namespace Qweex.Monads.List
{
    public static class Applicative
    {
        public static ListM<TR> Apply<A0, A1, TI, TR>(
            this TList.TFunc<TI, TR>.P<A0> a,
            TList<TI>.P<A1> fm
        )
            where A0 : TList.TFunc<TI, TR>.P<A0>
            where A1 : TList<TI>.P<A1>
        {
            return a
                .Match(
                    e => new Factory<ListM<TR>>(new EmptyList()).Instance(),
                    l => new Factory<ListM<TR>>(
                            l.SelectMany(f => fm.Select(f.Execute)
                        )
                    ).Instance()
                );
        }
    }
}