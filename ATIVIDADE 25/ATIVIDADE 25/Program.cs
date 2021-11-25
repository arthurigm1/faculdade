using System;

namespace ATIVIDADE_25
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("DIGITE O SEU NUMERO 1");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIGITE O SEU NUMERO 2");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(chamarprograma(numero1,numero2));
            Console.ReadKey();

        }


        static int chamarprograma(int numero1,int numero2)

        {
            int menor = Math.Min(numero1, numero2);
            Console.Write("O menor numero eh:");
            return menor;



        }
    }
}