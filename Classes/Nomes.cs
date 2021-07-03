using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeNomes.Classes
{
    public class Nomes
    {
        public List<string> listaNomes = new List<string>();

        public void Cadastrar(string nome)
        {
            listaNomes.Add(nome);
        }

        public void Excluir(string nome)
        {
            listaNomes.Remove(nome);
        }


    }
}
