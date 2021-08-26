using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a lojas Grpaz! Digite o produto que deseja: \n");
            string produto = Console.ReadLine();

            Console.Write("Insira a quantidade adquirida de " + produto + ": ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário de " + produto + ": ");
            double preco = double.Parse(Console.ReadLine());


            double totalPagar;
            totalPagar = preco * quantidade;

            if (quantidade <= 5)
            {
                totalPagar = quantidade * preco * .98;
                Console.WriteLine("O valor total a pagar de " + quantidade + " de " + produto + " é igual a: R$" + totalPagar);
            }

            if (quantidade > 5 && quantidade <= 10)
            {
                totalPagar = quantidade * preco * .97;
                Console.WriteLine("O valor total a pagar de " + quantidade + " de " + produto + " é igual a: R$" + totalPagar);
            }

            if (quantidade > 10)
            {
                totalPagar = quantidade * preco * .95;
                Console.WriteLine("O valor total a pagar por " + quantidade + " de " + produto + " é igual a: R$" + totalPagar);
            }
        }

    }
}
