using Cadastro_de_nomes.App;

namespace CadastroDeNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagensPadrao.MsgBemVindo();
            string escolha = Escolha.Menu();
            Opcoes.OpcoesASelecionar(escolha);
            MensagensPadrao.MsgEncerra();
        }
    }
}
