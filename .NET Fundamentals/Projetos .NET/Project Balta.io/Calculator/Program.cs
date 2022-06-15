// See https://aka.ms/new-console-template for more information
using System;
namespace Calculator
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
      Console.WriteLine("Bem-vindo! Ao Calculator C#2022");
      Console.WriteLine("|======================= ESCOLHA OPERAÇÃO ========================|");
      Console.WriteLine("| 0- Sair | 1- Soma | 2- Subtração | 3- Divisão | 4- Multiplicação|");
      Console.WriteLine("|=================================================================|");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 0:
          Mensagem();
          System.Environment.Exit(0);
          break;

        case 1:
          Soma();
          break;

        case 2:
          Subtracao();
          break;

        case 3:
          Divisao();
          break;

        case 4:
          Multiplicacao();
          break;

        default:
          Menu();
          break;
      }
    }
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;

      /*
       Console.WriteLine($"O resuldado da Soma é {v1 + v2}");    // Interpolação em C#
       Console.WriteLine("O resuldado da Soma é " + resultado);
       Console.WriteLine("O resuldado da Soma é " + (v1 + v2));
       Console.WriteLine("O resuldado da Soma é {0}", resultado); */
      Console.WriteLine($"O resuldado da Soma é {resultado}");  // Interpolação em C#
      Console.ReadKey();
      Menu();
    }
    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;

      /* 
       Console.WriteLine("O resuldado da subtração é " + (v1 - v2));
       Console.WriteLine($"O resuldado da subtração é {v1 - v2}");    // Interpolação em C#
       Console.WriteLine("O resuldado da subtração é " + resultado);
       Console.WriteLine("O resuldado da subtração é {0}", resultado); */
      Console.WriteLine($"O resuldado da subtração é {resultado}");  // Interpolação em C#
      Console.ReadKey();
      Menu();
    }
    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 / v2;

      /* 
      Console.WriteLine("O resuldado da divisão é " + (v1 * v2));
      Console.WriteLine($"O resuldado da divisão é {v1 * v2}");    // Interpolação em C#
      Console.WriteLine("O resuldado da divisão é " + resultado);
      Console.WriteLine("O resuldado da divisão é {0}", resultado); */
      Console.WriteLine($"O resuldado da divisão é {resultado}");  // Interpolação em C#
      Console.ReadKey();
      Menu();
    }
    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;

      /* 
      Console.WriteLine("O resuldado da multiplicação é " + (v1 * v2));
      Console.WriteLine($"O resuldado da multiplicação é {v1 * v2}");    // Interpolação em C#
      Console.WriteLine("O resuldado da multiplicação é " + resultado);
      Console.WriteLine("O resuldado da multiplicação é {0}", resultado); */
      Console.WriteLine($"O resuldado da multiplicação é {resultado}");  // Interpolação em C#
      Console.ReadKey();
      Menu();
    }

    static void Mensagem()
    {
      Console.WriteLine("Obrigado, volte sempre!");
    }
  }
}


// Como funciona JWT - 