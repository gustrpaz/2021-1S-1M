namespace Exemplo_Sobrescrita.Classes
{
    // Classes abstratas não podem ser instanciadas
    public abstract class Player
    {
        private float Velocidade;
        private float ForcaPulo;

        public virtual string Correr()
        {
            return "O Player correr";
        }
        public virtual string Pular()
        {
            return "O Player pulou";
        }
    }
}
