using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a questao: ");
            int questao = Convert.ToInt32(Console.ReadLine());

            switch (questao)
            {
                case 1:
                    questao1();
                    break;
                case 2:
                    questao2();
                    break;
            }

            Console.ReadKey();
        }
        static void questao1()
        {
            List<int> listNumerosOrdenados = lerArquivo1();
            gravarArquivo1(listNumerosOrdenados);
        }

        static List<int> lerArquivo1()
        {
            String line;
            List<int> listaNumeros = new List<int>();
            try
            {
                StreamReader arquivo = new StreamReader("C:\\Nova pasta/exercicio.txt");
                line = arquivo.ReadLine();
                listaNumeros.Add(Convert.ToInt32(line));
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = arquivo.ReadLine();
                    listaNumeros.Add(Convert.ToInt32(line));
                }
                arquivo.Close();
                listaNumeros.Sort();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return listaNumeros;
        }

        static void gravarArquivo1(List<int> listNumeros)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("C:\\Nova pasta/exercicio.txt");
                foreach (int item in listNumeros)
                {
                    arquivo.WriteLine(item);
                }
                arquivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void questao2()
        {
            Console.WriteLine("1 - Gravar arquivo");
            Console.WriteLine("2 - Ler arquivo");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    gravarArquivo2();
                    break;
                case 2:
                    lerArquivo2();
                    break;
            }
        }

        static void gravarArquivo2()
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("C:\\Nova pasta/exercicio2.txt");
                Console.WriteLine("Informe um texto: ");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
                arquivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void lerArquivo2()
        {
            String line;
            try
            {
                StreamReader arquivo = new StreamReader("C:\\Nova pasta/exercicio2.txt");
                line = arquivo.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = arquivo.ReadLine();
                }
                arquivo.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}