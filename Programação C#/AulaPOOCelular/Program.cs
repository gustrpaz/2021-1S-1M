using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Iphone = new Celular();
            string contato;

            Console.Clear();

            Console.WriteLine(Iphone.modelo);
            Console.WriteLine(Iphone.cor);
            Console.WriteLine(Iphone.tamanho);




            Console.WriteLine("Universo: Dia lindo pra mexer no seu celular novo né, ligue seu celular... Dica: Ligar \n");
            string VouLigar = Console.ReadLine().ToLower();

            Console.WriteLine("\n");
            if (VouLigar == "ligar")
            {
                Iphone.Ligar();

                // if ja avalia se é true
                // ! = false
                if (!Iphone.Ligar())
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(@"
 ____________________________         
||______________________0 O_||
||   ____________________   ||
||  |                    |  ||
||  |    Hello Welcome   |  ||
||  |                    |  ||
||  |____________________|  ||
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||      2- Desligar         ||
||                          ||
||    3- Fazer Ligação      ||
||    4- Enviar Mensagem    ||
||__________________________||
||____________O_____________||

");
                        string escolha = Console.ReadLine();
                        switch (escolha)
                        {
                            case "2":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(Iphone.Desligar());
                                Iphone.desligar = true;
                                break;

                            case "3":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("Digite o contato que deseja telefonar: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                contato = Console.ReadLine();


                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(Iphone.FazerLigacao(contato));
                                Iphone.desligar = false;
                                break;

                            case "4":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("\nDigite o contato para quem deseja enviar uma mensagem: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                contato = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Digite a mensagem: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                string mensagem = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(Iphone.EnviarMensagem(contato, mensagem));
                                Iphone.desligar = false;
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Opção invalida.");
                                Iphone.desligar = false;
                                break;
                        }

                    } while (Iphone.desligar == false);

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Universo: Poxa amigão deveria ter ligado direito hein...");
            }
            Console.ResetColor();



        }
    }
}



