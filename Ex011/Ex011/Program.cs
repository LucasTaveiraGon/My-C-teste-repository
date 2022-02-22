using System;

namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= x && x <=1000 ; i++)
            {
                if(i % 2 != 0 )
                {
                    Console.WriteLine(i);
                }
                else Console.WriteLine("");
            }

        }
    }
}
