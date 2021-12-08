using System;
using System.Collections.Generic;
using CadastroDeNomes.Domain;

namespace Cadastro_de_nomes.Operacoes
{
    public class Exclui
    {
        public static void Excluir()
        {
            List<string> lista = Nomes.listaNomes;

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há nome para ser excluído");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Informe um nome para ser removido");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) == true)
            {
                Console.WriteLine("Informe um nome válido!");
                Console.ReadLine();
                return;
            }
            else if (lista.Contains(nome) == false)
            {
                Console.WriteLine("Este nome não está cadastrado!");
                Console.ReadLine();
                return;
            }
            else
            {
                Nomes.Excluir(nome);
                Console.WriteLine("Nome excluído com sucesso!");
                Console.ReadLine();
            }

        }
    }
}