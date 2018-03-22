using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Qweex.Monads.List;
using Qweex.Monads.List.Type;
using Xunit;

namespace Qweex.Monads.Tests.ListTests
{
    public class ListApplicativeTests
    {
        [Fact]
        public void List_applicative()
        {
            Assert
                .Equal(
                    "345369",
                    String
                        .Join(
                            String.Empty,
                            new ListM.TFunc<int, int>(
                                a => a + 2,
                                b => b * 3
                            )
                            .Apply(
                                new ListM<int>(1, 2, 3)
                            )
                            .Select(i => i.ToString())
                        )
                );
        }
    }
}
