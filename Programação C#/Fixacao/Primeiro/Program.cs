using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento para realizarmos uma pesquisa para votação desse ano: \n");
            int nascimento = int.Parse(Console.ReadLine());

            if (DateTime.Now.Year - nascimento >=16)
            {
                Console.WriteLine("\n Você poderá votar nas eleições de 2021.");
            }
            else
            {
                Console.WriteLine("\n Sinto muito você não atende os requisitos para votar esse ano.");
            }
        }
    }
}

