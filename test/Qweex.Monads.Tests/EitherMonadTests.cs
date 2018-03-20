using Qweex.Monads.Either;
using Qweex.Monads.List;
using Qweex.Monads.List.Type;
using Qweex.Monads.Tests.Common;
using Qweex.Unions;
using Xunit;

namespace Qweex.Monads.Tests
{

    public class EitherMonadTests
    {
        [Fact]
        public void Either_Monad()
        {
            Assert
                .Equal(
                    "30",
                    new EitherX(new Number(27))
                        .Bind(n => new EitherX(new Number(n.Value + 3)))
                        .Match(
                            l => l.Message,
                            r => r.Value.ToString()
                        )
                );

            Assert
                .Equal(
                    "30",
                    new EitherX(new Number(27))
                        .Fmap(a => new Number(a.Value + 3))
                        .Match(
                            l => l.Message,
                            r => r.Value.ToString()
                        )
                );

            Assert
                .Equal(
                    "30",
                    new ApplicativeA(
                            a => new Number(a.Value + 3)
                    )
                    .Apply(
                            new EitherX(
                                new Number(27)
                            )
                    )
                    .Match(
                        l => l.Message,
                        r => r.Value.ToString()
                    )
                );

            var g = new ListM<Number>(
                        new Number(27), 
                        new Number(3)
                    ).Fmap(n => n.Value.ToString());

        }
    }
}
