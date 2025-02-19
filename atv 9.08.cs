using System;

class Produto
{
    public string Nome { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double precoUnitario, int quantidade)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public double CalcularValorTotal()
    {
        return PrecoUnitario * Quantidade;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço Unitário: R$ {PrecoUnitario:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Valor Total: R$ {CalcularValorTotal():F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço unitário: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        Console.WriteLine("\nDetalhes do Produto:");
        produto.ExibirDetalhes();
    }
}
