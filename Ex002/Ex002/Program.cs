using System;
using System.Globalization;

namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Raio de um circulo: ");
            double raio = double.Parse(Console.ReadLine());
            
            double area = 3.14159 * Math.Pow(raio, 2);
            Console.Write("A area deste circulo é: ");
            Console.WriteLine( area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
