using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3_exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros1 = new Queue<int>();
            Queue<int> numeros = new Queue<int>();
            numeros1.Enqueue(5);
            numeros1.Enqueue(8);
            numeros1.Enqueue(13);
            numeros1.Enqueue(2);

            numeros.Enqueue(9);
            numeros.Enqueue(3);
            numeros.Enqueue(11);
            numeros.Enqueue(7);

            numeros.Enqueue(numeros1.Dequeue());
            numeros.Enqueue(numeros1.Dequeue());
            numeros.Enqueue(numeros1.Dequeue());
            numeros.Enqueue(numeros1.Dequeue());

            numeros1.Enqueue(numeros.Dequeue());
            numeros1.Enqueue(numeros.Dequeue());
            numeros1.Enqueue(numeros.Dequeue());
            numeros1.Enqueue(numeros.Dequeue());
            foreach (int n in numeros1)
            {
                Console.WriteLine(n);
            }
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
