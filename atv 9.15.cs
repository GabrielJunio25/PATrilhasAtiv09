using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"Produto: {Nome}, Preço: R$ {Preco:F2}, Quantidade: {Quantidade}";
    }
}

class CarrinhoDeCompras
{
    private List<Produto> itens;

    public CarrinhoDeCompras()
    {
        itens = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        itens.Add(produto);
        Console.WriteLine("Produto adicionado ao carrinho!");
    }

    public double CalcularValorTotal()
    {
        double total = 0;
        foreach (var p in itens)
        {
            total += p.Preco * p.Quantidade;
        }
        return total;
    }

    public void ExibirItens()
    {
        if (itens.Count == 0)
            Console.WriteLine("O carrinho está vazio!");
        else
        {
            Console.WriteLine("Itens do carrinho:");
            foreach (var p in itens)
                Console.WriteLine(p);
        }
    }
}

class Program
{
    static void Main()
    {
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Exibir itens do carrinho");
            Console.WriteLine("3 - Calcular valor total da compra");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    Produto produto = new Produto(nome, preco, quantidade);
                    carrinho.AdicionarProduto(produto);
                    break;
                case 2:
                    carrinho.ExibirItens();
                    break;
                case 3:
                    double total = carrinho.CalcularValorTotal();
                    Console.WriteLine("Valor total da compra: R$ " + total.ToString("F2"));
                    break;
                case 4:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine();
        }
    }
}
