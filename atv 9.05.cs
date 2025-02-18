using System;

public class Program
{
  static void Main(){
      double soma = 0;
      double[] lendas = {1, 2, 3, 4, 5, 6};
    foreach (double i in lendas){
        soma = soma + i;
        }   
    Console.WriteLine($"a média dos números é: {soma / lendas.Length}");
    }
}