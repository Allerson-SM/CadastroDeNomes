
using System.Collections.Generic;

namespace CadastroDeNomes.Domain
{
    public class Nomes
    {
        public static List<string> listaNomes = new List<string>();

        public static void Cadastrar(string nome)
        {
            listaNomes.Add(nome);
        }

        public static void Excluir(string nome)
        {
            listaNomes.Remove(nome);
        }
    }
}
