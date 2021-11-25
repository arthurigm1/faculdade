using System;

namespace ATIVIDADE_12
{
    class Program
    {
        static void Main(string[] args)
        {
          
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int armazenar = 0;
                Console.WriteLine("ESCREVA O NUMERO A");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ESCREVA O NUMERO B");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ESCREVA O NUMERO C");
                c = Convert.ToInt32(Console.ReadLine());

                if (a < b)
                {
                    armazenar = a;
                    a = b;
                    b = armazenar;
                }
                if (a < c)
                {
                    armazenar = a;
                    a = c;
                    c = armazenar;
                }
                if (b < c)
                {
                    armazenar = b;
                    b = c;
                    c = armazenar;
                }
                Console.WriteLine("ORDEM DECRESCENTE :" + a + " " + b + " " + c);

                Console.ReadKey();
            }
        }
    }

}
