double saldo = 0;
int opcao;

while (true)
{
    Console.WriteLine("Caixa Eletronico");
    Console.WriteLine("1. Ver Saldo");
    Console.WriteLine("2. Deposito");
    Console.WriteLine("3. Sacar");
    Console.WriteLine("4. Sair");
    Console.WriteLine(" Escolha uma opção: ");


    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine($"Saldo Atual: R${saldo}");
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Insira o valor do seu deposito: R$ ");
        double deposito = double.Parse(Console.ReadLine());

        if (deposito > 0)
        {
            saldo += deposito;
            Console.WriteLine($"Deposito de R$ {deposito} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de deposito invalido!");
        }
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Digite o valor para saque: R$ ");
        double saque = double.Parse(Console.ReadLine());

        if (saque > 0 && saque <= saldo)
        {
            saldo -= saque;
            Console.WriteLine($"Saque de R$: {saque} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou saque invalido!");
        }
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Saindo do sistema, muito obrigado");
        break;
    }
    else
    {
        Console.WriteLine("Erro ao sair do sistema, tente novamente mais tarde!");
    }

    Console.WriteLine();
    

}
