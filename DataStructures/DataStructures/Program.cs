using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            LinkedList<int> linkedList = new LinkedList<int>();

            Queue<int> queue = new Queue<int>();

            Stack<int> stack = new Stack<int>();

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            SortedList<int, int> sortedList = new SortedList<int, int>();

            HashSet<int> hashSet = new HashSet<int>();


            for (int i = 0; i < 6; i++)
            {
                list.Add(i + 1);

                linkedList.AddLast(i + 1);

                queue.Enqueue(i + 1);

                stack.Push(i + 1);

                dictionary.Add(i, (i + 1));

                sortedList.Add(i, i + 1);

                hashSet.Add(i + 1);
            }

            Console.WriteLine("                             LIST");


            Console.Write("The collection contains: {");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.Write($"{list[list.Count - 1]}}}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             LINKED LIST");
            Console.Write("The collection contains: {");
            foreach (var item in linkedList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             QUEUE");
            Console.Write("The collection contains: {");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             STACK");
            Console.Write("The collection contains: {");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             DICTIONARY");
            Console.Write("The collection contains: {");
            foreach (var item in dictionary)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             SORTED LIST");
            Console.Write("The collection contains: {");
            foreach (var item in sortedList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


            Console.WriteLine("                             HASH SET");
            Console.Write("The collection contains: {");
            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}\n");
            Console.WriteLine("_____________________________________________________");


        }
    }

}
