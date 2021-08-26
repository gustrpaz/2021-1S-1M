using System;
using ExercicioPOO1.Classes;

namespace ExercicioPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool OpcaoValida = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
|===================================|
|  Escolha um método de pagamento:  |
|                                   |
|   B- Boleto                       |
|   C- Crédito                      |
|   D- Débito                       |
|   X- Cancelar pagamento           |
|                                   |
|===================================|
            ");

                Console.ResetColor();
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registrar();
                        OpcaoValida = true;
                        break;

                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        OpcaoValida = true;
                        break;

                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        OpcaoValida = true;
                        break;

                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        Console.ResetColor();
                        OpcaoValida = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEssa opção de pagamento é invalida.");
                        OpcaoValida = false;
                        break;
                }
            } while (!OpcaoValida);
            Console.ResetColor();
        }
    }
}
