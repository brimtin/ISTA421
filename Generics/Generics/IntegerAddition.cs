namespace Generics
{
    class IntegerAddition : IMonoid<int>
    {
        public int Mempty => 0;

        public int Mappend(int first, int second) => first + second;
    }
}
