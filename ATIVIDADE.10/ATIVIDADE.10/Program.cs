using System;

namespace ATIVIDADE._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("DIGITE SEU NUMERO:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine(Math.Sqrt(numero));
            }

            else 
                    {
                Console.WriteLine(numero * numero);
            }
            Console.ReadKey();
        }
    }
}
