using CadastroDeNomes.Classes;
using System;
using System.Collections.Generic;

namespace CadastroDeNomes
{
    class Program
    {
        static Nomes nomes = new Nomes();
        static void Main(string[] args)
        {
            string escolha = Menu();

            while (escolha.ToUpper() != "FIM")
            {
                switch (escolha)
                {
                    case "1":
                        Cadastrar();
                        break;
                    case "2":
                        Alterar();
                        break;
                    case "3":
                        Consultar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    default:
                        Console.WriteLine("Digite algum número de 1 a 4 ou FIM para sair");
                        Menu();
                        break;
                }
                escolha = Menu();
            }
            Console.WriteLine("Obrigado por utilizar o sistema!");
            Console.WriteLine("Saindo...");
            Environment.Exit(0);

        }
        private static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao menu!");
            Console.WriteLine();
            Console.WriteLine("Digite uma das opções abaixo");
            Console.WriteLine("1 - Cadastrar nome");
            Console.WriteLine("2 - Alterar nome");
            Console.WriteLine("3 - Consultar nome");
            Console.WriteLine("4 - Excluir nome");
            Console.WriteLine("FIM - Sair");

            string escolha = Console.ReadLine();
            Console.WriteLine();
            return escolha;
        }

        private static void Cadastrar()
        {
            List<string> lista = nomes.listaNomes;
            Console.WriteLine("Informe um nome a ser cadastrado");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) == true)
            {
                Console.WriteLine("Nome inválido");
                Console.ReadLine();
                return;
            }
            else if (lista.Contains(nome) == true)
            {
                Console.WriteLine("Este nome já está cadastrado!");
                Console.ReadLine();
                return;
            }
            else
            {
                nomes.Cadastrar(nome);
                Console.WriteLine("Nome cadastrado com sucesso!");
                Console.ReadLine();
            }

        }

        private static void Consultar()
        {
            List<string> lista = nomes.listaNomes;

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

        private static void Excluir()
        {
            List<string> lista = nomes.listaNomes;


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
                nomes.Excluir(nome);
                Console.WriteLine("Nome excluído com sucesso!");
                Console.ReadLine();
            }

        }

        private static void Alterar()
        {
            List<string> lista = nomes.listaNomes;

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
