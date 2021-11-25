using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] exemplo = new int[10];
        
            for (int i= 0; i <= exemplo.Length; i++)
            {
                Console.WriteLine("Digite um numero");
                exemplo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(exemplo[i], 3));
            }


        }
    }
}
