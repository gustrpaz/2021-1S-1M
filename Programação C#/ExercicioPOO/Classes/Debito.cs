using System;
namespace ExercicioPOO1.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar()
        {
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVocê não possui saldo suficiente para pagar esse valor.");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nO valor de {valor:C2} foi pago com sucesso.");
                Console.ResetColor();
            }
        }
    }
}