using System;

namespace ATIVIDADE_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma = soma + (i * i);
                Console.WriteLine(i + " , " + soma);


            }
        }
    }
}
