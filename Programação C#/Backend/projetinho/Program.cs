using System;

namespace projetinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno");
            string nomeAluno = Console.ReadLine();
            //var nomeAluno  = Qual é o nome do aluno?

            Console.WriteLine("Média do " + nomeAluno);
            
            Console.WriteLine("Digite a primeira nota");
            int primeiraNota = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int segundaNota = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite a terceira nota");
            int terceiraNota = int.Parse(Console.ReadLine());

            float media = (primeiraNota + segundaNota + terceiraNota)/3;

            if(media>6){
                Console.WriteLine(nomeAluno + " Aprovado");
            } else{
                Console.WriteLine(nomeAluno + " Reprovado");
            }

        }
    }
}
