using System;

namespace atividade9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ëscreva seu numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O numero e positivo ");
            }

            else if  (numero < 0)
            {
                Console.WriteLine("O numero e negativo");
            }
            else
            {
                Console.WriteLine("O numero e nulo");

            }
            Console.ReadKey();
        }
    }
}
