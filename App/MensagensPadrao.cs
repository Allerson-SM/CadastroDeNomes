using System;

namespace Cadastro_de_nomes.App
{
    public class MensagensPadrao
    {
        public static void MsgBemVindo()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao menu!");
            Console.WriteLine();
        }

        public static void MsgOpcoes()
        {
            Console.WriteLine("Digite uma das opções abaixo");
            Console.WriteLine("1 - Cadastrar nome");
            Console.WriteLine("2 - Alterar nome");
            Console.WriteLine("3 - Consultar nome");
            Console.WriteLine("4 - Excluir nome");
            Console.WriteLine("X - Sair");
        }

        public static void MsgEncerra()
        {
            Console.WriteLine("Obrigado por utilizar o sistema!");
            Console.WriteLine("Saindo...");
        }

        public static void MsgErroEscolha()
        {
            Console.WriteLine("Digite algum número de 1 a 4 ou X para sair");
        }
    }
}