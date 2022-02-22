using System;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a hora inicial e a hora final do jogo");
            string[] valores = Console.ReadLine().Split(" ");
            int horaInicial = int.Parse(valores[0]);    
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal) 
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O Jogo durou {duracao} HORAS");
        }
    }
}
