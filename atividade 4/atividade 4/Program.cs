using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, a, b, c;
            Console.WriteLine("ESCREVA O VALOR DA IMPORTANCIA EM DOLAR:");
           dolar = Convert.ToInt32(Console.ReadLine());

            a= dolar * 0.3 ;
            Console.WriteLine("O VALOR TOTAL DE 30% QUE VOCE IRA RECEBER EH: " + a);

            b = dolar * 0.38;
            Console.WriteLine("O VALOR TOTAL DE 38% QUE VOCE IRA RECEBER EH: " + b);

            c = dolar * 0.32;
            Console.WriteLine("O VALOR TOTAL DE 32% QUE VOCE IRA RECEBER EH: " + c);
            Console.ReadKey();


        }
    }
}
