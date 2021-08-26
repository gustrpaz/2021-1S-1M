using System;
using Interfaces.Classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
        
            Carrinho carrinho = new Carrinho();
            bool decisao = false;
            do
            {

                Console.WriteLine(@"
|=================================|       
|  Digite a opçaõ que você deseja |
|                                 |
|   1 - Cadastrar produto         |
|   2 - Deletar produto           |
|   3 - Listar produto            |
|   0 - Sair                      |
|=================================|

     ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        int id = 0;

                        Console.Write ("Digite o nome do produto");
                        produto.Nome = Console.ReadLine();

                        Console.Write ("Digite o preço do produto");
                        produto.Preco = float.Parse(Console.ReadLine());
                        produto.Codigo = id;



                        carrinho.Cadastrar(produto);


                        id++;
                        decisao = false;
                        break;

                    case "2":
                        carrinho.Deletar(produto);
                        decisao = false;
                        break;

                    case "3":
                        carrinho.Listar();
                        decisao = false;
                        break;

                    case "0":
                        decisao = true;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            } while (decisao == false);

        }
    }
}
