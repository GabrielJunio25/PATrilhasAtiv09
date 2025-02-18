using System;

public class Program
{
  static void Main(){
      int longa = 0;
      string txt = "";
      string[] lendas = {"Ronaldo", "Messi", "CR7", "Zidane", "Alex", "Neymar"};
    foreach (string i in lendas){
        if (i.Length > longa){
            longa = i.Length;
            txt = i;
        }
        
    }
      Console.WriteLine(txt);
 }
}