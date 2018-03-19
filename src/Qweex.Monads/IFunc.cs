namespace Qweex.Monads
{
    public interface IFunc<in TInput, out TResult>
    {
        TResult Execute(TInput value);
    }
}