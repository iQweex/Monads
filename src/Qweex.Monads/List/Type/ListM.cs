using System;
using System.Collections.Generic;
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
}