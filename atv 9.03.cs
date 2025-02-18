using System;

public class Program
{
  static void Main(){
      int maior = 0;
    int[] nums = {1, 50, 32, 22, 6578, 2};
    foreach (int i in nums){
        if (i > maior){
            maior = i;
        }else{}
        
    }
      Console.WriteLine(maior);
 }
}