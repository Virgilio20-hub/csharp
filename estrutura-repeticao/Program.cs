﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Estrutura de Repeticao while
Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Numero Alvo: {numero}");
// Loop que incrementa o contador ate ele atingir o numero alvo
while (contador != numero)
{
    Console.WriteLine($"Contador: {contador}.");
    contador++;
}
Console.WriteLine($"Contador atingiu o numero alvo: {contador}");