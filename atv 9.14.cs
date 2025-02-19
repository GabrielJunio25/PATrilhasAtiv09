using System;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
    }
}

class Agenda
{
    private List<Contato> contatos;

    public Agenda()
    {
        contatos = new List<Contato>();
    }

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    public bool RemoverContato(string nome)
    {
        Contato contatoARemover = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contatoARemover != null)
        {
            contatos.Remove(contatoARemover);
            Console.WriteLine("Contato removido com sucesso!");
            return true;
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
            return false;
        }
    }

    public Contato BuscarContatoPorNome(string nome)
    {
        return contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    public void ListarContatos()
    {
        if (contatos.Count == 0)
            Console.WriteLine("Agenda vazia!");
        else
            foreach (var c in contatos)
                Console.WriteLine(c);
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("Agenda de Contatos");
            Console.WriteLine("1 - Adicionar Contato");
            Console.WriteLine("2 - Remover Contato");
            Console.WriteLine("3 - Buscar Contato");
            Console.WriteLine("4 - Listar Contatos");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o telefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Digite o email: ");
                    string email = Console.ReadLine();
                    Contato contato = new Contato(nome, telefone, email);
                    agenda.AdicionarContato(contato);
                    break;
                case 2:
                    Console.Write("Digite o nome do contato a remover: ");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemoverContato(nomeRemover);
                    break;
                case 3:
                    Console.Write("Digite o nome do contato a buscar: ");
                    string nomeBuscar = Console.ReadLine();
                    Contato contatoEncontrado = agenda.BuscarContatoPorNome(nomeBuscar);
                    if (contatoEncontrado != null)
                    {
                        Console.WriteLine("Contato encontrado:");
                        Console.WriteLine(contatoEncontrado);
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Lista de Contatos:");
                    agenda.ListarContatos();
                    break;
                case 5:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
