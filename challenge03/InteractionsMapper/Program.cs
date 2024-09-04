/*Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?*/

int indice = 12, soma = 0, k = 1;

while (k < indice)
{    
    k++;
    Console.WriteLine($"Interação {k - 1}: \nK = K({k - 1}) + 1 = {k}\nsoma = {soma} + {k} = {soma + k}\n");
    soma += k;
}

Console.WriteLine($"O valor da variável SOMA é {soma}.");