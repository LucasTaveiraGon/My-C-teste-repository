using System;

namespace Prjct006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);

            Console.WriteLine("Digite nome, sexo, idade e altura: ");
          
            string[] vet = Console.ReadLine().Split(" ");
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]); 
            float altura = float.Parse(vet[3]);
            Console.WriteLine($"{nome} {sexo} {idade} {altura}");
            



        }
    }
}
