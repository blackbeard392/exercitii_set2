using System;

namespace _1_numere_pare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,count;
            count = 0;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ",a);
            for (int i = 0; i < numere.Length-1; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i] % 2 == 0)
                {
                    count += 1;
                    
                } 
            }
            Console.Write("Numere pare {0}", count);
        }
    }
}
