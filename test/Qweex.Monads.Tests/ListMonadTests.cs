using System;
using System.Text;
using Qweex.Monads.List;
using Qweex.Monads.List.Type;
using Qweex.Monads.Tests.Common;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests
{
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
