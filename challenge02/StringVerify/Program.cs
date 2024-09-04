/*Escreva um programa que verifique, em uma string, a existência da letra ‘a’, 
seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.*/

Console.WriteLine("Digite uma palavra, frase ou texto para verificar a quantidade de ocorrência da letra 'a' ou 'A': ");
string text = Console.ReadLine();

Console.WriteLine($"A letra 'a' ou 'A' aparece {StringVerify.Letter.Count(text)} vezes no texto informado.");
