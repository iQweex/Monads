using Qweex.Monads.Either;
using Qweex.Monads.Maybe.Type;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests.MaybeTests
{
    public class MaybeApplicativeTests
    {
        [Fact]
        public void Maybe_applicative_test()
        {
            Assert
                .Equal(
                    "3",
                    new Maybe.Type.Maybe.Func<int, string>((i) => i.ToString())
                        .Apply(new Maybe<int>(3))
                        .Match(
                            e => e.ToString(),
                            r => r
                        )
                 );
        }
    }
}
