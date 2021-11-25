using System;

namespace ATIVIDADE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Celsius, Fahrenheit;
            Console.WriteLine("ESCREVA A TEMPERATURA EM GRAUS CELSIUS:");
            Celsius = Convert.ToInt32(Console.ReadLine());

            Fahrenheit = Celsius * (9 / 5) - 32;
            Console.WriteLine("VALOR EM FAHRENHEIT EH:" + Fahrenheit);
            Console.ReadKey();
        }
    }
}
