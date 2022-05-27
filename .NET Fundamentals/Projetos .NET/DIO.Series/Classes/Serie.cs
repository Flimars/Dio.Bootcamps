using System;

namespace DIO.Series
{
  public class Serie : BaseEntity
  {
    //Atributos
    private Gender Gender { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }
    private int Year { get; set; }

    //Construtor
    public Serie(int id, Gender gender, string title, string description, int year)
    {
      this.Id = id; // Herdado da Class Abstract EntidadeBasica
      this.Gender = gender;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Exclude = false;
    }

    public override string ToString()
    {
      // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1

      string giveBack = "";
      giveBack += "Gênero: " + this.Gender + Environment.NewLine;

      giveBack += "Título: " + this.Title + Environment.NewLine;

      giveBack += "Descrição: " + this.Description + Environment.NewLine;

      giveBack += "Ano  de Estreia: " + this.Year;

      giveBack += "Excluido: " + this.Exclude;

      return giveBack;
    }

    public string giveBackTitle()
    {
      return this.Title;
    }
    public int giveBackId()
    {
      return this.Id;
    }

    public bool giveBackExclude()
    {
      return this.Exclude;
    }

    public void Exclude()
    {
      this.Exclude = true;
    }



  }
}