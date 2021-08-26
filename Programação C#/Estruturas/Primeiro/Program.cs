using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            while (respostaCorreta == false)
            {

                Console.WriteLine("\n Insira sua nota aqui: ");
                int nota = int.Parse(Console.ReadLine());

                if (nota <= 10)
                {
                    Console.WriteLine("Nota válida atribuída = " + nota);
                    respostaCorreta = true;
                }
                else
                {
                    Console.WriteLine("Está nota não é válida, insira outra nota novamente. ");
                }
            }
        }
    }
}
