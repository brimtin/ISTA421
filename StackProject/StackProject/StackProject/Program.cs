using System;


namespace StackProject
{


    class Program
    {
        static void Main(string[] args)
        {
            UseStackWithInt();
            UseStackWithString();
        }

        private static void UseStackWithString()
        {
            var s = new Stack<string>();

            s.Push("Cats");
            s.Push("Dogs");

            while(s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine($"\n{s.Count}");


        }

        private static void UseStackWithInt()
        {
            var s = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                s.Push(i + 1);
            }

            foreach (var i in s.Data)
            {
                Console.WriteLine($"Enumerable: {i}");
            }

            var count = s.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine($"\n{s.Count}");
        }
    }
}
