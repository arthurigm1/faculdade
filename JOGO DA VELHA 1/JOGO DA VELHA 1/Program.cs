using System;

namespace JOGO_DA_VELHA_1

{
    class Program
    {
        public static string[,] tabuleiroExemplo = new string[3, 3];
        public static string[,] tabuleiro = new string[3, 3];
        public bool ConfereVitoria()
        {
            int contVitoriaX = 0, contVitoriaO = 0;
            bool ganhou = false;
            //POSSIBLIDADES DE GANHAR (JOGADOR1) - HORIZONTAL
            for (int indiceLinhas = 0; indiceLinhas < tabuleiro.GetLength(0); indiceLinhas++)
            {
                if (tabuleiro[indiceLinhas, 0] == "X" && tabuleiro[indiceLinhas, 1] == "X" && tabuleiro[indiceLinhas, 2] == "X")
                {
                    ganhou = true;
                    break;
                }
                else if (tabuleiro[indiceLinhas, 0] == "O" && tabuleiro[indiceLinhas, 1] == "O" && tabuleiro[indiceLinhas, 2] == "O")
                {
                    ganhou = true;
                    break;
                }
            }
            //POSSIBLIDADES DE GANHAR (JOGADOR1) - VERTICAL
            for (int indiceColunas = 0; indiceColunas < tabuleiro.GetLength(0); indiceColunas++)
            {
                if (tabuleiro[0, indiceColunas] == "X" && tabuleiro[1, indiceColunas] == "X" && tabuleiro[2, indiceColunas] == "X")
                {
                    ganhou = true;
                    break;
                }
                else if (tabuleiro[0, indiceColunas] == "O" && tabuleiro[1, indiceColunas] == "O" && tabuleiro[2, indiceColunas] == "O")
                {
                    ganhou = true;
                    break;
                }

            }
            //POSSIBLIDADES DE GANHAR (JOGADOR1) - DIAGONAL
            for (int indice = 0; indice < tabuleiro.GetLength(0); indice++)
            {
                if (tabuleiro[indice, indice] == "X")
                    contVitoriaX++;
                else if (tabuleiro[indice, indice] == "O")
                    contVitoriaO++;
            }
            if (contVitoriaX == 3)
                ganhou = true;
            else if (contVitoriaO == 3)
                ganhou = true;
            contVitoriaX = 0;
            contVitoriaO = 0;
            for (int indiceLinhas = 0; indiceLinhas < tabuleiro.GetLength(0); indiceLinhas++)
            {
                for (int indiceColunas = 0; indiceColunas < tabuleiro.GetLength(1); indiceColunas++)
                {
                    if (indiceColunas == (tabuleiro.GetLength(0) - 1 - indiceLinhas))
                    {
                        if (tabuleiro[indiceLinhas, indiceColunas] == "X")
                        {
                            contVitoriaX++;
                        }
                        else if (tabuleiro[indiceLinhas, indiceColunas] == "X")
                        {
                            contVitoriaO++;
                        }
                    }
                }
            }
            if (contVitoriaX == 3)
                ganhou = true;
            else if (contVitoriaO == 3)
                ganhou = true;
            if (ganhou)
                return true;
            else
                return false;
        }
        public void ExibirTabuleiros()
        {
            Console.Clear();
            //PRIMEIRA PARTE DO TABULEIRO
            Console.WriteLine("BEM VINDO AO JOGO DA VELHA");
            Console.WriteLine(" -------------     -------------");
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiroExemplo[0, t]);
            }
            Console.Write(" |    ");
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiro[0, t]);
            }
            Console.Write(" | \n");
            Console.WriteLine(" -------------     -------------");

            //SEGUNDA PARTE DO TABULEIRO
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiroExemplo[1, t]);
            }
            Console.Write(" |    ");
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiro[1, t]);
            }
            Console.Write(" | \n");
            Console.WriteLine(" -------------     -------------");

            //TERCEIRA PARTE DO TABULEIRO
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiroExemplo[2, t]);
            }
            Console.Write(" |    ");
            for (int t = 0; t < 3; t++)
            {
                Console.Write(" | " + tabuleiro[2, t]);
            }
            Console.Write(" | \n");
            Console.WriteLine(" -------------     -------------");
        }
        static void Main(string[] args)
        {
            Console.Title = "JOGO DA VELHA ";
            int jogador1 = 0, jogador2 = 0;
            bool ganhou = true;

            tabuleiroExemplo[0, 0] = "7";
            tabuleiroExemplo[0, 1] = "8";
            tabuleiroExemplo[0, 2] = "9";

            tabuleiroExemplo[1, 0] = "4";
            tabuleiroExemplo[1, 1] = "5";
            tabuleiroExemplo[1, 2] = "6";

            tabuleiroExemplo[2, 0] = "1";
            tabuleiroExemplo[2, 1] = "2";
            tabuleiroExemplo[2, 2] = "3";

            tabuleiro[0, 0] = "-";
            tabuleiro[0, 1] = "-";
            tabuleiro[0, 2] = "-";

            tabuleiro[1, 0] = "-";
            tabuleiro[1, 1] = "-";
            tabuleiro[1, 2] = "-";

            tabuleiro[2, 0] = "-";
            tabuleiro[2, 1] = "-";
            tabuleiro[2, 2] = "-";

            int contaTracinho = 0;
            Program metodos = new Program();
            do
            {
                // JOGADAS DO JOGADOR 1
                while (jogador1 == 0)
                {
                    metodos.ExibirTabuleiros();
                    Console.Write("Vez do jogador 1: ");
                    jogador1 = Convert.ToInt32(Console.ReadLine());

                    switch (jogador1)
                    {
                        case 7:
                            if (tabuleiro[0, 0] == "-")
                            {
                                tabuleiro[0, 0] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 8:
                            if (tabuleiro[0, 1] == "-")
                            {
                                tabuleiro[0, 1] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 9:
                            if (tabuleiro[0, 2] == "-")
                            {
                                tabuleiro[0, 2] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            if (tabuleiro[1, 0] == "-")
                            {
                                tabuleiro[1, 0] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            if (tabuleiro[1, 1] == "-")
                            {
                                tabuleiro[1, 1] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            if (tabuleiro[1, 2] == "-")
                            {
                                tabuleiro[1, 2] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 1:
                            if (tabuleiro[2, 0] == "-")
                            {
                                tabuleiro[2, 0] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            if (tabuleiro[2, 1] == "-")
                            {
                                tabuleiro[2, 1] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            if (tabuleiro[2, 2] == "-")
                            {
                                tabuleiro[2, 2] = "X";
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("CASA JÁ OCUPADA!!");
                                jogador1 = 0;
                                Console.ReadKey();
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.Write("CASA INVÁLIDA!!!");
                            jogador1 = 0;
                            Console.ReadKey();
                            break;
                    }

                }
                jogador1 = 0;
                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                {
                    for (int k = 0; k < tabuleiro.GetLength(1); k++)
                    {
                        if (tabuleiro[i, k] == "-")
                        {
                            contaTracinho++;
                        }
                    }
                }
                if (metodos.ConfereVitoria())
                {
                    Console.Clear();
                    metodos.ExibirTabuleiros();
                    Console.WriteLine("Jogador 1 ganhou!");
                    ganhou = false;
                    Console.ReadKey();
                }
                else if (contaTracinho == 0)
                {
                    Console.Clear();
                    metodos.ExibirTabuleiros();
                    Console.WriteLine("VELHA!");
                    ganhou = false;
                    Console.ReadKey();
                }
                else
                {
                    // JOGADAS DO JOGADOR 2
                    contaTracinho = 0;
                    while (jogador2 == 0)
                    {
                        metodos.ExibirTabuleiros();
                        Console.Write("Vez do jogador 2: ");
                        jogador2 = Convert.ToInt32(Console.ReadLine());
                        switch (jogador2)
                        {
                            case 7:
                                if (tabuleiro[0, 0] == "-")
                                {
                                    tabuleiro[0, 0] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 8:
                                if (tabuleiro[0, 1] == "-")
                                {
                                    tabuleiro[0, 1] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 9:
                                if (tabuleiro[0, 2] == "-")
                                {
                                    tabuleiro[0, 2] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
                                if (tabuleiro[1, 0] == "-")
                                {
                                    tabuleiro[1, 0] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 5:
                                if (tabuleiro[1, 1] == "-")
                                {
                                    tabuleiro[1, 1] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 6:
                                if (tabuleiro[1, 2] == "-")
                                {
                                    tabuleiro[1, 2] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 1:
                                if (tabuleiro[2, 0] == "-")
                                {
                                    tabuleiro[2, 0] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                if (tabuleiro[2, 1] == "-")
                                {
                                    tabuleiro[2, 1] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                if (tabuleiro[2, 2] == "-")
                                {
                                    tabuleiro[2, 2] = "O";
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.Write("CASA JÁ OCUPADA!!");
                                    jogador2 = 0;
                                    Console.ReadKey();
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.Write("CASA INVÁLIDA!!!");
                                jogador2 = 0;
                                Console.ReadKey();
                                break;
                        }
                    }

                    jogador2 = 0;
                    if (metodos.ConfereVitoria())
                    {
                        Console.Clear();
                        metodos.ExibirTabuleiros();
                        Console.WriteLine("Jogador 2 ganhou!");
                        ganhou = false;
                        Console.ReadKey();
                    }
                }
            } while (ganhou);
            Console.Clear();
            Console.WriteLine("\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();
        }
    }
}

