using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            do
            {
                Console.Clear();
                Console.WriteLine ("Olá, para realizar o cadastro em nossa página digite seu nome de usuário: \n");
                string Nome = (Console.ReadLine());
          
                Console.WriteLine ("\n Digite uma senha para o seu registro: \n");
                string Senha = (Console.ReadLine());

                if (Nome == Senha)
                {
                  do
                  {
                   Console.WriteLine("\n A senha não pode ser igual ao nome de usuário. Digite outra senha: \n");
                   Senha = Console.ReadLine();

                  }while (Nome == Senha);
                }
                
            }while (respostaCorreta == true);
            Console.WriteLine ("\n Usuário cadastrado com sucesso!");
        }
    }
}
