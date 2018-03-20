using System;
using System.Collections.Generic;
using System.Linq;
using Qweex.Monads.List.Type;
using Qweex.Unions;

namespace Qweex.Monads.Tests.Common
{
    public class MyList1 : TList<int>.P<MyList1>
    {
        public MyList1(params int[] elems) : this(elems.AsEnumerable()) { }
        public MyList1() : this(new EmptyList()) { }
        public MyList1(Func<MyList1> factory) : base(factory)
        {
        }

        public MyList1(EmptyList value) : base(value)
        {
        }

        public MyList1(IEnumerable<int> value) : base(value)
        {
        }
    }
}