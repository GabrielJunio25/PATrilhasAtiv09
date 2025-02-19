using System;

class Aluno
{
    public string Nome { get; set; }
    public double[] Notas { get; set; }

    public Aluno(string nome, double[] notas)
    {
        Nome = nome;
        Notas = notas;
    }

    // Método para calcular a média das notas
    public double CalcularMedia()
    {
        double soma = 0;
        foreach (double nota in Notas)
        {
            soma += nota;
        }
        return soma / Notas.Length;
    }

    // Método para verificar se o aluno foi aprovado
    public bool FoiAprovado()
    {
        // Considerando média 7.0 para aprovação
        return CalcularMedia() >= 7.0;
    }

    // Método para exibir os resultados do aluno
    public void ExibirResultado()
    {
        double media = CalcularMedia();
        Console.WriteLine($"Aluno: {Nome}");
        Console.WriteLine($"Média: {media:F2}");
        if (FoiAprovado())
            Console.WriteLine("Situação: Aprovado");
        else
            Console.WriteLine("Situação: Reprovado");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade de notas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double[] notas = new double[quantidade];
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        Aluno aluno = new Aluno(nome, notas);
        Console.Clear();
        aluno.ExibirResultado();
    }
}
