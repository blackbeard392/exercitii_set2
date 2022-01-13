using System;

namespace _7_mica_mare_valoare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, mica,mare;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numere);
            mica = numere[0];
            mare = numere[a-1];
            Console.Write("Cea mai mica valoare {0}, cea mai mare valoare {1}",mica,mare);
        
    }
    }
}
