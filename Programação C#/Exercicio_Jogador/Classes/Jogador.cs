using System;
namespace Exercicio_Jogador.Classes
{
    public abstract class Jogador
    {
        public string Nome;
        public int DataNasc;
        public string Nacionalidade;
        public int TempoRestante;
        public double Altura;
        public double Peso;
        public int Idade;


        public string ImprimirDados()
        {
            return $@"
=========================
  Informações do jogador
  Nome: {Nome}
  Ano de Nascimento: {DataNasc}
  Nacionalidade: {Nacionalidade}
  Altura: {Altura}
  Peso: {Peso}
=========================
";
        }
        public int CalcularIdade()
        {
            return Idade = DateTime.Now.Year - DataNasc;
        }



    }


}

