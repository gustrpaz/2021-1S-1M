using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introdução
            Console.WriteLine("Olá funcionário, precisamos fazer uma pesquisa com você! \n");
            Console.WriteLine ("Digite o seu salário atual: ");
            float salario = float.Parse (Console.ReadLine());

            // Regulando salário
            float ajuste = (salario/100)*30;
             
            // Condição
            if (salario < 500){
                salario = salario + ajuste;
                Console.WriteLine("Salário ajustado para " + salario);
            }
            else {
            Console.WriteLine("Você ainda não possui direito ao aumento de salário");
            }
        }
    }
}
