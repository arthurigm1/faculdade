using System;

namespace ATIVIDADE_3_EXERCICO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];

            for (int i =0;i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite um valor para a matriz a: " );
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                  }

            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite um valor para a matriz b: ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }
            int[,] soma = new int[4, 4];
            for(int i=0;i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    soma[i, j] = a[i, j] + b[i, j];
                    Console.Write(soma[i, j] + " ");
                    if (j == 3)
                    {
                        Console.Write("\n");
                    }

                }
            }




        }
    }
}
