using System;

class ContaBancaria
{
    private double saldo;

    public ContaBancaria()
    {
        saldo = 0;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor inválido para depósito.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido.");
        }
    }

    public void VerificarSaldo()
    {
        Console.WriteLine("Saldo atual: R$ " + saldo);
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Verificar Saldo");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor para depósito: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 2:
                    Console.Write("Digite o valor para saque: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 3:
                    conta.VerificarSaldo();
                    break;
                case 4:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
