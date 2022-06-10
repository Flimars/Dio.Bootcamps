namespace Abstraindo_Jogo_de_RPG.src.entities
{
  public class Ninja : Hero
  {
    public Ninja(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }

    public Ninja()
    {

    }
    public override string Attack()  // Sobrescrevendo o Método Attack()
    {
      return this.Name + " Deferiu Golpe!";
    }
    public string Attack(int Bonus)  // Sobrescrevendo o Método Attack()
    {
      if (Bonus > 6)
      {
        return this.Name + " Deferiu SUPER golpe! Força efetiva com bonus de " + Bonus;
      }
      else
      {
        return this.Name + "Deferiu golpe fraco. Força com bonus de " + Bonus;
      }
    }
  }
}