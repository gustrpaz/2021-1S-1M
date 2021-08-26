using System;
using Exemplo_Sobrescrita.Classes;

namespace Exemplo_Sobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine(m.Pular());

            Console.WriteLine(m.Correr());

            Console.WriteLine(z.Pular());

            Console.WriteLine(z.Correr());
        }
    }
}
