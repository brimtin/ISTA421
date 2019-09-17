namespace Generics
{
    interface IMonoid<T>
    {
        T Mempty { get; }
        T Mappend(T first, T second);
    }
}
