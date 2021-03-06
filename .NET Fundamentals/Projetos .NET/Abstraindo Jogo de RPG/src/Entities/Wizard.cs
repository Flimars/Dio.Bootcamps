namespace Abstraindo_Jogo_de_RPG.src.entities
{
  public class Wizard : Hero  // Herdando da classe Hero.
  {
    public Wizard() { }
    public Wizard(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()  // Sobrescrevendo o Método Attack()
    {
      return this.Name + " Lançou Magia!";
    }
    public string Attack(int Bonus)  // Sobrescrevendo o Método Attack()
    {
      if (Bonus > 6)
      {
        return this.Name + " Lançou Magia SUPER efetiva com bonus de " + Bonus;
      }
      else
      {
        return this.Name + " Lançou Magia fraca com bonus de " + Bonus;
      }
    }
  }
}