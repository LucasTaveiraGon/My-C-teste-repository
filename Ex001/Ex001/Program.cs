using System;

namespace Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"A soma é: {soma}");

        }
    }
}
