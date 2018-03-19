namespace Qweex.Monads
{
    public class Factory<TResult>
    {
        private readonly object _value;

        public Factory(object value)
        {
            _value = value;
        }
        public TResult Instance()
        {
            return (TResult)
                ((typeof(TResult))
                    .GetConstructor(new [] { _value.GetType() })
                    .Invoke(new object[] { _value }));
        }
    }
}