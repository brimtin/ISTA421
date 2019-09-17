namespace Generics
{
    class IntegerMultiplication : IMonoid<int>
    {
        public int Mempty => 1;

        public int Mappend(int first, int second) => first * second;
    }
}
