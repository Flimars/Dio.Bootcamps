namespace Abstraindo_Jogo_de_RPG.src.entities
{
  public class Hero
  {
    public string Name;
    public int Level;
    public string HeroType;
    public Hero(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public Hero() {}

    public override string ToString()
    {
      return this.Name + " " + this.Level + " " + this.HeroType;
    }
    public virtual string Attack()
    {
      return this.Name + " Empunhou a espada, efetuado ataque!";
    }
  }
}