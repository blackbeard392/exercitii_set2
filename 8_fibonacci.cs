using System;

namespace _8_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Scrieti un nr:");
            n = int.Parse(Console.ReadLine());
            static int Fibonacci(int n)
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            Console.WriteLine("Rezultat " + Fibonacci(n));
        }
    }
}
