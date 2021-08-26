using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"             Bem vindo(a) ao posto Grpaz!
||        Escolha a forma de abastecimento:                 ||
||                                                          ||
||        Álcool:                                           ||
||      - até 20 litros, desconto de 3% por litro Álcool.   ||
||      - acima de 20 litros, desconto de 5% por litro.     ||
||                                                          ||
||        Gasolina:                                         ||
||      - até 20 litros, desconto de 4% por litro Gasolina. ||
||      - acima de 20 litros, desconto de 6% por litro.     ||
||                                                          ||
||            Para Álcool digite (A)                        ||
||            Para Gasolina digite (G)                      ||
||__________________________________________________________|| 
");
            string escolha;
            double preco;
            double litros;
            bool condicao = false;
            do
            {
                escolha = Console.ReadLine().ToLower();
                switch (escolha)
                {
                    case "a":
                        Console.Write("\n Agora insira a quantidade em litros que deseja abastecer: ");
                        litros = double.Parse(Console.ReadLine());

                        preco = litros * 4.90 * .97;
                        Console.WriteLine("\n O preço a ser pago por " + litros + " litros de Álcool é: R$" + preco);
                        condicao = true;
                        break;

                    case "g":
                        Console.Write("\n Agora insira a quantidade em litros que deseja abastecer: ");
                        litros = double.Parse(Console.ReadLine());

                        preco = litros * 5.30 * .96;
                        Console.WriteLine("\n O preço a ser pago por " + litros + " litros de Gasolina é: R$" + preco);
                        condicao = true;
                        break;

                    default:
                        Console.Write("Opção invalida, porfavor digite uma opção valida: \n");
                        condicao = false;
                        break;
                }
            } while (condicao == false);


        }
    }
}