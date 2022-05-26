// See https://aka.ms/new-console-template for more information
using System;

internal class NewBaseType
{
  static void Main()
  {
    int N = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < N; i++)
    {
      string[] line = Console.ReadLine().Split(" ");
      double X = double.Parse(line[0]);
      double Y = double.Parse(line[1]);

      if (Y == 0)
      {
        Console.WriteLine("divisao impossivel");
      }
      else
      {
        double divisao = X / Y;

        if (divisao < 0 && (divisao.ToString("N1") == "0.0"))
          Console.WriteLine("-0.0");
        else
          Console.WriteLine(divisao.ToString("N1"));
      }
    }
    Console.ReadLine();
  }
}


