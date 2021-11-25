using System;

namespace atividade_17
{
    class Program
    {
        static void Main(string[] args)
        {
            
             for (int i=1; i <= 10; i++)
            {
                int numero;
                int quadrado;

                Console.WriteLine("Digite o numero : " + i + " ");
                numero = Convert.ToInt32(Console.ReadLine());

                quadrado = numero * numero;

                Console.WriteLine("O QUADRADO DO NUMERO EH:" + quadrado);
            }
     
            
        }
    }
}
