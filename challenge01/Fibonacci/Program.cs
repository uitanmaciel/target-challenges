using static Fibonacci.Fibonacci;

Console.WriteLine("Informe o número para verificar se ele é um número de Fibonacci: ");
var number = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine(IsFibonacci(number)
    ? $"{number} é um número de Fibonacci."
    : $"{number} não é um número de Fibonacci.");