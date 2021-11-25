using System;

namespace ATIVIDADE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int resultado;
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE O PRIMEIRO NUMERO B");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE O PRIMEIRO NUMERO C");
            c = Convert.ToInt32(Console.ReadLine());

            resultado = (a + b + c) / 3;
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
