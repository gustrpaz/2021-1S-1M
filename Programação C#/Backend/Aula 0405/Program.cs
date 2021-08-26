using System;

namespace Aula_0405
{
    class Program
    {
        static void Main(string[] args)

        {
            bool respostaCorreta = false;
            while (respostaCorreta == false)

            {
                Console.Clear();
                Console.WriteLine("\n Olá, seja bem vindo a natação Grp Aquatic, para cadastrar digite sua idade : \n");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Você está na categoria Infântil A, 5 - 7 anos.");
                    Console.WriteLine("Você deseja cadastrar outra idade? Digite 'y' para sim, ou 'n' para não: \n");
                    string resposta = (Console.ReadLine());

                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado, idade cadastrada: " + idade);
                        respostaCorreta = true;
                    }
                }


                else if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Você está na categoria Infântil B, 8 - 10 anos.");
                    Console.WriteLine("Você deseja cadastrar outra idade? Digite 'y' para sim, ou 'n' para não: \n");
                    string resposta = (Console.ReadLine());

                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado, idade cadastrada: " + idade);
                        respostaCorreta = true;
                    }
                }


                else if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("Você está na categoria Juvênil A, 11 - 13 anos.");
                    Console.WriteLine("Você deseja cadastrar outra idade? Digite 'y' para sim, ou 'n' para não: \n");
                    string resposta = (Console.ReadLine());

                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado, idade cadastrada: " + idade);
                        respostaCorreta = true;
                    }
                }


                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Você está na categoria Juvênil B, 14 - 17 anos.");
                    Console.WriteLine("Você deseja cadastrar outra idade? Digite 'y' para sim, ou 'n' para não: \n");
                    string resposta = (Console.ReadLine());

                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado, idade cadastrada: " + idade);
                        respostaCorreta = true;
                    }
                }


                else if (idade >= 18)
                {
                    Console.WriteLine("Você está na categoria Sênior, maiores de 18 anos.");
                    Console.WriteLine("Você deseja cadastrar outra idade? Digite 'y' para sim, ou 'n' para não: \n");
                    string resposta = (Console.ReadLine());

                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado, idade cadastrada: " + idade);
                        respostaCorreta = true;
                    }
                }


                else
                {
                    Console.WriteLine("Você não se enquadra em nenhuma categoria, digite uma idade válida novamente para a inscrição.");
                    Console.WriteLine("Caso não queira inserir outra idade digite 'n', caso queira digite 'y': \n");
                    string resposta = (Console.ReadLine());
                    
                    if (resposta == "n")
                    {
                        Console.WriteLine("\nCategorizador finalizado.");
                        respostaCorreta = true;
                    }

                    if (resposta == "y")
                    {
                        respostaCorreta = false;
                    }
                }
            }
        }
    }
}

