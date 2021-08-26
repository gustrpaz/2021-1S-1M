using System;

namespace Sexto
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 nomes para o programa realizar uma análise \n");

            string[] Pessoas = null;
            Pessoas = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o nome " + (i + 1));
                Pessoas[i] = Console.ReadLine();
            }

            string verificar;

            do
            {
                Console.WriteLine("Insira o nome no qual deseja buscar:");
                string nome = Console.ReadLine();


                foreach (var item in Pessoas)
                {
                    if (item == nome)
                    {
                    Console.WriteLine("ACHEI");
                    } else
                    {
                        Console.WriteLine("NÂO ACHEI");
                    }
                }
                
                Console.WriteLine("\n deseja verificar outro nome? sim/nao");
                verificar = Console.ReadLine().ToLower();

            } while (verificar == "sim");

            Console.WriteLine("Finalizado");
        }
    }
}
            
            