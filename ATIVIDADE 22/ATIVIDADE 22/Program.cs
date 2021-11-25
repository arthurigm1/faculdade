using System;

namespace ATIVIDADE_22
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("DIGITE O MES");
           int mes = Convert.ToInt32(Console.ReadLine());
            chamarprograma(mes);

        }


             static void chamarprograma(int mes)
        {

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("janeiro");
                        break;
                    case 2:
                        Console.WriteLine("fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("marco");
                        break;
                    case 4:
                        Console.WriteLine("abril");
                        break;
                    case 5:
                        Console.WriteLine("maio");
                        break;
                    case 6:
                        Console.WriteLine("junho");
                        break;
                    case 7:
                        Console.WriteLine("julho");
                        break;
                    case 8:
                        Console.WriteLine("agosto");
                        break;
                    case 9:
                        Console.WriteLine("setembro");
                        break;
                    case 10:
                        Console.WriteLine("outubro");
                        break;
                    case 11:
                        Console.WriteLine("novembro");
                        break;
                    case 12:
                        Console.WriteLine("dezembro");
                        break;

                    default:
                        Console.WriteLine("opcao invalida");
                        break;
                }
                Console.ReadKey();
            }
        }
        }


   

