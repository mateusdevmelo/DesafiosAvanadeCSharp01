using System;

class Personagem
{
  public string Nome { get; set; }
  public string Raca { get; set; }
  public string Classe { get; set; }
  public int Nivel { get; set; } = 1;
  public int Vida { get; set; } = 10;

  public Personagem(string nome, string raca, string classe)
  {
    Nome = nome;
    Raca = raca;
    Classe = classe;
  }

  public void ExibirStatus()
  {
    Console.WriteLine("Status:");
    Console.WriteLine("Nome:" + Nome);
    Console.WriteLine("Raça:" + Raca);
    Console.WriteLine("Classe:" + Classe);
    Console.WriteLine("Nível:" + Nivel);
    Console.WriteLine("Vida:" + Vida);
  }
}

class Program
{
  static void Main()
  {
    string nome = Console.ReadLine();
    string raca = Console.ReadLine();
    string classe = Console.ReadLine();

    Personagem p1 = new Personagem(nome, raca, classe);
    p1.ExibirStatus();
  }
}

/*
Desafio
No mundo dos RPGs, a criação do personagem é um momento importante e emocionante para os jogadores! Durante esse processo, o jogador deve escolher o nome, a raça, a classe e outras características importantes para o personagem.

Crie uma classe chamada "Personagem" que tenha os seguintes atributos: nome (string), raça (string), classe (string), nível (inteiro), vida (inteiro) e mana (inteiro). A classe deve ter um construtor que recebe como parâmetros o nome, a raça e a classe do personagem. O nível e a vida devem ser iniciados com valores padrão (1 e 10 , respectivamente). Além disso, crie um método chamado "exibir_status" que exibe na tela o nome, a raça, a classe, o nível, a vida e a mana do personagem.

Entrada:
A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

Saída:
A saída deve conter a frase "Status:" seguida das informações do método "exibir_status", ou seja, deve exibir na tela o nome, a raça, a classe, o nível e a vida do personagem. Conforme exemplos abaixo.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
bjorn
anão
guerreiro

Status:
Nome:bjorn
Raça:anão
Classe:guerreiro
Nível:1
Vida:10
veniCaçador
elfo
mago

Status:
Nome:veniCaçador
Raça:elfo
Classe:mago
Nível:1
Vida:10
sorth
goblin
paladino

Status:
Nome:sorth
Raça:goblin
Classe:paladino
Nível:1
Vida:10
*/