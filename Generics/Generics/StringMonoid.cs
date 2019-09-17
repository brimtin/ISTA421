namespace Generics
{
    class StringMonoid : IMonoid<string>
    {
        public string Mempty => "";

        public string Mappend(string first, string second) => first + second;
    }
}
