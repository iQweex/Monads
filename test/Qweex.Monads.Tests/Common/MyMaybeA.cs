using System;
using Qweex.Monads.Maybe.Type;
using Qweex.Unions;

namespace Qweex.Monads.Tests.Common
{
    public class MyMaybeA : TMaybe<int>.P<MyMaybeA>
    {
        public MyMaybeA() : this(new Nothing())
        {
        }
        public MyMaybeA(Func<MyMaybeA> factory) : base(factory)
        {
        }

        public MyMaybeA(Nothing value) : base(value)
        {
        }

        public MyMaybeA(int value) : base(value)
        {
        }
    }
}