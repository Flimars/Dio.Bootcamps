
/* 
Desafio
Em um episódio da aclamada série The Big Ban Theor dois pernagens, Sheldon e Raj, discutem qual dos dois é o melhor: o filme Saturn 3 ou a série Deep Space 9. A sugestão de Raj para a resolução do impasse é uma disputa de Pedra-Papel-Tesoura. Contudo, Sheldon argumenta que, se as partes envolvidas se conhecem, entre 75% e 80% das disputas de Pedra-Papel-Tesoura terminam empatadas, e então sugere o Pedra-Papel-Tesoura-Lagarto-Spock.

As regras do jogo proposto são:

a tesoura corta o papel;
o papel embrulha a pedra;
a pedra esmaga o lagarto;
o lagarto envenena Spock;
Spock destrói a tesoura;
a tesoura decapita o lagarto;
o lagarto come o papel;
o papel contesta Spock;
Spock vaporiza a pedra;
a pedra quebra a tesoura.
Conhecendo os personagens, sabemos que caso Sheldon vencesse, ele gritaria a vitória com um "Bazinga!". Se Raj vencesse, Sheldon o acusaria de ter trapaceado. Agora, se desse empate, Sheldon não descansaria e insistira para jogarem de novo até que seja decidido. Sabendo dessas ações, faça um programa que imprima a provável reação de Sheldon.

Entrada
A entrada consiste em uma série de casos de teste. A primeira linha contém um inteiro positivo T (T ≤ 100), que representa o número de casos de teste. Cada caso de teste é representado por uma linha da entrada, contendo as escolhas de Sheldon e Raj, respectivamente, separadas por um espaço em branco. As escolhas possíveis são as personagens do jogo: pedra, papel, tesoura, lagarto e Spock.

Saida
Para cada caso de teste deverá ser impressa a mensagem "Caso #t: R", onde t é o número do caso de teste (cuja contagem se inicia no número um) e R é uma das três reações possíveis de Sheldon: "Bazinga!", "Raj trapaceou!", ou "De novo!".

 
Exemplos de Entrada  |  	Exemplos de Saída
       3             |    
   papel pedra       |     Caso #1: Bazinga! 
   lagarto tesoura   |    Caso #2: Raj trapaceou! 
   Spock Spock       |    Caso #3: De novo!

 */



using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= ; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if((      ) || (    ) //complete a solução
                    || (     ) || (     )
                    || (    ) || (    )
                    || (     ) || (    )
                    || (     ) || (   ))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if (    )   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

    }

}