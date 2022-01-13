using System;
using System.Text;

namespace _11_inverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            string[] numere = new string[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = Console.ReadLine();
            }
            for (int i = 0; i < numere.Length; i++)
            {
                string value = String.ValueOf(numere[i]);
                string valueReversed = new StringBuilder(value).reverse().toString();
                numere[i] = int.Parse(valueReversed);
            }
        }
    }
}
