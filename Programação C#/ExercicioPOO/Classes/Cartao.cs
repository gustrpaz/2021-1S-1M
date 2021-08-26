using System;
namespace ExercicioPOO1.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string CVV;

        public string SalvarCartao()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nDigite a bandeira do seu cartão: ");
            Console.ResetColor();
            Bandeira = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Digite o numero do seu cartão: ");
            Console.ResetColor();
            Numero = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Digite o titular do seu cartão: ");
            Console.ResetColor();
            Titular = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Digite o CVV do seu cartão: ");
            Console.ResetColor();
            CVV = Console.ReadLine();

            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Green;

            return $"Cartão de número {Numero} salvo com sucesso."; 

        }

    }
}