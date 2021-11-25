using System;

namespace atividADE__6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("ESCREVA UM NUMERO QUALQUER DO SEU TECLADO");
            a = Convert.ToInt32(Console.ReadLine());
            {
                if (a > 20)
                {
                    Console.WriteLine("O numero A e maior que 20");

                }
                else
                {
                    Console.WriteLine("O numero A e menor que 20");
                }
                
            }
            Console.ReadKey();
        }
    }
}
