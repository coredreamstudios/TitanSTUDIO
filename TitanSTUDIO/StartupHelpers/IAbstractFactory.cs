namespace System
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}