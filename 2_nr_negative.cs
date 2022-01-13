using System;

namespace _2_nr_negativePozZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, negative, pozitive, zero;
            pozitive = 0;
            negative = 0;
            zero = 0;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numere.Length; i++)
            {
                if (numere[i] > 0)
                {
                    pozitive += 1;

                }else if (numere[i]<0)
                {
                    negative += 1;
                }else if(numere[i] == 0)
                {
                    zero += 1;
                }
            }
            Console.Write("Numere pozitive {0}, numere negative {1}, numere care sunt zero {2}", pozitive,negative,zero);
        }
    }
}
