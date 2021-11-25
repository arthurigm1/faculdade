using System;

namespace atividade_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, valor = 1, posicao = 1, controle = 1;
            Console.WriteLine("digite qual posicao deseja gerar");
            n = Convert.ToInt32(Console.ReadLine());

            while (posicao <= n)
            {
                valor = controle;
                Console.WriteLine(valor);
                posicao += 1;
                valor += 3;
                for (int i =0; i <2; i++)
                {
                    Console.WriteLine(valor);
                    posicao += 1;
                }
                controle += 1;
            }
                
        }
    }
}
