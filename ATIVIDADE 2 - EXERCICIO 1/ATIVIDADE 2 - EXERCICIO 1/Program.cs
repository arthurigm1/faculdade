using System;

namespace ATIVIDADE_2___EXERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] vetor2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {

                    vetor2[i] = vetor[i] * vetor[i + 1];
                    
                }
                else
                {
                    vetor2[i] = vetor[i] * 1;
                    
                }
                Console.WriteLine(vetor2[i]);
            }






        }
    }

            
        }

