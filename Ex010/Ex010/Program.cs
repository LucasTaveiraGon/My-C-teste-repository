using System;

namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 0 e 100");
            double vlr = double.Parse(Console.ReadLine());

            if(vlr >= 0 && vlr <= 25.00) 
            {
                Console.WriteLine("Intervalo entre 0.0 e 25.00");
            }else if(vlr > 25.00 && vlr <= 50) 
            {
                Console.WriteLine("Intervalo [25,50]");
            }else if (vlr > 50 && vlr <= 75) 
            {
                Console.WriteLine("Intervalo [50,75]");
            }else if (vlr > 75 && vlr <= 100)
            {
                Console.WriteLine("Intervalo [75,100] ");
            }
            else Console.WriteLine("FORA D E INTERVALO");

        }
    }
}
