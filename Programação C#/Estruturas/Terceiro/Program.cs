using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nome Vazio
            bool respostaCerta = false;
            do
            {
                Console.WriteLine("\n Olá, bem-vindo ao site Grp blog vamos fazer uma pesquisa, digite o seu nome \n");
                string respostaNome = Console.ReadLine();

                if (respostaNome == "")
                {
                    do
                    {
                        Console.WriteLine("\n Nenhum nome digitado, digite um nome válido: \n");
                        respostaNome = Console.ReadLine();

                    } while (respostaNome == "");

                }
                Console.WriteLine("\n Bem vindo " + respostaNome + " você foi registrado(a) com sucesso! \n");
            } while (respostaCerta == true);





            //  Idade 0 - 150 
             int idade = 0;

            do
            {
                Console.WriteLine("\n Digite uma idade válida para seguir: \n");
                idade = int.Parse(Console.ReadLine());

                while (idade < 0)
                {
                    Console.WriteLine("\n Essa idade é invalida, digite a sua idade: \n");
                    idade = int.Parse(Console.ReadLine());
                }
            } while (idade >= 150);
                Console.WriteLine("\n Idade " + idade +" cadastrada com sucesso \n"); 



            // Salário maior que 0

            int salario = 0;
            do 
            {
                Console.WriteLine("\n Digite seu salário: \n");
                salario = int.Parse(Console.ReadLine());

                    while (salario <= 0)
                    {
                        Console.WriteLine("Esse salário é invalido, digite um salário válido: ");
                        salario = int.Parse(Console.ReadLine());
                    }
                    } while (salario > 0);
                    Console.WriteLine("\n Seu salário foi cadastrado como R$ " + salario + ".\n");
                
           
            // EstadoCivil Civil
            Console.WriteLine($@"Digite o seu estado Civil atual para a pesquisa, diante as opções:

                                 - Solteiro(a)
                                 - Casado(a)
                                 - Divorciado(a)
                                 - Víuvo(a) ");

            string estadoCivil = Console.ReadLine();

            string letra = estadoCivil.Substring(0, 1).ToLower();
            switch (letra)
            {
                case "s":
                    Console.WriteLine("\n O seu estado civil preenchido corresponde a: " + letra + ", de Solteiro(a) ");

                    break;

                case "c":
                    Console.WriteLine("\n O seu estado civil preenchido corresponde a: " + letra + ", de Casado(a) ");

                    break;

                case "d":
                    Console.WriteLine("\n O seu estado civil preenchido corresponde a: " + letra + ", de Divorciado(a) ");

                    break;

                case "v":
                    Console.WriteLine("\n O seu estado civil preenchido corresponde a: " + letra + ", de Víuvo(a) ");

                    break;

                default:
                    Console.WriteLine("\n A sua resposta não é válida ");

                    break;
            }

        }
    }
}
