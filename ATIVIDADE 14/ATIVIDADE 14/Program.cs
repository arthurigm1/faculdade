using System;

namespace ATIVIDADE_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
       
            
            Console.WriteLine("DIGITE SEU NUMERO X:");
            x = Convert.ToDouble(Console.ReadLine());
           
                Console.WriteLine("DIGITE SEU NUMERO Y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x < y)
            {

                Console.WriteLine(Math.Pow(x, 2));
                Console.WriteLine(Math.Sqrt(y));
            }
               
            else if (y < x)
            {
                Console.WriteLine(Math.Pow(y, 2));
                Console.WriteLine(Math.Sqrt(x));
            }
            else
            {
                Console.WriteLine("NUMEROS IGUAIS");
            }

            Console.ReadKey();
        }
    }
    }

