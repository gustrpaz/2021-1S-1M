using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Digite aqui seu Primeiro nome e veremos se começa ou não com vogal!!");
            string nome = Console.ReadLine();

            string letra = nome.Substring(0, 1).ToLower();

            switch (letra)
            {
                case "a":
                    Console.WriteLine("A primera letra do seu nome é: " + letra + ", igual a abelha ");

                    break;

                case "o":
                    Console.WriteLine("A primeira letra do seu nome é: " + letra + ", igual a ovo ");

                    break;

                default:
                    Console.WriteLine("A primeira letra do seu nome não começa com vogal irmão ");

                    break;
            }


        }
    }
}
