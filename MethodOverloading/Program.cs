using System;

namespace MethodOverloading
{
    class Program
    {
       //int
        public static int Add(int a, int b)
        {
            return a + b;
        }

       //decimal
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

       //string
        public static string Add(int a, int b, bool includeText)
        {
            int sum = a + b;
            if (sum == 1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
        }
        static void Main()
        {
            Console.WriteLine(Add(2, 3));           // 5
            Console.WriteLine(Add(2.5m, 3.7m));     // 6.2
            Console.WriteLine(Add(1, 0, true));     // "1 dollar"
            Console.WriteLine(Add(2, 3, true));     // "5 dollars"
        }
    }
}