using System;
using System.Collections.Generic;
using CadastroDeNomes.Domain;

namespace Cadastro_de_nomes.Operacoes
{
    public class Altera
    {
        public static void Alterar()
        {
            List<string> lista = Nomes.listaNomes;

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há nome para ser alterado");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Informe um nome a ser alterado");
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
                int indice = lista.IndexOf(nome);
                Console.WriteLine("Informe o novo nome");
                string novoNome = Console.ReadLine();
                lista[indice] = novoNome;
                Console.WriteLine("Nome alterado com sucesso!");
                Console.ReadLine();
            }

        }
    }
}