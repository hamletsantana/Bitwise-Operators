using System;

namespace Numeric_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Es impar? ");
            Console.WriteLine(Impar(numero));
            Console.WriteLine("Es par? ");
            Console.WriteLine(Par(numero));
        }

        static bool Impar(int num)
        {
            int test = 1 & num;
            if (test == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }
        static bool Par(int num)
        {
            int test = 1 & num;
            if (test == 1)
            {
                return false;
            }
            else 
            {
                return true;
            }
            
        }
    }
}
