using System;
using System.Globalization;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            float a = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de B: ");
            float b = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de C: ");
            float c = float.Parse(Console.ReadLine());

            float triangulo = ((a * c) / 2);
            double circulo = 3.14159 * Math.Pow(c,2);
            double trape = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retan = a * b;
            Console.WriteLine("TRIANGULO: "+ triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: "+ trape.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ retan.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
