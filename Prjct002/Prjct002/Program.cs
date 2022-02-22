using System;
using System.Globalization;

namespace Prjct002
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("Bom Dia!!!!");
            Console.WriteLine("Boa Tarde");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0} é do sexo {1} tem {2} anos e saldo igual à {3} ", nome, genero, idade, saldo);
            Console.WriteLine($"{nome} é do sexo {genero} tem {idade} anos e saldo igual à {saldo:F3} ");

        }
    }
}
