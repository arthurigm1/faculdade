using System;

namespace PROVA_EXERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O TEMPO DA VIAGEM EM HORAS:");
            double tempo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE A VELOCIDADE DA VIAGEM EM KM/H.");
            double velocidade = Convert.ToDouble(Console.ReadLine());
            double litros = chamarprograma(tempo, velocidade);
            Console.WriteLine("O numero total de litro eh:" + litros);
            Console.ReadKey();

        }

        static double chamarprograma(double tempo, double velocidade)
        {
            double distancia = velocidade * tempo;
            double litros = distancia / 12;
            return litros;
        }
    }
}
