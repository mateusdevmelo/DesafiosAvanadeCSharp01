// Normalmente utilizamos diversas linhas para criar funções e outras estruturas. Porém o C# permite que possamos escrever tudo isso em apenas uma linha de código.

// Devemos utilizar essa forma de escrita para situações mais simples, somente quando facilitar a leitura.



// Criando funções (expressão lambda =>)

// Utilizando a classe Func:

// Func<int, int, int> somar = (a, b) => a + b;

// int resultado = somar(3, 5);


// Utilizando função de instrução única:

// void Multiplicar(int a, int b) => Console.WriteLine(a * b);

// Multiplicar(5, 6);


// Criando condições (if, else)

// IF ternário:

// int numero = 2;

// string resultado = numero >= 5 ? "Maior que 5" : "Menor ou igual a 5";
// Onde o primeiro resultado em string é caso seja true e o segundo caso seja false.



// Podemos utilizar até um if numa única linha:

// int number = 6;

// if(numero > 5) Console.WriteLine("Maior que cinco)";


// Loops

// FOR:

// for (int i = 0; i < 5; Console.WriteLine(i++));


// foreach

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// numeros.ForEach(numero => Console.WriteLine(numero));


// While

// int contador = 0;
// while (contador < 5) Console.WriteLine(contador++);