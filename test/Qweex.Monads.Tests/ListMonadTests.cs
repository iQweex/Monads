using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qweex.Monads.List;
using Qweex.Monads.List.Type;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests
{
    public class MyList1 : TList<int>.P<MyList1>
    {
        public MyList1(params int[] elems) : this(elems.AsEnumerable())
        {
            
        }
        public MyList1(Func<TUnion<EmptyList, IEnumerable<int>>> factory) : base(factory)
        {
        }

        public MyList1() : this(new EmptyList())
        {
            
        }
        public MyList1(EmptyList value) : base(value)
        {
        }

        public MyList1(IEnumerable<int> value) : base(value)
        {
        }
    }

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
    public class ListMonadTests
    {
        [Fact]
        public void List_bind_case_1_2()
        {
            Assert
                .Equal(
                    "101112",
                    new ListM<int>(10, 11, 12)
                    .Bind(
                        e => new ListM<string>(e.ToString())
                    )
                    .Match(
                       e => e.ToString(),
                       r => String.Concat(r)
                    )
                 );

            Assert
                .Equal(
                    new EmptyList().ToString(),
                    new ListM<int>()
                        .Bind(
                            e => new ListM<string>(e.ToString())
                        )
                        .Match(
                            e => e.ToString(),
                            r => String.Concat(r)
                        )
                );
        }

        [Fact]
        public void Custom_List_bind_case_1_2()
        {
            Assert
                .Equal(
                    "101112",
                    new MyList1(10, 11, 12)
                        .Bind(
                            e => new MyList2(new[] { e.ToString() })
                        )
                        .Match(
                            e => e.ToString(),
                            r => String.Concat(r)
                        )
                );

            Assert
                .Equal(
                    new EmptyList().ToString(),
                    new MyList1()
                        .Bind(
                            e => new MyList2(new [] { e.ToString() })
                        )
                        .Match(
                            e => e.ToString(),
                            r => String.Concat(r)
                        )
                );
        }
    }
}
