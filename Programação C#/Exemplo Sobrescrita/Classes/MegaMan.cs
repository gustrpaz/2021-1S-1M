namespace Exemplo_Sobrescrita.Classes
{
    public class MegaMan : Player
    {
        private string Buster;

        public override string Correr()
        {
            return "O MegaMan correu muito tá maluco";
        }
    }
}