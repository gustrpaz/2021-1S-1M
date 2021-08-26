using System;
using Exercicio_elevador.Classes;

namespace Exercicio_elevador
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {
            // Limpador de Tela
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                                    ============================
                                    ||  ELEVADOR DO REZENDÃO  ||
                                    ||========================||
      _______________________________________           _______________________________________  
      |               Social                |           |               Serviço               |
      |  ________________________________   |           |  ________________________________   |                              
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
_____ |  |               |               |  |     _____ |  |               |               |  |
|   | |  |               |               |  |     |   | |  |               |               |  |
| O | |  |               |               |  |     | O | |  |               |               |  |
| | | |  |               |               |  |     | | | |  |               |               |  |
| O | |  |               |               |  |     | O | |  |               |               |  |
|___| |  |               |               |  |     |___| |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |
      |  |               |               |  |           |  |               |               |  |  
      |  |               |               |  |           |  |               |               |  |
      |__|_______________|_______________|__|           |__|_______________|_______________|__|            

");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"
|=================================|         
|   Qual elevador deseja utilizar |
|                                 |
|   1- Elevador Social            |
|   2- Elevador de Serviço        |
|=================================|

Resposta: ");
            Console.ResetColor();
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                //--------------------------//
                // Elevador Social

                case "1":
                    ElevadorSocial social = new ElevadorSocial();
                    social.Inicializar();
                    bool decisaoEntrarSocial = false;

                    do
                    {
                        social.Entrar();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Deseja introduzir mais uma pessoa no elevador? s/n: ");
                        Console.ResetColor();
                        string IntroduzirMais = Console.ReadLine().ToLower();

                        switch (IntroduzirMais)
                        {
                            case "s":
                                decisaoEntrarSocial = false;
                                break;

                            case "n":
                                decisaoEntrarSocial = true;
                                break;

                            default:
                                Console.WriteLine("Opção invalida.");
                                decisaoEntrarSocial = false;
                                break;
                        }

                    } while (decisaoEntrarSocial == false);

                    // Depois de já terem entrado...

                    bool repetirSocial = false;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(@"
|======================|
|  O que deseja fazer  |
|                      | 
|  s- Subir            |
|  d- Descer           |
|  0- Sair pessoas     |
|  e- Entrar pessoas   |
|======================|

Resposta: ");
                        Console.ResetColor();
                        string escolhaSocial = Console.ReadLine();

                        switch (escolhaSocial)
                        {
                            case "s":
                                social.Subir();
                                repetirSocial = false;
                                break;

                            case "d":
                                social.Descer();
                                repetirSocial = false;
                                break;

                            case "e":
                                do
                                {
                                    social.Entrar();

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Deseja introduzir mais uma pessoa no elevador? s/n: ");
                                    Console.ResetColor();
                                    string IntroduzirMais = Console.ReadLine().ToLower();

                                    switch (IntroduzirMais)
                                    {
                                        case "s":
                                            decisaoEntrarSocial = false;
                                            break;

                                        case "n":
                                            decisaoEntrarSocial = true;
                                            break;

                                        default:
                                            Console.WriteLine("Opção invalida.");
                                            decisaoEntrarSocial = false;
                                            break;
                                    }

                                } while (decisaoEntrarSocial == false);
                                break;
                            case "0":

                                bool decisaoSairSocial = false;

                                do
                                {
                                    social.Sair();

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Há mais alguma pessoa para sair? s/n: ");
                                    Console.ResetColor();
                                    string SairMais = Console.ReadLine().ToLower();

                                    switch (SairMais)
                                    {
                                        case "s":
                                            decisaoSairSocial = false;
                                            break;

                                        case "n":
                                            decisaoSairSocial = true;
                                            break;

                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nEssa resposta é invalida.");
                                            Console.ResetColor();
                                            decisaoSairSocial = false;
                                            break;
                                    }

                                } while (decisaoSairSocial == false);


                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Não é possivel essa escolha dentro do Elevador");
                                Console.ResetColor();
                                break;


                        }

                    } while (repetirSocial == false);


                    // Parar com o Elevador Social
                    break;



                //--------------------------
                // Elevador de Serviço 

                case "2":
                    ElevadorServico servico = new ElevadorServico();
                    servico.Inicializar();
                    servico.Adicionar();
                    bool decisaoServico = false;

                    do
                    {
                        servico.Entrar();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Deseja introduzir mais uma pessoa no elevador? s/n: ");
                        Console.ResetColor();
                        string IntroduzirMais = Console.ReadLine().ToLower();

                        switch (IntroduzirMais)
                        {
                            case "s":
                                decisaoServico = false;
                                break;

                            case "n":
                                decisaoServico = true;
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Opção invalida.");
                                Console.ResetColor();
                                decisaoServico = false;
                                break;
                        }

                    } while (decisaoServico == false);

                    // Depois de já terem entrado...

                    bool repetirServico = false;

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(@"
|======================|
|  O que deseja fazer  |
|                      | 
|  s- Subir            |
|  d- Descer           |
|  r- retirar caixas   |
|  0- Sair pessoas     |
|  e- Entrar pessoas   |
|======================|

Resposta: ");
                        Console.ResetColor();
                        string escolhaServico = Console.ReadLine();

                        switch (escolhaServico)
                        {
                            case "s":
                                servico.Subir();
                                servico.SubirCaixa();
                                repetirServico = false;
                                break;

                            case "d":
                                servico.Descer();
                                servico.DescerCaixa();
                                repetirServico = false;
                                break;

                            case "e":
                                bool decisaoEntrarServico = false;
                                do
                                {
                                    servico.Entrar();

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Deseja introduzir mais uma pessoa no elevador? s/n: ");
                                    Console.ResetColor();
                                    string IntroduzirMais = Console.ReadLine().ToLower();

                                    switch (IntroduzirMais)
                                    {
                                        case "s":
                                            decisaoEntrarServico = false;
                                            break;

                                        case "n":
                                            decisaoEntrarServico = true;
                                            break;

                                        default:
                                            Console.WriteLine("\nOpção invalida.\n");
                                            decisaoEntrarServico = false;
                                            break;
                                    }

                                } while (decisaoEntrarServico == false);
                                break;

                            case "0":

                                bool decisaoSairServico = false;

                                do
                                {
                                    servico.Sair();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("A mais alguma pessoa para sair do elevador? s/n: ");
                                    Console.ResetColor();
                                    string SairMais = Console.ReadLine().ToLower();

                                    switch (SairMais)
                                    {
                                        case "s":
                                            decisaoSairServico = false;
                                            break;

                                        case "n":
                                            decisaoSairServico = true;
                                            break;

                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nEssa resposta é invalida.\n");
                                            Console.ResetColor();
                                            decisaoSairServico = false;
                                            break;
                                    }

                                } while (decisaoSairServico == false);

                                break;


                            case "r":

                                bool decisaoRetirarServico = false;

                                do
                                {
                                    servico.retirarCaixa();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("A mais caixas para sair do elevador? s/n: ");
                                    Console.ResetColor();
                                    string RetirarMais = Console.ReadLine().ToLower();

                                    switch (RetirarMais)
                                    {
                                        case "s":
                                            decisaoRetirarServico = false;
                                            break;

                                        case "n":
                                            decisaoRetirarServico = true;
                                            break;

                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nEssa resposta é invalida.");
                                            Console.ResetColor();
                                            decisaoRetirarServico = false;
                                            break;
                                    }

                                } while (decisaoRetirarServico == false);

                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNão é possivel essa escolha dentro do Elevador\n");
                                Console.ResetColor();
                                break;


                        }

                    } while (repetirServico == false);

                    // Parar com o  Elevador de serviço
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEssa opção é invalida\n");
                    Console.ResetColor();
                    break;
            }





        }
    }
}
