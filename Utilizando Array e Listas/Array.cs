using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
        string[] nomesJogos = new string[quantidadeJogos];   

        // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
        for (int i = 0; i < quantidadeJogos; i++) 
        {
          AdicionarJogo(i, nomesJogos);
        }

        //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
       

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string texto = $"Foi adicionado '{quantidadeJogos}' jogos: ";
        
        for(int i = 0; i < nomes.Length; i++)
        {
          texto += $"{nomes[i]}, ";
        }
        
        texto += " ao catalogo.";
        int lastIndex = texto.LastIndexOf(",");
        string part1 = texto.Substring(0, lastIndex);
        
        lastIndex++;
        string part2 = texto.Substring(lastIndex, texto.Length - lastIndex);
        
        string message = part1 + part2;
        Console.Write(message);
    }
}

/*
Descrição
Neste desafio, o objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos. Inicie solicitando a quantidade desejada e, em seguida, peça o nome de cada jogo individualmente, armazenando-os em um array chamado nomesJogos. Utilize um loop `for` para facilitar a adição dos jogos. Após a conclusão, exiba um resumo em uma única linha, indicando a quantidade total de jogos adicionados e a lista de nomes no catálogo.

Entrada
O programa inicia solicitando ao usuário que insira a quantidade de jogos que deseja adicionar ao catálogo. Em seguida, para cada jogo, o usuário é solicitado a inserir o nome do jogo.

Saída
Ao final da adição dos jogos, o programa exibe um resumo que inclui a quantidade total de jogos adicionados e uma lista com os nomes dos jogos separados por vírgulas. Este resumo fornece uma visão geral dos jogos que foram incluídos no catálogo.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
2
SimCity
Prince of Persia	Foi adicionado '2' jogos: SimCity, Prince of Persia ao catalogo.
3
Tetris
Doom
Pong	Foi adicionado '3' jogos: Tetris, Doom, Pong ao catalogo.
2
Portal
Limbo	Foi adicionado '2' jogos: Portal, Limbo ao catalogo.
*/