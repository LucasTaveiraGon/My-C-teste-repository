using System;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B: ");
            int b = int.Parse(Console.ReadLine());

            if (a / b == 0 || b / a == 0) 
            {
                Console.WriteLine($"Os numeros {a} e {b} são multiplos");
            }
            else Console.WriteLine($"Os numeros {a} e {b} não são multiplos");
        }
    }
}
