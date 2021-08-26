namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor = "Cor: Azul";
        public bool desligar = true;
        public string modelo = "Modelo: Iphone 8";
        public string tamanho = "Tamanho: 11.5 cm A,	6.1 cm L	1.16 cm E";
        public bool Ligar()
        {
            return desligar = false;
        }
        public string Desligar()
        {
            return "Bye Bye...";
        }
        public string FazerLigacao(string contato)
        {

            string chamando = $@"
 ____________________________         
||______________________0 O_||
||                          ||
||                          ||
||     Calling {contato}       
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||  |====================|  ||
||  |   Caixa Postal!    |  ||
||  | Aparelho sem sinal |  ||
||  |===================+|  ||
||                          ||                        
||                          ||
||                          ||
||                          ||
||__________________________||
||____________O_____________||";

            return chamando;

        }
        public string EnviarMensagem(string contato, string mensagem)
        {
            string enviado = $@"
 ____________________________         
||______________________0 O_||
||                          ||
||  {contato}
||  status: online       [] ||
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||                          ||
||          ________________||
||          |               ||
||          |  {mensagem}      
||          |               ||                        
||          |_______________||
||                          ||
||                          ||
||__________________________||
||____________O_____________||";

            return enviado;
        }

    }
}