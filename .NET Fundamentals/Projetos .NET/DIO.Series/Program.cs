using System;

namespace DIO.Series
{
  class Program
  {
    static SerieReposity reposity = new SerieReposity();
    static void Main(string[] args)
    {
      string userOption = captureUserOptions();

      while (userOption.ToUpper() != "X")
      {
        switch (userOption)
        {
          case "1":
            ListSeries();
            break;

          case "2":
            InsertSerie();
            break;

          case "3":
            UpdateSerie();
            break;

          case "4":
            ExcludeSerie();
            break;

          case "5":
            ToViewSerie();
            break;

          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }

        userOption = captureUserOptions();
      }

      /* private */
      static void ListSeries()
      {
        Console.WriteLine("Listar séries");

        var list = reposity.List();

        if (list.Count == 0)
        {
          Console.WriteLine("Nenhuma série cadastrada.");
          return;
        }

        foreach (var serie in list)
        {
          var exclude = serie.giveBackExclude();

          Console.WriteLine("#ID {0}: - {1} {2}", serie.giveBackId(), serie.giveBackTitle(), (exclude ? "*Excluído*" : ""));
        }
      }

      /* private */
      static void InsertSerie()
      {
        Console.WriteLine("Inserir nova série");

        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1

        foreach (int i in Enum.GetValues(typeof(Gender)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
        }
        Console.WriteLine("Digite o gênero entre as opções acima: ");
        int inputGenred = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o título da série: ");
        string inputTitle = Console.ReadLine();

        Console.WriteLine("Digite o ano de exibição da série: ");
        int inputYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a descrição da série: ");
        string inputDescription = Console.ReadLine();

        Serie otherSerie = new Serie(id:
        reposity.NextId(),
                gender: (Gender)inputGenred,
                title: inputTitle,
                year: inputYear,
                description: inputDescription);

        reposity.Insert(otherSerie);
      }

      /* private */
      static void UpdateSerie()
      {
        Console.WriteLine("Digite o código da série: ");
        int indexSerie = int.Parse(Console.ReadLine());
        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
        // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
        foreach (int i in Enum.GetValues(typeof(Gender)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
        }
        Console.WriteLine("Digite o gênero entre as opções acima: ");
        int inputGenred = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o título da série: ");
        string inputTitle = Console.ReadLine();

        Console.WriteLine("Digite o ano de exibição da série: ");
        int inputYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a descrição da série: ");
        string inputDescription = Console.ReadLine();

        Serie updateSerie = new Serie(id: indexSerie,
                    gender: (Gender)inputGenred,
                    title: inputTitle,
                    year: inputYear,
                    description: inputDescription);

        reposity.Update(indexSerie, updateSerie);
      }

      /* private */
      static void ToViewSerie()
      {
        Console.WriteLine("Digite o código da série");
        int indexSerie = int.Parse(Console.ReadLine());

        var serie = reposity.GiveBackById(indexSerie);

        Console.WriteLine(serie);
      }

      /* private */
      static void ExcludeSerie()
      {
        Console.WriteLine("Digite o código da série");
        int indexSerie = int.Parse(Console.ReadLine());

        reposity.Exclude(indexSerie);
      }

      /* private */
      static string captureUserOptions()
      {
        Console.WriteLine();
        Console.WriteLine(" Thines Séries - Assista onde quiser.");
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1- Listar séries");
        Console.WriteLine("2- Inserir nova série");
        Console.WriteLine("3- Atualizar série");
        Console.WriteLine("4- Excluir série");
        Console.WriteLine("5- Visualizar série");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string userOption = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return userOption;
      }

    }
  }
}