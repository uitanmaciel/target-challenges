namespace StringVerify;

public class Letter
{
    /// <summary>
    /// Conta quantas vezes uma letra 'a' ou 'A' aparece em um texto.
    /// </summary>
    /// <param name="text">Texto fonte para a pesquisa do caracter.</param>    
    /// <returns>Retorna a quantidade de ocorrência do caractere no texto.</returns>
    public static int Count(string text)
    {
        int count = 0;
        foreach (char c in text.ToLower())
        {
            if (c == 'a')
                count++;
        }
        return count;
    }
}