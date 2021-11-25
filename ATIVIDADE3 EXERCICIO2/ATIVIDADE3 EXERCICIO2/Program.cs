using System;

namespace ATIVIDADE3_EXERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite 5 numeros:");
                array[i] = Convert.ToInt32(Console.ReadLine());


            }
            string strNormal = "", strInvertido = "";
            for (int i = 0; i < array.Length; i++)
            {
                strNormal += array[i];
            }
            int[] arrayInvertido = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
        
                arrayInvertido[i] = array[array.Length - 1 - i];
            }
            for (int i = 0; i < arrayInvertido.Length; i++)
            {
                strInvertido += arrayInvertido[i];

            }
            Console.WriteLine(strNormal);
            Console.WriteLine(strInvertido);
            Console.ReadKey();  
        }
    }
}
