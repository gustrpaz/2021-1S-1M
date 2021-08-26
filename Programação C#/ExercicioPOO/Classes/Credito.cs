using System;
namespace ExercicioPOO1.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;
            Console.ResetColor();

            if (Valor > Limite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não tem limite suficiente para fazer essa compra.");

            }
            else
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"\nEm quantas vezes deseja parcelar o valor {valor:c2}? (De 1 à 12): ");
                    Console.ResetColor();
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes > 0 && vezes <= 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% do valor total\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"O preço a ser pago será {valor * 1.05:c2} em {vezes} vezes de {(valor * 1.05) / vezes:c2}.\n");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 8% do valor total\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"O preço a ser pago será {valor * 1.08:c2} em {vezes} vezes de {(valor * 1.08) / vezes:c2}.\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Impossível parcelar nessa quantidade, escolha um número de vezes entre 1 e 12");
                        Console.ResetColor();
                    }
                } while (vezes > 12 || vezes < 1);

            }
        }
    }
}