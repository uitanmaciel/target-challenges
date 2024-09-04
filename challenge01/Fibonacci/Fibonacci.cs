namespace Fibonacci;

public class Fibonacci
{
    /// <summary>
    /// Verifica se um número é um número de Fibonacci.
    /// </summary>
    /// <param name="number">Número informado pelo usuário.</param>
    /// <returns>Retorna true ou false para o número informado.</returns>
    public static bool IsFibonacci(int number)
    {
        // Se o número for 0 ou 1, ele é um número de Fibonacci.
        if (number == 0 || number == 1)
            return true;

        int previous = 0;
        int current = 1;

        while (current < number)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }

        // Se o número informado for igual ao número atual, ele é um número de Fibonacci.
        return current == number;
    }
}