using System;

namespace Programacao
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------------------------------------
            //
            // Variaveis de Trabalho
            //

            string Usuario = "";
            string Senha = "";

            int Qtde_Passagens_Cadastradas = 0;

            string[] NomePassageiro = new string[5];
            string[] Origem = new string[5];
            string[] Destino = new string[5];
            string[] Data = new string[5];

            //--------------------------------------------------
            //
            // Inicio
            //

            Console.WriteLine("||  Bem vindo a agência de turismos Grpaz  ||\n");

            do
            {
                Console.Write("Digite um nome de usuário: ");
                Usuario = Console.ReadLine();

            } while (string.IsNullOrEmpty(Usuario));

            //--------------------------------------------------
            //
            // Senha para ter acesso
            //

            bool SenhaCerta = false;

            do
            {

                Console.Write ("Digite uma senha válida: ");
                Senha = (Console.ReadLine());

                if (Senha.Equals ("123456"))
                {
                    SenhaCerta = true;
                }
                else
                {
                    Console.Write ("Senha invalida. \n");
                }

            } while (SenhaCerta == false);


            //--------------------------------------------------
            //
            // Menu
            //

            bool Decisao_Sair = false;

            do
            {
                Console.Clear();

                Console.WriteLine(@"
                                ___________________________________________
                                ||      Menu  (Digite a opção)           ||
                                ||                                       ||
                                ||     -Cadastrar passagem (1)           ||   
                                ||     -Listar Passagens   (2)           ||
                                ||     -Sair               (0)           ||
                                ||_______________________________________||
                                ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("Para realizar o cadastro de passagem insira as informações abaixo:");

                        Console.Write("\n");
                        Console.Write("Passageiro " + (Qtde_Passagens_Cadastradas + 1).ToString() + " de 5");
                        Console.Write("\n");
                        Console.Write("\n");

                        //-----------------------------------

                        Console.Write("Nome do passageiro: ");
                        NomePassageiro[Qtde_Passagens_Cadastradas] = Console.ReadLine();

                        Console.Write("Origem: ");
                        Origem[Qtde_Passagens_Cadastradas] = Console.ReadLine();

                        Console.Write("Destino: ");
                        Destino[Qtde_Passagens_Cadastradas] = Console.ReadLine();

                        Console.Write("Data (DD/MM/AAAA): ");
                        Data[Qtde_Passagens_Cadastradas] = Console.ReadLine();

                        // Somo o total de passageiros cadastrados
                        Qtde_Passagens_Cadastradas = Qtde_Passagens_Cadastradas + 1;

                        //-----------------------------------

                        Console.Write("\n");
                        Console.Write("\n");

                        Console.WriteLine("Passagem cadastrada com sucesso.");
                        Console.WriteLine("Pressione uma tecla para voltar ao menu...");
                        Console.ReadKey();

                        break;

                    case "2":

                        Console.WriteLine("As passagens cadastradas até o momento são:");

                        for (var i = 0; i < 5; i++)
                        {
                            if (string.IsNullOrEmpty(NomePassageiro[i]) == false)
                            {
                                Console.WriteLine(NomePassageiro[i] + " " + 
                                                  Origem[i] + " " + 
                                                  Destino[i] + " " + 
                                                  Data[i]);
                            }

                        }

                        Console.Write("\n");
                        Console.WriteLine("Pressione uma tecla para voltar ao menu...");
                        Console.ReadKey();

                        break;

                    default:

                        Console.WriteLine("A opção digitada é invalida.");
                        break;

                    case "0":

                        Decisao_Sair = true;
                        break;
                }

            } while (Decisao_Sair == false);

        }





    }
}
