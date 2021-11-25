using System;

namespace atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float latao;
            Console.WriteLine("QUANTOS KG DE LATAO VOCE QUER PRODUZIR:");
            latao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sera necessario" + "  " + latao * 0.70 + "kg de cobre" + "  " + "E" + "  "+ latao * 0.30 + "  "+"kg de zinco");

            Console.ReadKey();
        }
    }
}
