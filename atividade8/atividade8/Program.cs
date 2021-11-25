using System;

namespace atividade8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite seu numero:");
           numero = Convert.ToInt32(Console.ReadLine());


            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero" + "  "+ numero + "  "  + " E par");
            }

            else
            {
                Console.WriteLine("O numero e impar.");
            }
            Console.ReadKey();
        }
    }
}
