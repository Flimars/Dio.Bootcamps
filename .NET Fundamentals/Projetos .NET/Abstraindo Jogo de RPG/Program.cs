
using Abstraindo_Jogo_de_RPG.src.entities;

class Program
{
  static void Main(string[] args)
  {
    Hero arus = new Hero("Arus", 23, "Knight");
    Wizard jennika = new Wizard("Jennika", 23, "Write Wizard");
    Console.WriteLine(arus.Attack());
    Console.WriteLine(jennika.Attack());
  }

}
