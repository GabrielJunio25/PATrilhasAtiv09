using System;

class Banco{
  public double saldo { get; set; }
  public int Cpf { get; private set; }
  public int Senha { get; private set; }

  public string abrirConta(string nome, int cpf, int senha)
  {
      Console.Clear();
      Console.WriteLine("Digite seu nome: ");
      nome = Console.ReadLine();
      Console.WriteLine("Digite seu CPF: ");
      cpf = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a senha da sua conta: ");
      senha = int.Parse(Console.ReadLine());

      // Armazena os dados na conta
      this.Cpf = cpf;
      this.Senha = senha;

      return "Conta aberta!";
  }


  
  public void saque(double valor){
      Console.Clear();
      Console.WriteLine("Saldo atual: {0}\n\n", saldo);
      Console.WriteLine("Digite o valor que deseja sacar: ");
      valor = double.Parse(Console.ReadLine());
      if (valor > saldo){
        Console.WriteLine("Saldo insuficiente!.");
      }else{
        saldo = saldo - valor;
      }
  
    }

  
  public void deposito(double valor){
      Console.Clear();
      Console.WriteLine("Saldo atual: {0}\n\n", saldo);
      Console.WriteLine("Digite o valor que deseja depositar: ");
      valor = double.Parse(Console.ReadLine());
      if (valor < 0){
        Console.WriteLine("Digite um valor real!.");  
      }else{
        saldo = saldo + valor;
      }
  }

  
public void fecharConta()
    {
        Console.Clear();
        Console.WriteLine("Digite o CPF cadastrado: ");
        int verifCpf = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a senha cadastrada: ");
        int verifSenha = int.Parse(Console.ReadLine());

        if (verifSenha == Senha && verifCpf == Cpf)
        {
            Console.WriteLine("Conta fechada!");
        }
        else
        {
            Console.WriteLine("CPF ou senha incorretos.");
        }
    }
}

public class Program
{
static void Main()
 {
    Console.Write("=================Banco=================\n ");
   Banco conta = new Banco();
    while (true){
    Console.Clear();
    Console.Write("Digite a operação desejada");
    Console.Write("\n1-Abrir Conta \n2-Saque \n3-Depósito \n4-Fechar Conta \n5-Sair ");
    Console.WriteLine("\nOpção:");
    int opcao = int.Parse(Console.ReadLine());
        switch(opcao){   
        case 1:
            Console.Clear();
            string resultado = conta.abrirConta("", 0, 0);
            Console.WriteLine(resultado);
            break;           
        case 2:
            Console.Clear();
            conta.saque(0);
            break; 
        case 3:
            Console.Clear();
            conta.deposito(0);
            break; 
        case 4:
            Console.Clear();
            conta.fecharConta();
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(); 
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