using System;
using System.Globalization;

namespace Prjct007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu noem compleo: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite seu ultimo nome, idade e altura(na mesma linha): ");
            string[] vet = Console.ReadLine().Split(" ");
            
            string lastN = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2]);
            
            Console.WriteLine("\n \n \n");
            
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture)) ;
            Console.WriteLine("--------------------");
            Console.WriteLine(lastN);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
