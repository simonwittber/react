namespace DifferentMethods.React
{
    public interface IEncapsulatedFunction<T> : IEncapsulatedMethodCall
    {
        T Invoke();
    }
}