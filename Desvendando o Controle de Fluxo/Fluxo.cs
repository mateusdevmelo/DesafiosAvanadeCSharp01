using System;

class Program
{
    static void Main()
    {
    // Solicita ao usuário os limites inferiores e superiores
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
    for(int i = limiteInferior; i <= limiteSuperior; i++)
    {
    
    // TODO: Implemente o if para verificar se o número é par:
      if (i % 2 == 0) 
      {
        somaPares += i;
      }
    }
    // TODO: Crie o acumulador para a soma dos números pares:
           

    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}

/*
Descrição
Para este desafio, vamos aplicar outros conceitos fundamentais de programação, agora, criaremos um programa que calcule a soma dos números pares em um intervalo específico. Dessa forma, desenvolva uma solução clara, simples e organizada, você pode criar variáveis com nomes representativos, como limiteInferior, limiteSuperior e somaPares. Utilize uma estrutura de controle de fluxo, como o `for` para percorrer todos os números no intervalo definido pelos `limiteInferior e o limiteSuperior`. Dentro desse loop, crie uma estrutura condicional `if ` para verificar se cada número é par e se o resto da divisão por 2 é igual a zero (i % 2 == 0). Se a condição for verdadeira, o número é somado à variável somaPares.

Entrada
Será as informações de limiteInferior e limiteSuperior, sendo eles dois números inteiros(int).

Saída
A saída deverá informar uma String com o resultado final: $"A soma dos números pares de {limiteInferior} a {limiteSuperior} e: {somaPares}".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
30
60	A soma dos numeros pares de 30 a 60 e: 720
1
32	A soma dos numeros pares de 1 a 32 e: 272
10
20	A soma dos numeros pares de 10 a 20 e: 90
*/