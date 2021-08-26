using System;
using Objetos_argumento.Classes;

namespace Objetos_argumento
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criamos alguns produtos
            Produto p1 = new Produto(1, "Call of Duty Cold war", 450f);
            Produto p2 = new Produto(2, "Battlefield V", 239.37f);
            Produto p3 = new Produto(3, "Red Dead Redemption II", 1115.50f);
            Produto p4 = new Produto(4, "The Last of Us Part II", 151.91f);

            // Adicionamos eles ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            // Mostramos nosso carrinho completo:
            carrinho.MostrarProdutos();
        }

    }
}
