using System;

namespace Par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {   

            string op = "s";
            while (op == "s")
    
        
            {int n = 0;
            int r = 0;
            Console.WriteLine("Determina se o número é par ou impar");
            Console.Write("Informe um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            r = n % 2;
            if (r == 1)
            {
                Console.WriteLine("O número informado é impar");
            }
            else
            {
                Console.WriteLine("O número informado é par");
            }
            Console.ReadKey();
            }
        }
    } 
}

