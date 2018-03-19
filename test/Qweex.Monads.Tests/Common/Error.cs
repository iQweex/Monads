namespace Qweex.Monads.Tests.Common
{
    public class ErrorA
    {
        public ErrorA(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
