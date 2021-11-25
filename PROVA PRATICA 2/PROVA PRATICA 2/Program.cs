using System;

namespace PROVA_PRATICA_2
{
    class Program
    {
        static int posicaoP = 0;
        static int posicaoV = 0;
        static string[,] produtos = new string[20, 4];
        static int[,] vendas = new int[20, 3];
        static double[,] rltVendas = new double[20, 3];
        static double[,] rltVendasFunc = new double[20, 3];
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            Console.Write("\n===========================================\nMenu:\n===========================================" +
               "\n1 - Cadastrar produtos" +
               "\n2 - Realizar uma venda" +
               "\n3 - Relatório de vendas" +
               "\n4 - Relatório de vendas por funcionários" +
               "\n0 - Sair" +
               "\n\tDIGITE UMA OPÇÃO: ");
            int Menu = int.Parse(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    cadastrarproduto();
                    break;
                case 2:
                    realizarvenda();
                    break;
                case 3:
                    relatoriodevenda();
                    break;
                case 4:
                    relatoriovendaFuc();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.Write("Digito inválido");
                    menu();
                    break;
            }
        }
        static void cadastrarproduto()
        {
            Console.Write("Para cadastrar um novo produto insira: \nCódigo do produto: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Valor do produto: R$ ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            for (int colunas = 0; colunas <= 4; colunas++)
            {
                if (posicaoP == 19)
                {
                    Console.Write("Não é possível cadastrar mais produtos!!!");
                    break;
                }

                if (colunas == 0)
                    produtos[posicaoP, colunas] = cod.ToString();

                else if (colunas == 1)
                    produtos[posicaoP, colunas] = descricao;

                else if (colunas == 2)
                    produtos[posicaoP, colunas] = valor.ToString();

                else if (colunas == 3)
                    produtos[posicaoP, colunas] = estoque.ToString();
            }
            posicaoP++;

            Console.Clear();
            Console.WriteLine("\n\t\tPRODUTO CADASTRADO COM SUCESSO!!!\n\n");
            menu();


        }
        static void realizarvenda()
        {
            Console.Write("Para cadastrar uma nova venda insira: \nCódigo do produto: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Código do funcionário: ");
            int codFunc = int.Parse(Console.ReadLine());

            Console.Write("Quantidade do produto vendido: ");
            int qtdVenda = int.Parse(Console.ReadLine());

            for (int colunas = 0; colunas < 3; colunas++)
            {
                if (posicaoV == 19)
                {
                    Console.Write("Não é possível cadastrar mais vendas!!!");
                    break;
                }

                if (colunas == 0)
                {
                    vendas[posicaoV, colunas] = cod;

                    if (produtos[posicaoV, colunas] == cod.ToString())
                    {
                        int valor = Int32.Parse(produtos[posicaoV, 3]) - qtdVenda;
                        produtos[posicaoV, 3] = valor.ToString();
                    }
                }

                else if (colunas == 1)
                    vendas[posicaoV, colunas] = codFunc;

                else if (colunas == 2)
                    vendas[posicaoV, colunas] = qtdVenda;
            }
            posicaoV++;
            Console.Clear();
            Console.WriteLine("\n\t\tVENDA REALIZADA COM SUCESSO!!!\n\n");
            menu();
        }

        static void relatoriodevenda()
        {
            double valorVenda = 0;
            double valorTotalVendas = 0;

            Console.Write("CodProd \tCodFunc \tValor\n");
            for (int linhas = 0; linhas < 20; linhas++)
            {
                double codProd = 0, codFunc = 0, codVal = 0;
                for (int colunas = 0; colunas < 3; colunas++)
                {
                    if (colunas == 0)
                    {
                        rltVendas[linhas, 0] = vendas[linhas, 0];
                        codProd = rltVendas[linhas, 0];
                    }

                    if (colunas == 1)
                    {
                        rltVendas[linhas, 1] = vendas[linhas, 1];
                        codFunc = rltVendas[linhas, 1];
                    }

                    if (colunas == 2)
                    {
                        if (produtos[linhas, 0] == vendas[linhas, 0].ToString())
                        {
                            valorVenda = Int32.Parse(produtos[linhas, 2]) * vendas[linhas, 2];
                            valorTotalVendas += valorVenda;
                        }

                        else
                        {
                            if (!string.IsNullOrEmpty(produtos[linhas, 2]))
                            {
                                valorVenda = Int32.Parse(produtos[linhas, 2]);
                                valorTotalVendas += valorVenda;
                            }
                        }

                        rltVendas[linhas, 2] = valorVenda;
                        codVal = rltVendas[linhas, 2];
                    }
                }
                Console.WriteLine(codProd + "\t\t" + codFunc + "\t\t" + codVal);
            }

            Console.WriteLine("\n\nValor total de vendas: " + valorTotalVendas);
            menu();
        }
        static void relatoriovendaFuc()
        {
                double valorVenda = 0;
                double valorTotalVendas = 0;

                Console.Write("Digite o código do funcionário: ");
                int codF = int.Parse(Console.ReadLine());

                Console.Write("CodProd \tCodFunc \tValor\n");
                for (int linhas = 0; linhas < 20; linhas++)
                {
                    double codProd = 0, codFunc = 0, codVal = 0;
                    for (int colunas = 0; colunas < 3; colunas++)
                    {
                        if (vendas[linhas, 1] == codF)
                        {
                            if (colunas == 0)
                            {
                                rltVendasFunc[linhas, 0] = vendas[linhas, 0];
                                codProd = rltVendasFunc[linhas, 0];
                            }

                            if (colunas == 1)
                            {
                                rltVendasFunc[linhas, 1] = vendas[linhas, 1];
                                codFunc = rltVendasFunc[linhas, 1];
                            }

                            if (colunas == 2)
                            {
                                if (produtos[linhas, 0] == vendas[linhas, 0].ToString())
                                {
                                    valorVenda = Int32.Parse(produtos[linhas, 2]) * vendas[linhas, 2];
                                    valorTotalVendas += valorVenda;
                                }

                                else
                                {
                                    if (!string.IsNullOrEmpty(produtos[linhas, 2]))
                                    {
                                        valorVenda = Int32.Parse(produtos[linhas, 2]);
                                        valorTotalVendas += valorVenda;
                                    }
                                }

                                rltVendasFunc[linhas, 2] = valorVenda;
                                codVal = rltVendasFunc[linhas, 2];
                            }
                        }
                    }
                    Console.WriteLine(codProd + "\t\t" + codFunc + "\t\t" + codVal);
                }

                double comissao = valorTotalVendas * 10 / 100;

                Console.WriteLine("\nValor total de vendas do funcionário " + codF + " é: " + valorTotalVendas);
                Console.WriteLine("O valor de 10% do total de vendas à comissão do funcionário " + codF + " é: " + comissao);
                menu();
            }
        }
    }

