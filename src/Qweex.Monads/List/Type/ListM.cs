using System;
using System.Collections.Generic;
using System.Linq;
using Qweex.Unions;

namespace Qweex.Monads.List.Type
{
    public class ListM<T> : TList<T>.P<ListM<T>>
    {
        public ListM(params T[] elems)
            : this(new List<T>(elems))
        { }

        public ListM() : this(new EmptyList()) { }

        public ListM(Func<ListM<T>> factory) : base(factory)
        {
        }

        public ListM(EmptyList value) : base(value)
        {
        }

        public ListM(IEnumerable<T> value) : base(value)
        {
        }
    }

    public class ListM 
    {
        public class TFunc<TInput, TResult> : TList.Func<TInput, TResult>.P<ListM.TFunc<TInput, TResult>>
        {
            public TFunc(
                params Func<TInput, TResult>[] fs
            )
                : this(new List<IFunc<TInput, TResult>>(fs.Select(f => new F<TInput, TResult>(f))))
            {
            }
            public TFunc(Func<TFunc<TInput, TResult>> factory) : base(factory)
            {
            }

            public TFunc(EmptyList value) : base(value)
            {
            }

            public TFunc(IEnumerable<IFunc<TInput, TResult>> value) : base(value)
            {
            }
        }
    }
}