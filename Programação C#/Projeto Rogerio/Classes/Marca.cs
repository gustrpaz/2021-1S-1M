using System;
using System.Collections.Generic;

namespace Projeto_Produtos.Classes
{
    public class Marca
    {
        public int Codigo;
        public string NomeMarca;
        public DateTime DataCadastro;
        List<Marca> ListaMarca = new List<Marca>();

        public void Cadastrar(Marca marca)
        {
            ListaMarca.Add(marca);
        }

        public void Deletar (Marca marca)
        {
            ListaMarca.Remove(marca);
        }

        public List<Marca> Listar()
        {
            return ListaMarca;
        }

    }
}