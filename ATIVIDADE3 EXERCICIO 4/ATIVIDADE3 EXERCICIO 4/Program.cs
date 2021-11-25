using System;

namespace ATIVIDADE3_EXERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valormes = 0;
            double valorsemana = 0;
            double valorano = 0;

            double[,] matriz = new double[12, 4];
            
            for (int i = 0; i<=11; i++)

            {
                for (int a = 0; a <= 3; a++)
                {
                    Console.Write("Digite o valor das vendas:  ");
                    matriz[i, a] = Convert.ToInt32(Console.ReadLine());

                }

            }
            int opcaomenu = menu();
            if(opcaomenu == 1)
            {
                for(int i = 0; i <= 11; i++)
                {
                    mes(i);
                    for(int a = 0; a <= 3; a++)
                    {
                        valormes = valormes + matriz[i, a];
                        
                        if (a == 3)
                        {
                            Console.WriteLine(": Total vendido no mes: R$" + valormes);
                            valormes = 0;
                        }
                    }
                }
            }
            else if (opcaomenu == 2)
            {
                
                for(int a = 0; a<= 3; a++)
                {
                    semana(a);
                    
                    for (int i = 0; i <= 11; i++)
                    {
                        valorsemana = valorsemana + matriz[i, a];
                        if(i == 11)
                        {
                            Console.WriteLine(" Valor total : R$ " + valorsemana);
                            valorsemana = 0;
                        }
                    }
                    
                }
            }
            else if (opcaomenu == 3)
            {
                for (int i = 0; i <= 11; i++)

                {
                    for (int a = 0; a <= 3; a++)
                    {

                        valorano = valorano + matriz[i, a];
                        if(i == 11 && a == 3)
                        {
                            Console.WriteLine("O valor total vendido no ano eh: R$ " + valorano);
                        }
                    }


                }
            }
            Console.ReadKey();
        }
        static void semana(int a)
        {
            if(a == 0)
            {
                Console.Write("SEMANA 1:");
            }
            if (a == 1)
            {
                Console.Write("SEMANA 2:");
            }
            if (a == 2)
            {
                Console.Write("SEMANA 3:");
            }
            if (a == 3)
            {
                Console.Write("SEMANA 4:");
            }

        }
        static void mes(int i)
        {
            if (i == 0)
            {
                Console.Write("Janeiro");
            }
            else if (i == 1)
            {
                Console.Write("Fevereiro");
            }
            else if (i == 2)
            {
                Console.Write("Marco");
            }
            else if (i == 3)
            {
                Console.Write("Abril");
            }
            else if (i == 4)
            {
                Console.Write("maio");
            }
            else if (i == 5)
            {
                Console.Write("junho");
            }
            else if (i == 6)
            {
                Console.Write("julho");
            }
            else if (i == 7)
            {
                Console.Write("agosto");
            }
            else if (i == 8)
            {
                Console.Write("setembro");
            }
            else if (i == 9)
            {
                Console.Write("outubro");
            }
            else if (i == 10)
            {
                Console.Write("novembro");
            }
            else if (i == 11)
            {
                Console.Write("dezembro");
            }

        }
        static int menu()
        {
            Console.WriteLine("Digite a opcao:");
            Console.WriteLine("1- Total vendido em cada mês do ano;");
            Console.WriteLine("2- Total vendido em cada semana durante todo o ano;");
            Console.WriteLine("3- Total vendido no ano.");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

    }
}
