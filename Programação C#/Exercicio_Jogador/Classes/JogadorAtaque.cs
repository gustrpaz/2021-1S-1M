namespace Exercicio_Jogador.Classes
{
    public class JogadorAtaque : Jogador
    {

        public string Aposentar()
        {
            if (CalcularIdade() < 35)
            {
                TempoRestante = 35 - CalcularIdade();
                return $"O Tempo restante para o jogador é {TempoRestante} Anos, para se aposentar";

            }
            else
            {
                return $"O jogador pode aposentar";
            }

        }
    }
}