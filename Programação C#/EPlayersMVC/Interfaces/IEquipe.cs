using System.Collections.Generic;
using EPlayersASPNet.Models;

namespace EPlayersASPNet.Interfaces
{
    public interface IEquipe 

    {
         void Cadastrar (Equipe e);

         List<Equipe> LerTodos();

         void Alterar (Equipe e);

         void Deletar (int id);
    }
}