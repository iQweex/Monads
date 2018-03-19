using Qweex.Monads.Either.Type;
using Qweex.Monads.Tests.Common;
using Types.Tests.Common;

namespace Types.Tests.Monads.Core
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
