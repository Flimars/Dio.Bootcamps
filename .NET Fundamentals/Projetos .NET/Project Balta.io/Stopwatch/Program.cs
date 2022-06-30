using System;
using System.Threading;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      System.Console.WriteLine("S = Segundo -> 10s = 10 segundos");
      System.Console.WriteLine("M = Minuto -> 1m = 1 minuto");
      System.Console.WriteLine("X = Sair");
      System.Console.WriteLine("Informe quanto tempo quer contar:");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1)); // pega o ultimo caracter da string
      int time = int.Parse(data.Substring(0, data.Length - 1));   // pega do 1º ao penultimo caracter da string
      int multiplier = 1;

      if (type == 'm')
      {
        multiplier = 60;
      }

      if (time == 0)
      {
        System.Environment.Exit(0);
      }
      Start(time * multiplier);
           
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }
      Console.Clear();
      System.Console.WriteLine("Stopwatch Finished!");
      Thread.Sleep(2500);
      Menu();
    }
  }
}
