using System;

namespace PROVA_EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumCopia, Codcliente;
            double Valor;

            Console.WriteLine("Digite o numero de copias do documento:");
            NumCopia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora escolha o codigo da sua categoria:");
            Console.WriteLine("ALUNO     -> 10 ");
            Console.WriteLine("PROFESSOR -> 12");
            Console.WriteLine("DIREÇÃO   -> 01");
            Console.WriteLine("NÃO ALUNO -> 15");
            Codcliente = Convert.ToInt32(Console.ReadLine());

            if (Codcliente == 10)
            {
                Valor = NumCopia * 0.15;
                Console.WriteLine("Ola aluno, o valor das suas copias eh: R$" + Valor);
            }
            if(Codcliente == 12)
            {
                Valor = NumCopia * 0.07 ;
                Console.WriteLine("Ola professor, o valor das suas copias eh: R$" + Valor);
            }
            if (Codcliente == 01)
            {
                Valor = NumCopia * 0.00;
                Console.WriteLine("Ola diretor, o valor das suas copias eh: R$" + Valor);
            }
            if (Codcliente == 15)
            {
                Valor = NumCopia * 0.20;
                Console.WriteLine("Ola visitante, o valor das suas copias eh: R$" + Valor);
            }
            Console.ReadKey();

        }
    }
}
