namespace LogicalSequence;

public static class Algorithm
{
    /// <summary>
    /// Verifica se o último número da sequência é par ou ímpar.
    /// </summary>
    /// <param name="sequence">Sequencia de números</param>
    /// <returns>Retorna o último número para a sequência.</returns>
    public static int ConsecutiveOdds(int[] sequence)
        => sequence[sequence.Length - 1] % 2 == 0
            ? sequence[sequence.Length - 1] + 1
            : sequence[sequence.Length - 1] + 2;

    /// <summary>
    /// A sequência segue a lógica de números exponenciais: 2, 4, 8, 16, 32, 64...
    /// </summary>
    /// <param name="sequence">Sequencia de entrada</param>
    /// <returns>Retorna o dobro dos números</returns>
    public static int Exponential(int[] sequence)
        => sequence[sequence.Length - 1] * 2;


    /// <summary>
    /// A sequência segue quadrados perfeitos: 0^2, 1^2, 2^2, 3^2, 4^2, 5^2, 6^2...
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    public static int PerfectSquare(int[] sequence)
        => sequence.Length * sequence.Length;

    /// <summary>
    /// A sequência segue quadrados perfeitos de números pares: 2^2, 4^2, 6^2, 8^2...
    /// </summary>
    /// <param name="sequence"></param>
    /// <param name="start"></param>
    /// <returns></returns>
    public static int PerfectSquare(int[] sequence, int start)
    {
        int n = (sequence.Length + start) * start;
        return n * n;
    }
    
    /// <summary>
    /// A sequência segue a sequência de Fibonacci: 1, 1, 2, 3, 5, 8, 13...
    /// </summary>
    /// <param name="sequence">Sequencia de Fibonacci</param>
    /// <returns>Retorna o próximo número da sequência de Fibonacci</returns>
    public static int Fibonacci(int[] sequence)
    {
        int len = sequence.Length;
        return sequence[len - 1] + sequence[len - 2];
    }

    /// <summary>
    /// A sequência é arbitrária.
    /// </summary>
    /// <param name="sequence">Sequencia de entrada.</param>
    /// <returns>Retorna uma sequência arbitrária</returns>
    public static int Arbitrary(int[] sequence)
        => sequence[sequence.Length - 1] + 1;
}