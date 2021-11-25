using System;

namespace atividade_23
{
    class Program
    {


       static void Main(string[] args)
        {


            Console.WriteLine("DIGITE O SEU NOME");
            string nome = Console.ReadLine();
            chamarprograma(nome);

        }


        static void chamarprograma(string nome)
        {

            Console.WriteLine("============================================");
            Console.WriteLine("UFMG – Universidade Federal de Minas Gerais");
            Console.WriteLine("ICEx – Instituto de Ciências Exatas");
            Console.WriteLine("Disciplina de Programação de Computadores");
            Console.WriteLine("NOME:" + nome);
            Console.WriteLine("============================================");
            Console.ReadKey();
        }
    }
}