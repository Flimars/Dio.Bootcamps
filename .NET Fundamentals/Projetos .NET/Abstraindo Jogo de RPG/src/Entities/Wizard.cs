namespace Abstraindo_Jogo_de_RPG.src.entities
{
  public class Wizard : Hero  // Herdando da classe Hero.
  {
    public Wizard(){}
    public Wizard(string Name, int Level, string HeroType){
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " Lançou Magia!";
    }
  }
}