using System;
using Exercicio_Jogador.Classes;

namespace Exercicio_Jogador
{
    class Program
    {
        static void Main(string[] args)
        {

            JogadorAtaque Ja = new JogadorAtaque();
            JogadorMeioCampo Jm = new JogadorMeioCampo();
            JogadorDefesa Jd = new JogadorDefesa();
            bool Validacao = false;

            do
            {

                Console.WriteLine($@"
|==============================|
|    Que tipo de jogador ?     |
|  1 - Jogador Ataque          |
|  2 - Jogador Defesa          |
|  3 - Jogador Meio-Campo      |
|                              |
|   Após escolher, no campo    |
|   a seguir digite as         |
|   informações do jogador     |
|==============================|
");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome do jogador: ");
                        Ja.Nome = Console.ReadLine();

                        Console.Write("Digite o ano de nascimento: ");
                        Ja.DataNasc = int.Parse(Console.ReadLine());

                        Console.Write("Digite a nacionalidade: ");
                        Ja.Nacionalidade = Console.ReadLine();

                        Console.Write("Degite a altura: ");
                        Ja.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o peso do jogador?");
                        Ja.Peso = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Ja.ImprimirDados()}");
                        Console.WriteLine($"A idade do jogador é {Ja.CalcularIdade()} anos");
                        Console.WriteLine(Ja.Aposentar());
                        break;

                    case "2":
                        Console.WriteLine("Digite o nome do jogador: ");
                        Jd.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o ano de nascimento: ");
                        Jd.DataNasc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a nacionalidade: ");
                        Jd.Nacionalidade = Console.ReadLine();

                        Console.WriteLine("Digite a altura: ");
                        Jd.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o peso: ");
                        Jd.Peso = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Jd.ImprimirDados()}");
                        Console.WriteLine($"A idade do jogador é {Jd.CalcularIdade()} anos");
                        Console.WriteLine(Jd.Aposentar());
                        break;

                    case "3":
                        Console.WriteLine("Digite o nome do jogador?");
                        Jm.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o ano de nascimento: ");
                        Jm.DataNasc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a nacionalidade: ");
                        Jm.Nacionalidade = Console.ReadLine();

                        Console.WriteLine("Digite a altura: ");
                        Jm.Altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o peso: ");
                        Jm.Peso = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Jm.ImprimirDados()}");
                        Console.WriteLine($"A idade do jogador é {Jm.CalcularIdade()} anos");
                        Console.WriteLine(Jm.Aposentar());
                        break;
                    default:
                        Console.WriteLine("A opção digitada é invalida.");
                        Validacao = true;
                        break;
                }
            } while (Validacao);
        }
    }
}
