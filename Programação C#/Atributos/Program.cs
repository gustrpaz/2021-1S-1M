using System;

namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();
            Personagem personagem2 = new Personagem();

            // Personagem 1
            personagem1.nome = "Miranha";
            personagem1.idade = 25;
            personagem1.armadura = "Aranha de ferro";
            personagem1.pontoVida = 50;

            //  ------------------------------------

            // Personagem 2
            personagem2.nome = "Cap";
            personagem2.idade = 120;
            personagem2.armadura = "Escudo";
            personagem2.pontoVida = 80;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
||===========================================||
||           Personagens                     ||
||                                           ||
||       MIRANHA                             ||
||      - Idade = {personagem1.idade}                         ||
||      - Armadura = {personagem1.armadura}         ||
||      - Vida = {personagem1.pontoVida}                          ||
||                                           ||
||       CAP                                 ||
||      - Idade = {personagem2.idade}                        ||
||      - Armadura = {personagem2.armadura}                  ||
||      - Vida = {personagem2.pontoVida}                          ||
||                                           ||
||===========================================||
");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
 
 Selecione uma opção para o cap:
           1 - Atacar
           2 - Defender
           ");
            int opcaoMiranha = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"

 Selecione uma opção para o Miranha:
           1 - Atacar
           2 - Defender
           ");

            Console.ForegroundColor = ConsoleColor.Green;
            int opcaoCap = int.Parse(Console.ReadLine());

            if (opcaoCap == 1 && opcaoMiranha == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - personagem1.Atacar();
                personagem2.pontoVida = personagem2.pontoVida - personagem2.Atacar();
                Console.WriteLine($"Vida do Miranha {personagem1.pontoVida}");
                Console.WriteLine($"Vida do Cap {personagem2.pontoVida}");

            }
            else if (opcaoCap == 1 && opcaoMiranha == 2)
            {
                personagem1.pontoVida = personagem1.pontoVida - (personagem1.Atacar() - personagem2.Defender());
                Console.WriteLine($"Vida do Miranha {personagem1.pontoVida}");
                Console.WriteLine($"Vida do Cap {personagem2.pontoVida}");

            }
            else if (opcaoCap == 2 && opcaoMiranha == 1)
            {
                personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());
                Console.WriteLine($"Vida do Miranha {personagem1.pontoVida}");
                Console.WriteLine($"Vida do Cap {personagem2.pontoVida}");

            }

            // Console.WriteLine($"Vida do Miranha {personagem1.pontoVida}");
            // Console.WriteLine($"Vida do Cap {personagem2.pontoVida}");
            // Console.ResetColor();
        }
    }
}

