namespace Exercicio_Jogador.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public string Aposentar()
        {
            if (CalcularIdade() < 38)
            {
                TempoRestante = 38 - CalcularIdade();
                return $"O Tempo restante para o jogador é {TempoRestante} Anos, para se aposentar";

            }
            else
            {
                return $"O jogador pode aposentar";
            }

        }
    }
}