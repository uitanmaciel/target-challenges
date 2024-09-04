Console.WriteLine("Informe o número para verificar se ele é um número de Fibonacci: ");
int number = int.Parse(Console.ReadLine());

if (Fibonacci.Fibonacci.IsFibonacci(number))
    Console.WriteLine($"{number} é um número de Fibonacci.");
else
    Console.WriteLine($"{number} não é um número de Fibonacci.");