using System;

namespace _7_monoton
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool crescator = true;
            bool descrescator = true;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length - 1; i++)
            {
                if (numere[i] > numere[i + 1])
                {
                    crescator = false;

                }
                else if (numere[i] < numere[i + 1])
                {
                    descrescator = false;
                }
            }
            if (crescator)
            {
                Console.WriteLine("Ordinea este crescatoare");
            }else if (descrescator)
            {
                Console.WriteLine("Ordinea este descrescatoare");
            }
            else
            {
                Console.WriteLine("Ordinea nu este descrescatoare si nici crescatoare");
            }
        }
    }
}
