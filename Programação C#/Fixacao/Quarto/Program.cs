using System;

namespace Quarto
{
    class Program
    {
        static void Main(string[] args)
        {
           const int numeroQtd = 10;
            int[] numeros = new int[numeroQtd];
            int menor = 0, maior = 0;

            Console.WriteLine("Informe 10 números inteiros:");

            for (int i = 0; i < numeroQtd; i++)
            {

                Console.Write((i + 1) + "º número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[i] < menor)

                {
                    menor = numeros[i];
                }

                else if (numeros[i] > maior)
                {
                    maior = numeros[i]; 
                }

            }

            Console.WriteLine("\n O menor número é: " + menor);
            Console.WriteLine(" O maior número é: " + maior);
            Console.Read();
        }

    }

} 