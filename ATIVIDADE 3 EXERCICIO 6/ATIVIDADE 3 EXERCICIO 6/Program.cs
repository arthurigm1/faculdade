using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_EXERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usuario = new List<string> {"Pedro", "Lucas" , "Matheus" ,"Luciano","Allan"};
           for (int i =0; i < usuario.Count; i++)
            {
                Console.Write(usuario[i] + " | ");
            }
            string remove;
            string sub;
            string nome;
            Console.WriteLine("\nEscolha uma funcao do menu:");
            Console.WriteLine("1 - Adicionar usuario");
            Console.WriteLine("2 - Remover usuário");
            Console.WriteLine("3 - Substituir usuário");
            Console.WriteLine("4 - Limpar a lista");
            int console = Convert.ToInt32(Console.ReadLine());
            if(console == 1)
            {
                Console.WriteLine("Digite um usuario");
                usuario.Add(Console.ReadLine());
                for (int i = 0; i < usuario.Count; i++)
                {
                    Console.Write(usuario[i] + " | " );
                    
                }
                
            }
            else if (console == 2)
            {
                Console.Write("Digite o usuario que deseja remover:  ");
                remove = Console.ReadLine();
                for (int i = 0; i < usuario.Count; i++)
                {
                    if(usuario[i] == remove)
                    {
                        usuario.RemoveAt(i);
                    }
                }
                for(int i = 0; i < usuario.Count; i++)
                {
                    Console.Write(usuario[i] + " | ");
                }
            }
            else if (console == 3)
            {
                Console.Write("Escolha qual usuario deseja substituir:");
                sub = Console.ReadLine();
                Console.Write("\nDigite o novo nome:");
                nome = Console.ReadLine();
                for(int i = 0; i < usuario.Count; i++)
                {
                    if(usuario[i] == sub)
                    {
                        usuario[i] = nome;

                    }
                    
                }
                for (int i = 0; i < usuario.Count; i++)
                {
                    Console.Write(usuario[i] + " | ");
                }

            }
            else if(console == 4)
            {
                for(int i=0;i< usuario.Count; i=0)
                {
                    usuario.RemoveAt(i);

                }
                for (int i = 0; i < usuario.Count; i++)
                {
                    Console.Write(usuario[i] + " | ");
                }
                Console.Write("Lista excluida");
            }
            Console.ReadKey();


        }
    }
}
