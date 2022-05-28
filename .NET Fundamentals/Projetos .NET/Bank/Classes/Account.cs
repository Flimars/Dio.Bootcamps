using System;

namespace Bank.Classes
{
  public class Account
  {
    private string Name { get; set; }
    private double Credit { get; set; }
    private double Balance { get; set; }
    private AccountType Type { get; set; }

    public Account(string name, double credit, double balance, AccountType accountType)
    {
      this.Name = name;
      this.Credit = credit;
      this.Balance = balance;
      this.Type = accountType;
    }

    public bool CashOut(double cashOutValue)
    {
      // Validação do saldo suficiente
      if (this.Balance - cashOutValue < (this.Credit * -1))
      {
        Console.WriteLine("Saldo Insuficiente!");
        return false;
      }

      this.Balance -= cashOutValue;

      //https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting  
      Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Name, this.Balance);
      return true;
    }

    public void Deposit(double depositAmount)
    {
      this.Balance += depositAmount;

      Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Name, this.Balance);
    }

    public void Transfer(double transferValue, Account accountDestination)
    {
      // Reuso de código - Métodos CashOut() e Deposit()
      if (this.CashOut(transferValue))
      {
        accountDestination.Deposit(transferValue);
      }
    }

    public override string ToString()
    {
      string giveBack = "";
      giveBack += "TipoConta " + this.Type + " | ";
      giveBack += "Nome " + this.Name + " | ";
      giveBack += "Saldo " + this.Balance + " | ";
      giveBack += "Crédito " + this.Credit + " | ";
      return giveBack;
    }
  }
}