using System;

namespace Sétimo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpe o terminal
            Console.Clear();
            Console.WriteLine("|| Programação afim de inverter a posição dos números || \n");

            // Declarando a arrey (mais de uma variavel armazenada), no caso incluindo 15 posições.
            int[] valores = new int[15];

            // Para variaveis da arrey em posição 0º, ordem menor que 15 estabelecendo limite, inserindo uma ordem, e com "i++" para forma crescente
            for (var i = 0; i < 15; i++)
            {

                // Papel do "i+1" para o programa pedir o 1º 2º 3º...
                Console.Write($"Digite o {i + 1}" + "º valor: ");

                valores[i] = int.Parse(Console.ReadLine());
                // Ler todos os 15 números inseridos e salvar como "valores"

            }

            Console.WriteLine("\n A ordem invertida dos valores inseridos são: \n");

            // Para a variável "Números inseridos" = partir da 14º posição; Arrey para a posição 0º (Primeira); e "i--" afim de implementar a forma decrescente
            for (var i = 14; i >= 0; i--)
            {

                Console.WriteLine(valores[i]);
                // Retorne para o usuário a variável dos 15 valores obtidos em posição inversa

            }
            // Finalização
            Console.WriteLine("\n Programa finalizado, até a próxima!");
        }
    }
}