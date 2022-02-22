using System;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero pra A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero pra B: ");
            int b = int.Parse(Console.ReadLine());  

            Console.WriteLine("Digite um numero pra C: ");
            int c = int.Parse(Console.ReadLine());  

            Console.WriteLine("Digite um numero pra D: ");
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);
            Console.WriteLine($"Diferença: {dif} " );

        }
    }
}
