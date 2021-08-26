using System;
using System.Collections.Generic;

namespace Projeto_Produtos.Classes
{
    public class Produto
    {
        public int CodigoProduto;
        public string NomeProduto;
        public float Preco;
        public DateTime DataCadastro;
        public Marca marca;
        public Usuario CadastradoPor;
        List<Produto> ListaProduto = new List<Produto>();

        public void Cadastrar(Produto produto)
        {
            ListaProduto.Add(produto);
        }

        public void Deletar (Produto produto)
        {
            ListaProduto.Remove(produto);
        }
        public List<Produto> Listar()
        {
            return ListaProduto;
        }


    }
}