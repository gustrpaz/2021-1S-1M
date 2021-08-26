using System;
using Exercicio_Cafe.Classes;

namespace Exercicio_Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            m.acucarDisponivel = 50;
            int quantidade;
            bool decisao = false;
            bool repeticao = false;
            Console.Clear();

            do
            {
Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
|==============================================|
|                                              |
|  Cafeteira Super CafeteiraTabajaras Plus++   |
|___                                        ___|
    |______________________________________|
    |  ________________________________    |                             
    |  | Café expresso                 |   |
    |  | Capuccino                     |   |
    |  | Café com leite                |   |
    |  | Status de Açucar: {m.acucarDisponivel} gramas   |   |
    |  |_______________________________|   |
    |     _____   _____   _____   _____    |
    | []  |___|   |___|   |___|   |___|    |
    |                                      |
    |              __________   _________  |                  
    |              |        |   |   |   |  |
    |               |      |    | L | D |  |
    |                |____|     |___|___|  |                
    |                 |__|                 |
    |                                      |
    |            ______________            |    
    |           |              |\\         |
    |           |              | \\        |
    |           |              | //        |
    |           |              |//         |
    |            |            |            |
    |             |__________|             |
    |______________|________|______________|
    |                                      |
 ___|______________________________________|___ 
|                                              |
|                 by: Rezende                  |
|==============================================|
");
Console.ResetColor();

                    bool repeticaoDesejo = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Você deseja informar a quantidade de açucar desejada no café? s/n: ");
                    Console.ResetColor();
                    string escolha = Console.ReadLine().ToLower();



                    switch (escolha)
                    {
                        case "s":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("Informe a quantidade de açucar desejada em gramas (EX: 1): ");
                            Console.ResetColor();
                            quantidade = int.Parse(Console.ReadLine());
                            m.fazerCafe(quantidade);
                            repeticaoDesejo = true;
                            break;

                        case "n":
                            m.fazerCafe();
                            repeticaoDesejo = true;
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nA escolha desejada é inválida.\n");
                            Console.ResetColor();
                            repeticaoDesejo = false;
                            break;
                    }

                } while (repeticaoDesejo == false);

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write ("\nDeseja pedir outro café? s/n: ");
                    Console.ResetColor();
                    string desejo = Console.ReadLine();

                    switch (desejo)
                    {
                        case "s":
                            decisao = false;
                            repeticao = true;
                            break;

                        case "n":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nObrigado por utilizar nossa máquina, até a próxima...");
                            Console.ResetColor();
                            decisao = true;
                            repeticao = true;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nEssa opção digitada é invalida, tente novamente\n");
                            Console.ResetColor();
                            decisao = true;
                            repeticao = true;
                            break;
                    }
                } while (repeticao == false);




            } while (decisao == false);

        }
    }
}
