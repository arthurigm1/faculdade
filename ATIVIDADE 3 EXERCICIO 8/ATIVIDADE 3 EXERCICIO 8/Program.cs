using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_EXERCICIO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> PilhaA = new Stack<int>();
            Stack<int> PilhaB = new Stack<int>();
            Stack<int> PilhaC = new Stack<int>();
            PilhaA.Push(1);
            PilhaA.Push(2);
            PilhaA.Push(3);

            foreach (int pilhas in PilhaA)
            {
                Console.Write("  Pilha a:" + pilhas); 
            }
            PilhaC.Push(PilhaA.Pop());
            PilhaC.Push(PilhaA.Pop());
            PilhaC.Push(PilhaA.Pop());

            PilhaB.Push(PilhaC.Pop());
            PilhaB.Push(PilhaC.Pop());
            PilhaB.Push(PilhaC.Pop());

            foreach (int pilhas in PilhaB)
            {
                Console.Write("  Pilha b:" + pilhas);
            }
            Console.ReadKey();
        }
    }
}
