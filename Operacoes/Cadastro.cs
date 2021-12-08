using System;
using System.Collections.Generic;
using CadastroDeNomes.Domain;

namespace Cadastro_de_nomes.Operacoes
{
    public partial class Cadastro
    {

        public static void Cadastrar()
        {
            List<string> lista = Nomes.listaNomes;
            Console.WriteLine("Informe um nome a ser cadastrado");
            string nome = Console.ReadLine();

            bool NomeValido = Validar.ValidarNomeCadastro(nome, lista);

            if (!NomeValido)
            {
                return;
            }
            else
            {
                Nomes.Cadastrar(nome);
                Console.WriteLine("Nome cadastrado com sucesso!");
                Console.ReadLine();
            }

        }

    }
}