using System;

namespace atividade_24
{
    class Program
    {
        static void Main(string[] args)
    {

           
            Console.WriteLine("DIGITE O SEU CARACTER");
            char letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(chamarprograma(letra));
            Console.ReadKey();

        }


        static int chamarprograma(char letra) 
        
        { 
           int codigo = Convert.ToInt32(letra);
            if ((codigo >= 65 && codigo <= 90) || (codigo >= 97 && codigo <= 122))
            {
                return 1;
            }
            else
            {
                return 0;
            }

            

        }
}
}