// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// // Estrutura de Repeticao while
// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 101);
// int contador = 0;
// Console.WriteLine($"Numero Alvo: {numero}");
// // Loop que incrementa o contador ate ele atingir o numero alvo
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o numero alvo: {contador}");
//Estrutura de Repeticao do-while
// int numero = 0;

// do
// {
//     Console.WriteLine($"numero: {numero}");
//     numero++;
// } while (numero < 10);
// Estrutura de repeticao for
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"valor de i: {i}");
// }
// Estrutura de repeticao foreach
// string [] nomes = { "Gabriel", "Priscila", "Paulo" };
// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }

// 1. crie um algoritmo que some todos os numeros pares de 1 a 100 e exiba o resultado no console 
// 2. crie um algoritmo que faca uma contagem regressiva de 10 a 1 e exiba "decolar!" ao final
// 3. crie um algoritmo que conte o numero de vogais (a, e, i, o, u) na palavra e exiba o resultado
// 4. crie um algoritmo que solicite uma palavra ou frase do usuario, verifique se e um palindromo, ou seja, se e igual de tras para frente. exemplo: ana, radar etc...
// 5. crie um algoritmo onde o computador escolhe um numero aleatorio entre 1 e 100, e o usuario deve advinhar. apos cada tentativa, o programa indica se o numero e maior ou manor.


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
//Estrutura de Repeticao do-while
int numero = 11;

do
{
    Console.WriteLine($"numero: {numero}");
    numero++;
} while (numero < 10);