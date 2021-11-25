using System;

namespace ATIVIDADADE_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;
            Console.WriteLine("DIGITE O NUMERO 1:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE O NUMERO 2:");
            b = Convert.ToInt32(Console.ReadLine());

            resultado= a +b;

            if (resultado > 10)
            {
                Console.WriteLine("O RESULTADO DA SOMA É:" + "  " + resultado);

            }
            else
            {
                Console.WriteLine("AVISO! A SOMA E MENOR QUE 10!");
            }
            Console.ReadKey();
        }
    }
}
