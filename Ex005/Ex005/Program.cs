using System;

namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            if(num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else Console.WriteLine("NÃO É NEGATIVO");
        }
    }
}
