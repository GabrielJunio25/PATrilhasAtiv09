using System;

class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Retangulo(double baseValue, double altura)
    {
        Base = baseValue;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a base do retângulo: ");
        double baseValue = double.Parse(Console.ReadLine());
        Console.Write("Digite a altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());

        Retangulo retangulo = new Retangulo(baseValue, altura);
        Console.WriteLine("Área: " + retangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());
    }
}
