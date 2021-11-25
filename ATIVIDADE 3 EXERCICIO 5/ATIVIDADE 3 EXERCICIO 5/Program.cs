using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_3_EXERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cores = new List<string>();
            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Amarelo");
            cores.Add("Azul");
            cores.Add("Rosa");
            
            foreach(string cor in cores)
            {
                Console.Write(cor + " ");
            }

              for (int i=0; i < 3; i++)
            {
                cores.RemoveAt(0);
               

            }
            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Amarelo");
            foreach (string cor in cores)
            {
                Console.Write("\n" + "\t" + " " + cor);
            }

            Console.ReadKey();

        }
    }
}
