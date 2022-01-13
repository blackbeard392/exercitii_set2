using System;

namespace _5_numere_egale_cu_pozitia
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
            Console.WriteLine("Scrieti {0} numere: ",a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i]  == i)
                {
                    count += 1;

                }
            }
            Console.Write("Numere egale cu pozitia pe care apar {0}", count);
        
    }
    }
}
