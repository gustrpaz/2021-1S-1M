using System;

namespace ExercicioPOO1.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;
        Random r = new Random();


        public void Registrar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CodigoDeBarras = r.Next(300000000).ToString();
            Console.WriteLine($"\n|| Boleto gerado com o código {CodigoDeBarras} ");
            Console.WriteLine($"|| Boleto registrado com sucesso, o valor atual é de {this.Valor * 0.88:c2}. ");
            Console.ResetColor();
        }
    }
}
