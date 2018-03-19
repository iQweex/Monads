namespace Types.Tests.Common
{
    public class Number
    {
        public Number(int number)
        {
            Value = number;
        }
        public int Value { get; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
