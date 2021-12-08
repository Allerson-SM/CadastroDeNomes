using System;

namespace Cadastro_de_nomes.App
{
    public class Escolha
    {
        public static string Menu()
        {
            MensagensPadrao.MsgOpcoes();
            string escolha = Console.ReadLine();
            Console.WriteLine();
            return escolha;
        }
    }
}