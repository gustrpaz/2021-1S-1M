using System;
using System.Diagnostics;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduzindo a idade 
            Console.WriteLine ("Olá, vamos fazer um experimento para analisar sua idade de diferentes formas! \n");
            Console.WriteLine ("Digite a sua idade em anos: ");
            double idade = double.Parse (Console.ReadLine());
            
            // Operações com os dados coletados
            double idadeMeses = idade*12;
            double idadeDias =  idadeMeses *30;
            double idadeHoras = idadeDias *24;
            double idadeMinutos = idadeHoras *60;
             
            // Finalização
            Console.WriteLine ("Experimento de idades finalizado");
            Console.WriteLine ($@"A sua idade em: 
            Anos: {idade}
            Meses: {idadeMeses}
            Dias: {idadeDias}
            Horas: {idadeHoras}
            Minutos: {idadeMinutos}");
        }
    }
}
