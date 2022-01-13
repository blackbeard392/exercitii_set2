using System;

namespace _3_suma_produs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,suma,produs;
            suma = 0;
            produs = 1;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            for(int i = 1; i <=a; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine("Suma este {0} si produsul este {1}", suma, produs);
        }
    }
}
