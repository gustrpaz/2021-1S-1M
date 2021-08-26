using System;

namespace Exercicio_produto
{
    class Program
    {

        static int Qtde_Produto = 10;
        static string resposta = "s";
        static string[] nomeProduto = new string[Qtde_Produto];
        static float[] preco = new float[Qtde_Produto];
        static bool[] promocao = new bool[Qtde_Produto];
        static int c = 0;
        static string s;
        static void Main(string[] args)
        {



            do
            {
                MostrarMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        do
                        {
                            CadastrarProduto();
                        } while (resposta == "S");

                        break;

                    case "2":
                        ListarProdutos();
                        break;


                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n Programa finalizado, volte sempre \n");
                        resposta = "S";
                        break;

                    default:
                        Console.WriteLine("Esse valor não é válido");

                        break;
                }
            } while (resposta == "N");

        }

        // Tela de Cadastrar o Produto
        static void CadastrarProduto()
        {
            if (c < Qtde_Produto)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(@"
|================================================|
|   Digite o nome do produto: ");
                nomeProduto[c] = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(@"         
|   Digite o preço do produto: R$ ");
                preco[c] = float.Parse(Console.ReadLine());

                Console.WriteLine("\n O produto está em promoção? (S/N)");
                string estaPromocao = Console.ReadLine().ToUpper();
                if (estaPromocao == "S")
                {
                    promocao[c] = true;


                }
                else
                {
                    promocao[c] = false;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Você deseja cadastrar outro produto? (S/N): ");
                resposta = Console.ReadLine().ToUpper();

                c++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O limite de produtos foi atingido");
                resposta = "N";
            }
        }

        // Tela de mostrar o menu
        static void MostrarMenu()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
|==================================|
| Menu de Opções (digite a opção)  |
|                                  |
|  1- Cadastrar Produto            |
|  2- Listar Produtos cadastrados  |
|  0- Sair                         |
|==================================|

Não digite 2 se você não cadastrou nada bobinho(a)
");

        }



        // Tela Listar Produtos
        static void ListarProdutos()
        {

            for (var i = 0; i < c; i++)
            {
                if (promocao[i] == true)
                {
                    s = promocao.ToString();
                    s = "Sim";
                }
                else
                {
                    s = promocao.ToString();
                    s = "Não";
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($@"

|============================|
|     O produto {i + 1}            |
|============================|
                           
   Nome: {nomeProduto[i]}    
   Preço: R$ {preco[i]}         
   Está em promoção? {s}     
                           
|============================|
");


            }
        }
    }
}
