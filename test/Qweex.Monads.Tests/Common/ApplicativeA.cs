using System;
using Qweex.Monads.Either.Type;
using Qweex.Unions;

namespace Qweex.Monads.Tests.Common
{
    public class ApplicativeA : TEither<ErrorA>.Func<Number, Number>
    {
        public ApplicativeA(Func<Number, Number> func)
            : this(new F<Number, Number>(func))
        {

        }
        public ApplicativeA(Func<TUnion<ErrorA, IFunc<Number, Number>>> factory) : base(factory)
        {
        }

        public ApplicativeA(ErrorA value) : base(value)
        {
        }

        public ApplicativeA(IFunc<Number, Number> value) : base(value)
        {
        }
    }
}