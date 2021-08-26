using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            static double Somar(double primeiroNumero, double segundoNumero)
            {
                return primeiroNumero + segundoNumero;
            }

            static double Subtrair(double primeiroNumero, double segundoNumero)
            {
                return primeiroNumero - segundoNumero;
            }

            static double Multiplicar(double primeiroNumero, double segundoNumero)
            {
                return primeiroNumero * segundoNumero;
            }

            static double Dividir(double primeiroNumero, double segundoNumero)
            {
                return primeiroNumero / segundoNumero;
            }


            Console.WriteLine($@"                     Calculadora
|| Escolha a operação que deseja realizar e digite: ||
||                                                  ||
||        - Adição                                  ||
||        - Subtração                               ||
||        - Multiplicação                           ||
||        - Divisão                                 ||
||__________________________________________________|| 
");
            string operacao = Console.ReadLine();


            Console.Write("\n Digite o primeiro número para realizar um cálculo: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write(" Digite o segundo número para realizar o cálculo: ");
            double n2 = double.Parse(Console.ReadLine());


            switch (operacao)
            {
                case "Adição":
                    Console.WriteLine($"\n || O resultado da soma é igual a: {Somar(n1, n2)} || \n");
                    break;

                case "Subtração":
                    Console.WriteLine($"\n || O resultado da subtração é igual a: {Subtrair(n1, n2)} || \n");
                    break;

                case "Multiplicação":
                    Console.WriteLine($"\n || O resultado da multiplicação é igual a: {Multiplicar(n1, n2)} || \n");
                    break;

                case "Divisão":
                    Console.WriteLine($"\n || O resultado da divisão é igual a: {Dividir(n1, n2)} || \n");
                    break;

            }
            
        }


    }
}

