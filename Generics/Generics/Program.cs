using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{

    class Program
    {
        static T Id<T>(T t) => t;

        static T Mconcat<Monoid, T>(Monoid m, List<T> list) where Monoid : IMonoid<T>
        {
            T accum = m.Mempty;

            foreach (var v in list)
            {
                accum = m.Mappend(accum, v);
            }

            return accum;
        }

        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello World!".Select(Id));

            var ints = Enumerable.Range(1, 10).ToList();

            Console.WriteLine(Mconcat(new IntegerAddition(), ints));
            Console.WriteLine(Mconcat(new IntegerMultiplication(), ints));
            Console.WriteLine(Mconcat(new StringMonoid(),
                                          ints.Select(i => i.ToString()).ToList()));
        }
    }
}
