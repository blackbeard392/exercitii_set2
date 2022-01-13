using System;

namespace _6_ordine_crescatoare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool crescator = true;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length-1; i++)
            {
                if (numere[i] > numere[i + 1])
                {
                    crescator = false;
                    
                }
               
            }
            if (crescator == true)
            {
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            }
            else if (crescator == false)
            {
                Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            }
        }
    }
}
