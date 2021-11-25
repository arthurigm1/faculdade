using System;

namespace PROVA_JOGO_DA_VELHA
{
    class Program
    {
        private static string[,] Mostrartab2 = new string[3, 3];
        private static string[,] Mostrartab = new string[3,3];
        static void Main(string[] args)
        {
            mostrartabuleiro();
        }

        static void mostrartabuleiro()
        {

            Mostrartab[0, 0] = "7";
            Mostrartab[0, 1] = "8";
            Mostrartab[0, 2] = "9";

            Mostrartab[1, 0] = "4";
            Mostrartab[1, 1] = "5";
            Mostrartab[1, 2] = "6";

            Mostrartab[2, 0] = "1";
            Mostrartab[2, 1] = "2";
            Mostrartab[2, 2] = "3";

            Mostrartab[0, 0] = "-";
            Mostrartab[0, 1] = "-";
            Mostrartab[0, 2] = "-";

            Mostrartab[1, 0] = "-";
            Mostrartab[1, 1] = "-";
            Mostrartab[1, 2] = "-";

            Mostrartab[2, 0] = "-";
            Mostrartab[2, 1] = "-";
            Mostrartab[2, 2] = "-";

            Mostrartab2[0, 0] = "-";
            Mostrartab2[0, 1] = "-";
            Mostrartab2[0, 2] = "-";

            Mostrartab2[1, 0] = "-";
            Mostrartab2[1, 1] = "-";
            Mostrartab2[1, 2] = "-";

            Mostrartab2[2, 0] = "-";
            Mostrartab2[2, 1] = "-";
            Mostrartab2[2, 2] = "-";


         
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + Mostrartab[0, t]);
            }
           
            


            Console.ReadKey();
        }
    }
}
