using System;
using System.Collections.Generic;

namespace Projeto_Produtos.Classes
{
    public class Login
    {

        Usuario usuario = new Usuario();
        Marca marcas = new Marca();
        Produto produtos = new Produto();

        int cod_marca = 0;
        int cod_produto = 0;

        string opcaoMarca;
        string opcaoProduto;

        public Login()
        {
            //
            // Faz Login
            //
            bool resultado_login;
            
            do
                resultado_login = TrataLogin();
            while (resultado_login == false);

            while (true) {

                //
                // Pede Marca
                //
                string opcaoMarca = TrataMarca();
                if (opcaoMarca == "5") {
                    Environment.Exit(0);
                }

                //
                // Pede Produto
                //
                string opcaoProduto = TrataProduto();

            };



        }

        private bool TrataLogin() {

            Console.Clear();

            //------------------------------------
            //
            // Parte de Login 
            //
            Console.WriteLine("------------------------------------");
            Console.WriteLine("|                                   ");
            Console.WriteLine("|   Bem vindo(a) ao site Grpaz      ");
            Console.WriteLine("|                                   ");
            Console.WriteLine("|   1- Fazer Login                  ");
            Console.WriteLine("|   2- Criar uma conta              ");
            Console.WriteLine("|   3- Sair                         ");
            Console.WriteLine("|                                   ");
            Console.WriteLine("------------------------------------");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.Write(" Digite o seu nome: ");
                    usuario.Nome = Console.ReadLine();

                    Console.Write("Digite o seu email: ");
                    usuario.Email = Console.ReadLine();

                    Console.Write("Digite o sua senha: ");
                    usuario.Senha = Console.ReadLine();

                    return true;

                case "2":
                    Console.Write("");
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Write("Opção invalida");
                    break;
            }

            return false;

        }

        private string TrataMarca() {

            //----------------------------------
            //
            // Parte de Cadastrar Marcas 
            //
            bool decisao = false;
            string opcaoMarca;

            do
            {

                Console.Clear();

                Console.WriteLine("-- MARCA -----------------------");
                Console.WriteLine("|  Digite para:                 ");
                Console.WriteLine("|                               ");
                Console.WriteLine("|  1- Cadastrar Marca           ");
                Console.WriteLine("|  2- Listar Marca              ");
                Console.WriteLine("|  3- Deletar Marca             ");
                Console.WriteLine("|  4- Ir para produtos          ");
                Console.WriteLine("|  5- Sair                      ");
                Console.WriteLine("--------------------------------");

                opcaoMarca = Console.ReadLine();

                switch (opcaoMarca)
                {
                    case "1":

                        // OBS: marca_ É instanciado, somente gerado para receber as infos.
                        
                        cod_marca = cod_marca + 1;

                        Marca marca_ = new Marca();

                        Console.Write("Nome da marca: ");
                        marca_.NomeMarca = Console.ReadLine();
                        marca_.Codigo = cod_marca;
                        marca_.DataCadastro = DateTime.Now;

                        marcas.Cadastrar(marca_);

                        break;

                    case "2":

                        Console.Clear();

                        ListarMarcas();

                        Console.WriteLine("Pressione uma tecla...");
                        Console.ReadKey();

                        break;

                    case "3":

                        List<Marca> listaMarcas = marcas.Listar();

                        Console.Write("Digite o nome da marca que deseja deletar: ");
                        string nomeMarca1 = Console.ReadLine();

                        Marca MarcaEncontrada = listaMarcas.Find(x => x.NomeMarca == nomeMarca1);

                        marcas.Deletar(MarcaEncontrada);

                        break;

                    case "4":
                        decisao = true;
                        break;

                    case "5":
                        decisao = true;
                        break;

                    default:
                        Console.WriteLine("Essa opção é invalida");
                        break;
                }

            } while (decisao == false);

            return opcaoMarca;

        }

        private string TrataProduto() {

            //----------------------------------------
            //
            // Parte de Cadastrar Produtos
            //
            bool decisaoProduto = false;
            string opcaoProduto;

            do
            {

                int marca_escolhida;

                Console.Clear();

                Console.WriteLine("-- PRODUTO --------------------------------");
                Console.WriteLine("|  O que deseja fazer:              ");
                Console.WriteLine("|                                   ");
                Console.WriteLine("|  1- Cadastrar Produto             ");
                Console.WriteLine("|  2- Listar Produto                ");
                Console.WriteLine("|  3- Deletar Produto               ");
                Console.WriteLine("|  4- Voltar Menu                   ");
                Console.WriteLine("-------------------------------------------");

                opcaoProduto = Console.ReadLine();

                switch (opcaoProduto)
                {
                    case "1":

                        List<Marca> listaMarcas = marcas.Listar();      

                        cod_produto = cod_produto + 1;

                        Produto produto_ = new Produto();

                        ListarMarcas();

                        //------------------------------------------------------

                        Console.Write(" Digite o nome do produto: ");
                        produto_.NomeProduto = Console.ReadLine();

                        Console.Write("Digite o preço do produto: ");
                        produto_.Preco = float.Parse(Console.ReadLine());

                        Console.Write(" Digite o codigo da Marca: ");
                        marca_escolhida = Int32.Parse(Console.ReadLine());

                        produto_.marca = listaMarcas.Find(x => x.Codigo == marca_escolhida);

                        //------------------------------------------------------

                        produto_.CodigoProduto = cod_produto;
                        produto_.DataCadastro = DateTime.Now;

                        produtos.Cadastrar(produto_);

                        break;

                    case "2":

                        Console.Clear();

                        List<Produto> lista = produtos.Listar();

                        if (lista != null)
                        {

                            Console.WriteLine("----------- PRODUTOS CADASTRADOS ------------");

                            foreach (var x in lista)
                            {
                                Console.WriteLine("|   Cod.Produto: " + x.CodigoProduto);
                                Console.WriteLine("|       Produto: " + x.NomeProduto);
                                Console.WriteLine("|   Dt.Cadastro: " + x.DataCadastro);
                                Console.WriteLine("|         Marca: " + x.marca.Codigo + " - " + x.marca.NomeMarca);
                                Console.WriteLine("|         Preço: " + x.Preco);
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            Console.Write("Está nula.");
                        }

                        Console.WriteLine("Pressione uma tecla...");
                        Console.ReadKey();

                        break;

                    case "3":

                        List<Produto> listaProdutos = produtos.Listar();

                        Console.Write("Digite o nome do produto que deseja deletar: ");
                        string nomeProduto1 = Console.ReadLine();

                        Produto ProdutoEncontrado = listaProdutos.Find(x => x.NomeProduto == nomeProduto1);

                        produtos.Deletar(ProdutoEncontrado);

                        break;

                    case "4":
                        decisaoProduto = true;
                        break;


                    default:
                        Console.WriteLine("Essa opção é invalida");
                        break;
                }

            } while (decisaoProduto == false);

            return opcaoProduto;

        }

        private void ListarMarcas() {
            
            //
            // Funcao Usada para Listas as Marcas            
            //

            List<Marca> lista = marcas.Listar();

            if (lista != null)
            {

                Console.WriteLine("----------- MARCAS CADASTRADAS ------------");

                foreach (var x in lista)
                {
                    Console.WriteLine("|      Codigo: " + x.Codigo);
                    Console.WriteLine("|       Marca: " + x.NomeMarca);
                    Console.WriteLine("| Dt.Cadastro: " + x.DataCadastro);
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.Write("Está nula.");
            }

        }





    }
}
