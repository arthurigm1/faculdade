using System;

namespace PROVA_EXERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O VALOR TOTAL DA SUA COMPRA:");
            double valor = Convert.ToDouble(Console.ReadLine());
            chamarprograma(valor);

        }

        static void chamarprograma(double valor)
        {
            Console.WriteLine("Produtos até R$100,00, devem ser pagos à vista");
            Console.WriteLine("Produtos até R$ 200,00, podem ser pagos em 2x;");
            Console.WriteLine("Produtos até R$ 300,00, podem ser pagos em 3x;");
            Console.WriteLine("Produtos até R$ 400,00, podem ser pagos em 4x;");
            Console.WriteLine("Produtos até R$ 500,00, podem ser pagos em 5x;");
            Console.WriteLine("Produtos acima de R$ 500,00 podem ser pagos em 10x;");

            int Numparcelas = 1;


            if (valor <= 100)
            {

                Numparcelas = 1;

            }
            else if (valor <= 200)
            {
                Numparcelas = 2;

            }
            else if (valor <= 300)
            {

                Numparcelas = 3;
            }
            else if (valor <= 400)
            {
                Numparcelas = 4;
            }
            else if (valor <= 500)
            {
                Numparcelas = 5;
            }

            else if (valor > 500)
            {
                Numparcelas = 10;
            }

            Console.WriteLine("\n \n \t O valor total eh:" + valor);
            for (int i = 1; i <= Numparcelas; i++)
            {
              
               double parcelas = valor / Numparcelas;
                Console.WriteLine("Parcela:" + i + " = " + parcelas);
                
            }









        }




    }
}

