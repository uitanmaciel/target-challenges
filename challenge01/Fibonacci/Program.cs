/*Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos
 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem 
 que desejar onde, informado um número, ele calcule a sequência de Fibonacci e 
 retorne uma mensagem avisando se o número informado pertence ou não a sequência.*/

using static Fibonacci.Fibonacci;

Console.WriteLine("Informe o número para verificar se ele é um número de Fibonacci: ");
var number = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine(IsFibonacci(number)
    ? $"{number} é um número de Fibonacci."
    : $"{number} não é um número de Fibonacci.");