using System;

namespace PROVA_EXERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            while (nome != "0")
            {
                Console.WriteLine("Digite um nome, ou digite 0 para sair");
                nome = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}

