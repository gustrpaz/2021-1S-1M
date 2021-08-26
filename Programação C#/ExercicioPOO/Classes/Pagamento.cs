using System;
namespace ExercicioPOO1.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;
        protected float Valor = 1950f;

        public string Cancelar(){
            Console.ForegroundColor = ConsoleColor.Red;
            return "\nPagamento Cancelado.\n";
        }
    }
}