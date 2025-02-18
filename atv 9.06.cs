using System;

class Calculadora {
  public double Soma (double x , double y){
    return x + y;
  }
  public double Subt (double x, double y){
      return x - y;
  }
  public double Multi( double x, double y){
      return x * y;
  }
  public double Divisao(double x, double y){
      if (y == 0)
      {
          throw new DivideByZeroException("Erro: divisão por zero não permitida.");
      }
      return x / y;  
  }
}

public class Program
{
static void Main()
 {
    Console.Write("=================CALCULADORA=================\n ");
    Console.WriteLine("Digite dois números: ");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
     Console.Clear();
    while (true){
    Console.Write("Digite a operação desejada");
    Console.Write("\n1-Soma \n2-Subtração \n3-Multiplicação \n4-Divisão \n5-Sair ");
    Console.WriteLine("\nOpção:");
    int opcao = int.Parse(Console.ReadLine());
        Calculadora calc = new Calculadora();
        switch(opcao){   
        case 1:
            Console.Clear();
            Console.WriteLine($"\n{x} + {y} = {calc.Soma(x, y)}\n\n\n");
            break;           
        case 2:
            Console.Clear();
            Console.WriteLine($"\n{x} - {y} = {calc.Subt(x, y)}\n\n\n");
            break; 
        case 3:
            Console.Clear();
            Console.WriteLine($"\n{x} x {y} = {calc.Multi(x, y)}\n\n\n");
            break; 
        case 4:
            Console.Clear();
            Console.WriteLine($"\n{x} / {y} = {calc.Divisao(x, y)}\n\n\n");
            break; 
        case 5:
            return;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, tente novamente.\n\n");
            break;
            
        }
        
    }
 }
}