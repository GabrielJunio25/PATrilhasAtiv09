using System;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Disponivel { get; private set; }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true; // Por padrão, o livro está disponível para empréstimo
    }

    // Método para verificar se o livro está disponível
    public bool VerificarDisponibilidade()
    {
        return Disponivel;
    }

    // Método para realizar o empréstimo do livro
    public void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Empréstimo realizado: o livro \"{Titulo}\" foi emprestado.");
        }
        else
        {
            Console.WriteLine($"O livro \"{Titulo}\" não está disponível para empréstimo.");
        }
    }

    // Método opcional para devolver o livro
    public void Devolver()
    {
        Disponivel = true;
        Console.WriteLine($"O livro \"{Titulo}\" foi devolvido e está disponível para empréstimo.");
    }
}

class Program
{
    static void Main()
    {
        // Cria um novo livro
        Livro livro = new Livro("Dom Casmurro", "Machado de Assis");

        // Exibe os dados do livro e a disponibilidade
        Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
        Console.WriteLine($"Disponibilidade: {(livro.VerificarDisponibilidade() ? "Disponível" : "Indisponível")}");

        // Tenta realizar o empréstimo
        livro.Emprestar();

        // Verifica novamente a disponibilidade
        Console.WriteLine($"Disponibilidade: {(livro.VerificarDisponibilidade() ? "Disponível" : "Indisponível")}");

        // Tenta emprestar novamente (deve informar que não está disponível)
        livro.Emprestar();

        // Devolve o livro
        livro.Devolver();

        // Verifica a disponibilidade após a devolução
        Console.WriteLine($"Disponibilidade: {(livro.VerificarDisponibilidade() ? "Disponível" : "Indisponível")}");
    }
}
