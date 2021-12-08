using Cadastro_de_nomes.Operacoes;

namespace Cadastro_de_nomes.App
{
    public class Opcoes
    {
        public static void OpcoesASelecionar(string escolha)
        {
            while (escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1":
                        Cadastro.Cadastrar();
                        break;
                    case "2":
                        Altera.Alterar();
                        break;
                    case "3":
                        Consulta.Consultar();
                        break;
                    case "4":
                        Exclui.Excluir();
                        break;
                    default:
                        MensagensPadrao.MsgErroEscolha();
                        break;
                }
                escolha = Escolha.Menu();
            }
        }

    }
}