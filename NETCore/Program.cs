using System;

namespace NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort();
            Console.ReadKey();
        }

        static void Sort()
        {
            int[] array = new int[] { 23, 45, 67, 20, 145, 342, 2, 8, 5, 2323, 445, 626 };

            Array.Sort(array);

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

    }
}
