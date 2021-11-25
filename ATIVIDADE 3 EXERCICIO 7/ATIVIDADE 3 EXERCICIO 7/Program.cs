using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_EXERCICIO_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> pratos = new Stack<string>();
            pratos.Push("Prato1");
            pratos.Push("Prato2");
            pratos.Push("Prato3");
            pratos.Push("Prato4");
            pratos.Push("Prato5");

            
            foreach (string prato in pratos)
            {
                Console.Write(prato+ "\n");
            }
            pratos.Pop();
            pratos.Pop();
            pratos.Push("Prato6");
            foreach (string prato in pratos)
            {
                Console.Write(prato + ",");
            }
            Console.ReadKey();
        }
    }
}
