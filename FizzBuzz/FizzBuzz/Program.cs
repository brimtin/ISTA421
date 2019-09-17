using System;

namespace FizzBuzz
{
    class Program
    {

       
        static void Main(string[] args)
        {
            FizzBuzz(50);

        }

        static void FizzBuzz(int max)
        {

         
            for (int i = 1; i <= max; i++)
            {

                string word = "";

                word += i.IsDivisibleBy(3, "Fizz");
                word += i.IsDivisibleBy(5, "Buzz");
                word += i.IsDivisibleBy(7, "Wozz");

                if (String.IsNullOrEmpty(word))
                {
                    Console.WriteLine(i);
                }

                else
                {
                    Console.WriteLine(word);
                }
                //if (i % 3 == 0 && i % 5 != 0)
                //{
                //    word += "Fizz";
                //    Console.WriteLine(word);
                //}
                //else if (i % 5 == 0 && i % 3 != 0)
                //{
                //    word += "Buzz";
                //    Console.WriteLine(word);
                //}
                //else if (i % 3 == 0 && i % 5 == 0)
                //{
                //    word += "FizzBuzz";
                //    Console.WriteLine(word);
                //}
                //else
                //{
                //    Console.WriteLine(i);
                //}
                //word = "";
            }
        }
    }


    public static class Util
    {
        public static string IsDivisibleBy(this int i, int m, string s)
        {
            if (i % m == 0)
            {
                return s;
            }

            else
                return "";
        }
    }
}
