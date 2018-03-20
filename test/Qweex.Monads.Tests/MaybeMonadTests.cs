using Qweex.Monads.Maybe.Type;
using System;
using System.Collections.Generic;
using System.Text;
using Qweex.Monads.Either;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests
{
    public class MaybeMonadTests
    {
        [Fact]
        public static void Maybe_bind_case_1_2()
        {
            Assert
                .Equal(
                    "3",
                    new Maybe<int>(1)
                        .Bind(v => new Maybe<int>(v + 2))
                        .Match(
                            n => n.ToString(),
                            r => r.ToString()
                        )
                );

            Assert
                .Equal(
                    new Nothing().ToString(),
                    new Maybe<int>()
                        .Bind(v => new Maybe<int>(v + 2))
                        .Match(
                            n => n.ToString(),
                            r => r.ToString()
                        )
                );
        }
    }
}
