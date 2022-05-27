using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  public class SerieReposity : IReposity<Serie>
  {
    private List<Serie> listSerie = new List<Serie>();

    public void Exclude(int id)
    {
      listSerie[id].Exclude();
    }

    public Serie GiveBackById(int id)
    {
      return listSerie[id];
    }

    public void Insert(Serie entity)
    {
      listSerie.Add(entity);
    }

    public List<Serie> List()
    {
      return listSerie;
    }

    public int Next()
    {
      return listSerie.Count;
    }

    public void Update(int id, Serie entity)
    {
      listSerie[id] = entity;
    }
  }
}