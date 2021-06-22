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
            Console.WriteLine("Es positivo?");
            Console.WriteLine(Positivo(numero));
            Console.WriteLine("Es negativo?");
            Console.WriteLine(Negativo(numero));
            Console.WriteLine("Valor Absoluto");
            Console.WriteLine(Absoluto(numero));
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

        static bool Positivo(int num)
        {
            if ((num & 0x80000000) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool Negativo(int num)
        {
            if ((num & 0x80000000) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Absoluto (int num)
        {
            int x = num >> 31;
            return (num^x) - x;
        }
    }
}
