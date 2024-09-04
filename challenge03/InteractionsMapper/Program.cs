/*Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?*/

int index = 12, sum = 0, k = 1;

while (k < index)
{    
    k++;
    Console.WriteLine($"Interação {k - 1}: \nK = K({k - 1}) + 1 = {k}\nsoma = {sum} + {k} = {sum + k}\n");
    sum += k;
}

Console.WriteLine($"O valor da variável SOMA é {sum}.");