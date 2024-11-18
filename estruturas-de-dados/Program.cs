// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Estruturas de dados
// Exemplo 01: Vetor (Array)
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 20;
// meuArray[3] = 30;
// meuArray[4] = 40;
// Console.WriteLine("Numeros no array:");
// for (int i = 0; contador < meuArray.Length; contador++)
// {
//     Console.WriteLine(meuArray[contador]);
// }

// // Lista de nomes
// list<string> listaDeNomes = new List<string> {"Wanderson", "Jeane", "Ryan",};
// listaDeNomes.Add("Maria");

// Console.WriteLine("Nomes na lista:");
// for (int i = 0; i < listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }
    
// Console.WriteLine("\nVerificacao de existencia do nome Ryan:")
// string nomeParaVerificar - "Ryan";
// if(listaDeNomes.Contains(nomeParaVerificar))
// {
//     Console.WriteLine($"{nomeParaVerificar} esta na lista>.");
// }
// else
// {
//     Console.WriteLine($"{nomeParaVerificar} nao esta na lista>.");
// }

// Console.WriteLine("\nApos remover Wanderson");
// string nomeParaRemover = "Wanderson";
// bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
// {
// Console.WriteLine($"{nomeParaRemover} foi removido da lista.")
// }
// else
// {
//     Console.WriteLine($"{nomeParaRemover} nao foi removido da lista.")
// }

// elementos repetidos no conjunto
// HashSet<int> conjunto = new HashSet<int> { 1, 2, 3 };
// conjunto.Add(4);
// conjunto.Add(2);

// Console.WriteLine("Elementos do Conjunto:");
// foreach (int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }

// ashSet<string> frutas = new HashSet<string> { "Maca", "Abacaxi", "Laranja" };
// frutas.Add("Uva");
// frutas.Add("Maca");

// Console.WriteLine("Frutas no Conjunto:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }H

// Console.WriteLine("\nVerificacao de existencia:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana esta no conjunto" : "Banana nao esta no conjunto");

// // add remove
// frutas.Remove("Laranja");
// Console.WriteLine("\nApos remover Laranja:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

// exercicios
// 1. dado um array de inteiros int[] numeros = { 1, 2, 3, 4, 5 };, escreva um codigo que some todos os elementos do array e exiba o resultado no console.
// 2. dada uma lista de strings List<string> nomes = new List<string> {"Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };, escreva um codigo para contar quantas vezes o nome "Jeane" aparece na lista.
// 3. dada uma lista de inteiros com elementos duplicados List<int> numeros = new List<int> {1, 2, 2, 3, 4, 4, 5 };, escreva um codigo para remover os elementos duplicados e exibir a lista sem duplicatas.
// 4. dado um conjunto HashSet<string> frutas = new HashSet<string> {"Maca", "Banana", "Laranja" };, escreva um codigo que verifique se "Banana" esta no conjunto e exiba uma mensagem no console.
// 5. Crie uma lista vazia de numeros inteiros List<int> numeros = new List<int>();. em seguida, adicione os numeros de 1 a 5 na lista e exiba os elementos no console.

// class Program
// {
//     static void Main()
//     {
//         // Array de inteiros
//         int[] numeros = { 1, 2, 3, 4, 5 };
        
//         // Variável para armazenar a soma
//         int soma = 0;
        
//         // Loop para somar todos os elementos
//         foreach (int numero in numeros)
//         {
//             soma += numero;
//         }
        
//         // Exibe o resultado
//         Console.WriteLine("A soma dos elementos é: " + soma);
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Lista de nomes
//         List<string> nomes = new List<string> { "Jeane", "Wanderson", "Jeane", "Ryan", "Jeane" };
        
//         // Conta quantas vezes "Jeane" aparece na lista
//         int count = nomes.Count(nome => nome == "Jeane");
        
//         // Exibe o resultado
//         Console.WriteLine($"O nome 'Jeane' aparece {count} vezes na lista.");
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Lista com elementos duplicados
//         List<int> numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

//         // Removendo os duplicados usando Distinct() e convertendo novamente para lista
//         List<int> numerosSemDuplicatas = numeros.Distinct().ToList();

//         // Exibindo a lista sem duplicatas
//         Console.WriteLine("Lista sem duplicatas:");
//         foreach (int numero in numerosSemDuplicatas)
//         {
//             Console.WriteLine(numero);
//         }
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Criação do HashSet de frutas
//         HashSet<string> frutas = new HashSet<string> { "Maca", "Banana", "Laranja" };

//         // Verificando se "Banana" está no conjunto
//         if (frutas.Contains("Banana"))
//         {
//             Console.WriteLine("A fruta Banana está no conjunto!");
//         }
//         else
//         {
//             Console.WriteLine("A fruta Banana NÃO está no conjunto.");
//         }
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Criação de uma lista vazia de inteiros
//         List<int> numeros = new List<int>();

//         // Adicionando os números de 1 a 5 à lista
//         for (int i = 1; i <= 5; i++)
//         {
//             numeros.Add(i);
//         }

//         // Exibindo os elementos da lista no console
//         Console.WriteLine("Elementos da lista:");
//         foreach (int numero in numeros)
//         {
//             Console.WriteLine(numero);
//         }
//     }
// }
