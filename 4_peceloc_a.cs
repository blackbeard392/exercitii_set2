using System;

namespace _4_peceloc_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr, count,a,index;
            count = 0;
            Console.WriteLine("Scrieti un nr: ");
            nr = int.Parse(Console.ReadLine());
            Console.Write("Cautam numarul: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti {0} nr: ", nr);
            int[] numere = new int[nr];
            
            
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
                for (int i = 0; i < numere.Length; i++)
                {
                    if (numere[i] == a)
                    {
                        index = i;
                        Console.WriteLine(index);
                    }
                    else if (numere[i] != a)
                    {
                        Console.WriteLine(-1);
                    
                }
            }
        }
    }
}
