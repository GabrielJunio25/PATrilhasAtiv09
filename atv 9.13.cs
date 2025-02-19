using System;

class Triangulo
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    public bool EhValido()
    {
        return (LadoA + LadoB > LadoC) && (LadoA + LadoC > LadoB) && (LadoB + LadoC > LadoA);
    }

    public string TipoTriangulo()
    {
        if (!EhValido())
            return "Triângulo inválido";
        if (LadoA == LadoB && LadoB == LadoC)
            return "Triângulo Equilátero";
        if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            return "Triângulo Isósceles";
        return "Triângulo Escaleno";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor do lado A: ");
        double ladoA = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do lado B: ");
        double ladoB = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do lado C: ");
        double ladoC = double.Parse(Console.ReadLine());

        Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
        Console.WriteLine(triangulo.TipoTriangulo());
    }
}
