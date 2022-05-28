// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace Bank.Classes
{
  class Program
  {
    static List<Account> listAccounts = new List<Account>();
    static void Main(string[] args)
    {
      string userOption = captureUserOption();

      while (userOption.ToUpper() != "X")

      {
        switch (userOption)
        {
          case "1":
            ListAccounts();
            break;

          case "2":
            insertAccount();
            break;

          case "3":
            transfer();
            break;

          case "4":
            withDrawMoney();
            break;

          case "5":
            depositMoney();
            break;

          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        userOption = captureUserOption();
      }

      Console.WriteLine("Obrigado por utilizar nossos serviços.");
      Console.ReadLine();
    }


    private static void depositMoney()
    {
      Console.Write("Digite o número da conta:");
      int indexAccount = int.Parse(Console.ReadLine());

      Console.Write("Digite o valor do Deposito:");
      double valueDeposit = double.Parse(Console.ReadLine());

      listAccounts[indexAccount].Deposit(valueDeposit);
    }

    private static void withDrawMoney()
    {
      Console.Write("Digite o número da conta:");
      int indexAccount = int.Parse(Console.ReadLine());

      Console.Write("Digite o valor do saque:");
      double valueCashOut = double.Parse(Console.ReadLine());

      listAccounts[indexAccount].CashOut(valueCashOut);
    }

    private static void transfer()
    {
      Console.Write("Digite o número da conta de origem:");
      int indexAccountOrigin = int.Parse(Console.ReadLine());

      Console.Write("Digite o número da conta de destino:");
      int indexAccountDestiny = int.Parse(Console.ReadLine());

      Console.Write("Digite o valor a ser transferido:");
      double valueTranferDestiny = double.Parse(Console.ReadLine());

      listAccounts[indexAccountOrigin].Transfer(valueTranferDestiny, listAccounts[indexAccountDestiny]);
    }

    private static void ListAccounts()
    {
      Console.WriteLine("Listar Contas");

      if (listAccounts.Count == 0)
      {
        Console.WriteLine("Não Há Conta Cadastrada.");
        return;
      }

      for (int i = 0; i < listAccounts.Count; i++)
      {
        Account account = listAccounts[i];
        Console.Write("#{0} - ", i);
        Console.WriteLine(account);
      }
    }

    private static void insertAccount()
    {
      Console.WriteLine("Inserir nova conta");

      Console.WriteLine("Digite 0 para Conta Poupança | Digite 1 para Conta Física | Digite 2 para Conta Jurídica:");
      AccountType accountTypeEntry = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine());

      Console.WriteLine("Digite o Nome do Cliente:");
      string nameEntry = Console.ReadLine();

      Console.WriteLine("Digite o Saldo Inicial:");
      double balanceEntry = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite o Crédito:");
      double creditEntry = double.Parse(Console.ReadLine());

      var createNewAccount = new Account(name: nameEntry,
        credit: creditEntry,
        balance: balanceEntry,
        accountType: accountTypeEntry);

      listAccounts.Add(createNewAccount);
    }

    private static string captureUserOption()
    {
      Console.WriteLine();
      Console.WriteLine("Solidary Bank a seu dispor!");
      Console.WriteLine("Informe a Opção desejada:");

      Console.WriteLine("1 - Listar Contas");
      Console.WriteLine("2 - Inserir na Conta");
      Console.WriteLine("3 - Transferir");
      Console.WriteLine("4 - Sacar");
      Console.WriteLine("5 - Depositar");
      Console.WriteLine("C - Limpar a Tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string userOption = Console.ReadLine().ToUpper();
      Console.WriteLine();

      return userOption;
    }
  }
}


