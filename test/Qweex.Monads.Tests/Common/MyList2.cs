using System;
using System.Collections.Generic;
using Qweex.Monads.List.Type;
using Qweex.Unions;

namespace Qweex.Monads.Tests.Common
{
    public class MyList2 : TList<string>.P<MyList2>
    {
        public MyList2(Func<TUnion<EmptyList, IEnumerable<string>>> factory) : base(factory)
        {
        }

        public MyList2(EmptyList value) : base(value)
        {
        }

        public MyList2(IEnumerable<string> value) : base(value)
        {
        }
    }
}