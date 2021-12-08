using System;
using System.Collections.Generic;
using CadastroDeNomes.Domain;

namespace Cadastro_de_nomes.Operacoes
{
    public class Consulta
    {
        public static void Consultar()
        {
            List<string> lista = Nomes.listaNomes;

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum nome cadastrado");
                return;
            }
            else
            {
                foreach (string nome in lista)
                {
                    int indice = lista.IndexOf(nome) + 1;
                    Console.WriteLine($"{indice} - Nome: {nome}");
                }
            }

        }
    }
}