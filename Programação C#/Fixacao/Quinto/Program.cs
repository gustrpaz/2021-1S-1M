using System;

namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool resposta = false;
            do
            {


                Console.WriteLine("Olá, digite um número de 1 ao 10 para ver a tabuada do mesmo: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 11)
                {
                    do
                    {
                        Console.Write("Esse número digitado não é válido, digite um número válido: ");
                        numero = int.Parse(Console.ReadLine());

                    } while (numero >= 11);
                }


                string resp = String.Empty;
                for (int x = 1; x <= 10; x++)
                {
                    resp = numero + " * " + x + " = " + numero * x;
                    Console.WriteLine ("A tabuada do " + numero + " é: " + resp);

                }
            } while (resposta == true);

        }
    }
}

