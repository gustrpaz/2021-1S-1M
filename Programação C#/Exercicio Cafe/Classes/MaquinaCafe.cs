using System;
namespace Exercicio_Cafe.Classes
{
    public class MaquinaCafe
    {
        // 50 gramas de açucar disponível
        public int acucarDisponivel = 50;
        int quantidade;
        public string fazerCafe (int quantidade)

        {
            if (quantidade <= acucarDisponivel)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nVocê adicionou {quantidade} gramas de açucar no café.\n");
                acucarDisponivel = acucarDisponivel - quantidade;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine ($"A quantidade atual de açucar na cafeteira é de {acucarDisponivel} gramas.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA máquina não possui essa quantidade de açucar disponível\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fazendo café sem açucar...");
                Console.ResetColor();
            }
           
            return "Seu café está pronto, aproxime o recipiente para o consumo";

        }
        public void fazerCafe()
        {
            if (quantidade <= acucarDisponivel)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nA máquina adicionou 10 gramas de açucar por padrão.\n");
                acucarDisponivel = acucarDisponivel - 10;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine ($"A quantidade atual de açucar na cafeteira é de {acucarDisponivel} gramas.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA máquina não possui essa quantidade de açucar disponível");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nFazendo café sem açucar...");
                Console.ResetColor();
            }

        }






    }
}
