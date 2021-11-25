using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_EXERCICIO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> pessoas = new Queue<string>();
            pessoas.Enqueue("Pessoa1");
            pessoas.Enqueue("Pessoa2");
            pessoas.Enqueue("Pessoa3");
            pessoas.Enqueue("Pessoa4");
            pessoas.Enqueue("Pessoa5");
            foreach(string pessoa in pessoas)
            {
                Console.Write(pessoa + ",");
            }
            Console.Write("\n");
            pessoas.Dequeue();
            pessoas.Dequeue();
            pessoas.Enqueue("Pessoa6");
            foreach (string pessoa in pessoas)
            {
                Console.Write(pessoa + ",");
            }
            Console.ReadKey();
        }
    }
}
