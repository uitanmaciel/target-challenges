/*Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____*/

using LogicalSequence;

// Essa lógica é uma sequência de números ímpares.
Console.WriteLine("a) 1, 3, 5, 7, ___");
Console.WriteLine("O próximo número é: " + Algorithm.ConsecutiveOdds(new int[] { 1, 3, 5, 7 }));
Console.WriteLine();

// Essa lógica é uma sequência onde cada número é o dobro do anterior.
Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____");
Console.WriteLine("O próximo número é: " + Algorithm.Exponential(new int[] { 2, 4, 8, 16, 32, 64 }));
Console.WriteLine();

// Essa lógica é uma sequência dos quadrados perfeitos.
Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____");
Console.WriteLine("O próximo número é: " + Algorithm.PerfectSquare(new int[] { 0, 1, 4, 9, 16, 25, 36 }));
Console.WriteLine();

// Essa lógica é uma sequência dos quadrados perfeitos de números pares.
Console.WriteLine("d) 4, 16, 36, 64, ____");
Console.WriteLine("O próximo número é: " + Algorithm.PerfectSquare(new int[] { 4, 16, 36 }, 2));
Console.WriteLine();

// Essa lógica é uma sequência de Fibonacci.
Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____");
Console.WriteLine("O próximo número é: " + Algorithm.Fibonacci(new int[] { 1, 1, 2, 3, 5, 8 }));
Console.WriteLine();

// Essa lógica é uma sequência arbitrária.
Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ____");
Console.WriteLine("O próximo número é: " + Algorithm.Arbitrary(new int[] { 2, 10, 12, 16, 17, 18, 19 }));