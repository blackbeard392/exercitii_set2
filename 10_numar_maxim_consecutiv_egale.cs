using System;

namespace _10_numar_maxim_consecutiv_egale
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, count;
            count = 0;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i <= numere.Length-1; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length-1; i++)
            {
                if (numere[i] == numere[i+1])
                {
                    count += 1;

                }
            }
            Console.Write("Numere consecutiv egale {0}", count);
        
    }
    }
}
