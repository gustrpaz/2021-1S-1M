using System;
using Exemplo_Sobrecarga.Classes;

namespace Exemplo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
             Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            Console.WriteLine("Método mostrar sem argumentos");
            f.Mostrar();

            Console.WriteLine("Método mostrar com argumentos tipo 'int'.");
            f.Mostrar(2);

            Console.WriteLine("Método mostrar com argumentos tipo 'string'.");
            f.Mostrar("maçã");
        }
    }
}
