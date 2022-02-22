using System;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());    
            
            if(num % 2 == 0)
            {
                Console.WriteLine("É par!! ");
            }
            else 
            {
                Console.WriteLine("É Impar");
            
            }
        }
    }
}
