using System;
namespace Exercicio_elevador.Classes
{
    public abstract class Elevador
    {
        int andarAtual = 0;
        int totalAndar = 10;
        int Capacidade = 6;
        public int Passageiros = 0;
        //-----------------------------------------//
        int pessoasEntrar = 0;
        int pessoasSair = 0;

        public void Inicializar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"
_________________________           
|  Elevador inicializado |
|                        |
| Capacidade: {Capacidade}          | 
| Passageiros: {Passageiros}         |
| Total de andares: {totalAndar}   | 
| Andar atual: {andarAtual}         |
|________________________|
            ");
            Console.ResetColor();
        }
        public void Entrar()
        {
            if (Passageiros < Capacidade)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite '1' para entrar uma pessoa no elevador: ");
                Console.ResetColor();
                pessoasEntrar = int.Parse(Console.ReadLine());

                if (pessoasEntrar + Passageiros <= Capacidade)
                {
                    Passageiros = Passageiros + pessoasEntrar;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nEntrou uma pessoa, agora o elevador possui {Passageiros} passageiros.\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO elevador não suporta essa quantidade de passageiros\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão há capacidade para entrar mais pessoas agora, espere ele retornar ao seu andar");
                Console.ResetColor();
            }
        }
        public void Sair()
        {
            if (Passageiros > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Insira a quantidade de pessoas que vão sair do elevador no {andarAtual}º andar: ");
                Console.ResetColor();
                pessoasSair = int.Parse(Console.ReadLine());

                if (pessoasSair <= Passageiros)
                {
                    Passageiros = Passageiros - pessoasSair;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{pessoasSair} pessoas saíram do elevador no {andarAtual}º andar, restam {Passageiros} pessoas no elevador.\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO elevador não possui essa quantidade de passageiros no momento\n");
                    Console.ResetColor();
                }
            }

        }
        public void Subir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nVocê escolheu a opção subir\n");
            Console.ResetColor();

            if (andarAtual < totalAndar)
            {
                andarAtual = andarAtual + 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O elevador foi para o {andarAtual}º andar com {Passageiros} pessoas.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O elevador já está no ultimo andar");
                Console.ResetColor();
            }

        }
        public void Descer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Você escolheu a opção descer.");
            Console.ResetColor();

            if (andarAtual >= 1)
            {
                andarAtual = andarAtual - 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nO elevador foi para o {andarAtual}º andar com {Passageiros} pessoas.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO elevador não pode descer mais que isso.");
                Console.ResetColor();
            }
        }
    }
}