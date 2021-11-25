using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TRABALHO_PRATICO_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] produto = new int[4,3];
            int[,] venda = new int[3, 3];
            Console.WriteLine("Menu:");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastrar produtos");
            Console.WriteLine("2 - Realizar uma venda");
            Console.WriteLine("3 - Relatório de vendas");
            Console.WriteLine("4 - Relatório de vendas por funcionários");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Selecione uma opção:_");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                    
            }

        }
    }
}
