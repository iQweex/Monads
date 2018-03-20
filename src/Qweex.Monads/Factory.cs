using System.Collections.Generic;
using System.Linq;

namespace Qweex.Monads
{
    public class Factory<TResult>
    {
        private readonly IEnumerable<object> _value;

        public Factory() : this(new List<object>())
        {

        }

        public Factory(object value)
            : this(new List<object>() { value })
        {

        }
        private Factory(IEnumerable<object> value)
        {
            _value = value;
        }
        public TResult Instance()
        {
            return (TResult)
                ((typeof(TResult))
                    .GetConstructor(_value.Select(v => v.GetType()).ToArray())
                    .Invoke(_value.ToArray()));
        }
    }
}