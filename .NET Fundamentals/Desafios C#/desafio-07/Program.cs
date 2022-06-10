
/*
Desafio: Compras no Supermercado.
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.

Entrada
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.

Saída
A saída contém N linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética.

_____________________________________________________ 
|Exemplo de Entrada	        |       Exemplo de Saída |
|        2                  | carne laranja picles   |
| carne laranja suco picles |         suco           |
| laranja picles            |      laranja pera      |
| laranja pera laranja pera |                        |
| pera                      |                        |
|___________________________|________________________|

*/

using System;
using System.Collections.Generic;
using System.Linq;

class ComprasNoSupermercado
{
  public static void Main(string[] args)
  {
    int numeroDeTestes = int.Parse(Console.ReadLine());
  
    for (int i = 0; i < numeroDeTestes; i++) {
      List<string> listDeCompras = new List<String>(Console.ReadLine().Split(' '));
      List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();

      listaSemDuplicados.Sort();
  
      foreach (string item in listaSemDuplicados) {
        Console.Write($"{item} ");
      }
      
      Console.WriteLine(" ");
    }
  }
}