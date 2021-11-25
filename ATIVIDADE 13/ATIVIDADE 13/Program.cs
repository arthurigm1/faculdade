using System;

namespace ATIVIDADE_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("ESCREVA SEU NUMERO:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 5)
            {
                Console.WriteLine("Numero igual a 5");

            }

            else if (numero == 200)
            {
                Console.WriteLine("Numero igual a 200");
            }
            else if (numero == 400)
            {
                Console.WriteLine("Numero igual a 400");
            }
            else if ((numero > 500) && (numero < 1000))
            {
                Console.WriteLine("No intervalo aberto entre 500 e 1000");

            }
            else
            {
                Console.WriteLine("Numero diferente de  5,200,400 e entre  500 e 1000");
            }
            Console.ReadKey();
        }
    }
}
