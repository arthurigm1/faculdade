using System;

namespace atividade_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Escreva seu numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i<= numero; i++)
            {
                Console.WriteLine(i * i);
            }
        }
    }
}
