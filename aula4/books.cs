using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> livros = new Dictionary<string, List<string>>();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar autor");
            Console.WriteLine("2 - Cadastrar livro");
            Console.WriteLine("3 - Consultar livro");
            Console.WriteLine("4 - Excluir livro");
            Console.WriteLine("5 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do autor: ");
                    string autor = Console.ReadLine();
                    if (!livros.ContainsKey(autor))
                    {
                        livros.Add(autor, new List<string>());
                        Console.WriteLine($"Autor {autor} cadastrado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"O autor {autor} já está cadastrado.");
                    }
                    break;

                case 2:
                    Console.Write("Digite o nome do autor: ");
                    autor = Console.ReadLine();
                    if (!livros.ContainsKey(autor))
                    {
                        Console.WriteLine($"O autor {autor} não está cadastrado.");
                    }
                    else
                    {
                        Console.Write("Digite o nome do livro: ");
                        string livro = Console.ReadLine();
                        livros[autor].Add(livro);
                        Console.WriteLine($"Livro {livro} cadastrado com sucesso para o autor {autor}.");
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome do autor: ");
                    autor = Console.ReadLine();
                    if (!livros.ContainsKey(autor))
                    {
                        Console.WriteLine($"O autor {autor} não está cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine($"Livros do autor {autor}:");
                        foreach (string livro in livros[autor])
                        {
                            Console.WriteLine(livro);
                        }
                    }
                    break;

                case 4:
                    Console.Write("Digite o nome do autor: ");
                    autor = Console.ReadLine();
                    if (!livros.ContainsKey(autor))
                    {
                        Console.WriteLine($"O autor {autor} não está cadastrado.");
                    }
                    else
                    {
                        Console.Write("Digite o nome do livro: ");
                        string livro = Console.ReadLine();
                        if (livros[autor].Remove(livro))
                        {
                            Console.WriteLine($"Livro {livro} excluído com sucesso do autor {autor}.");
                        }
                        else
                        {
                            Console.WriteLine($"O livro {livro} não está cadastrado para o autor {autor}.");
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
