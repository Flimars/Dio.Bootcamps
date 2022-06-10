
using Abstraindo_Jogo_de_RPG.src.entities;

class Program
{
  static void Main(string[] args)
  {
    Knight arus = new Knight("Arus", 28, "Knight");
    Ninja wedge = new Ninja("Wedge", 32, "Knight");
    Wizard jennika = new Wizard("Jennika", 42, "Write Wizard");
    Wizard topapa = new Wizard("Topapa", 42, "Black Wizard");

    Console.WriteLine(arus.Attack());
    Console.WriteLine(wedge.Attack(8));
    Console.WriteLine(jennika.Attack(7));
    Console.WriteLine(topapa.Attack(7));

  }

}
