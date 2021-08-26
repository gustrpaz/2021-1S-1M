using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introdução
            Console.WriteLine ("Olá,vamos fazer a conversão de idade em semanas com datas \n");
            Console.WriteLine ("Digite o seu ano de nascimento: ");
            double dataNascimento = double.Parse (Console.ReadLine());

            Console.WriteLine ("Digite o ano atual");
            double dataAtual = double.Parse (Console.ReadLine());

            
            double idade = dataAtual - dataNascimento;
            double semana = idade * 52;

            // Finalização
            Console.WriteLine ("Conversão de idade em semanas com datas finalizada");
            Console.WriteLine ($@"A sua idade: 
            Anos: {idade}
            Semanas: {semana}");
        }
    }
}
