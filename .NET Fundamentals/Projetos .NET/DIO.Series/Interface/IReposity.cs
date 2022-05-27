using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
  public interface IReposity<T>
  {
    List<T> List();

    T GiveBackById(int id);

    void Insert(T entity);

    void Exclude(int id);

    void Update(int id, T entity);

    int Next();
  }
}