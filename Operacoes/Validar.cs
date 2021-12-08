using System;
using System.Collections.Generic;

namespace Cadastro_de_nomes.Operacoes
{
    public class Validar
    {
        public static bool ValidarNomeCadastro(string nome, List<string> lista)
        {
            if (string.IsNullOrWhiteSpace(nome) == true)
            {
                Console.WriteLine("Nome inválido");
                Console.ReadLine();
                return false;
            }
            else if (lista.Contains(nome) == true)
            {
                Console.WriteLine("Este nome já está cadastrado!");
                Console.ReadLine();
                return false;
            }
            return true;
        }
    }
}