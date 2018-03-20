using Qweex.Monads.Either.Type;

namespace Qweex.Monads.Tests.Common
{
    public class EitherX : TEither<ErrorA, Number>.P<EitherX>
    {
        public EitherX(ErrorA value) : base(value)
        {
        }

        public EitherX(Number value) : base(value)
        {
        }
    }
}
