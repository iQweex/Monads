using Qweex.Monads.Maybe.Type;
using System;
using System.Collections.Generic;
using System.Text;
using Qweex.Monads.Either;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests
{
    public class MaybeApplicativeTests
    {
        [Fact]
        public void Maybe_applicative_test()
        {
            Assert
                .Equal(
                    "3",
                    new Maybe<int, string>((i) => i.ToString())
                        .Apply(new Maybe<int>(3))
                        .Match(
                            e => e.ToString(),
                            r => r
                        )
                 );
        }
    }
}
