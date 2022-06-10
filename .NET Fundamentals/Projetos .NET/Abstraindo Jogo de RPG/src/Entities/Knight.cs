namespace Abstraindo_Jogo_de_RPG.src.entities
{
    public class Knight : Hero  // Herdando da classe Hero.
    {
       public Knight(string Name, int Level, string HeroType)
       {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
       } 
    }
}