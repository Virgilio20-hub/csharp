// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Estrutura condicional simples
double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"Media {media:F2}: Aprovado");
}
else{
    Console.WriteLine($"Media {media:F2}: Recuperacao");
}

double nota4 = 8;
double nota5 = 8.0;
double nota6 = 5.0;
double mediaNota = (nota4 + nota5 + nota6) / 3;
if (mediaNota >= 7)
{
    Console.WriteLine($"Media {mediaNota:F2}: Aprovado");
}
else if (mediaNota >= 5 && mediaNota < 7)
{
    Console.WriteLine($"Media {mediaNota:F2}: Recuperacao");
}
else
{
    Console.WriteLine($"Media {mediaNota:F2}: Reprovado");
}

Console.WriteLine("Digite uma vogal");
string? letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if (letra == "e" || letra == "E")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if (letra == "i" || letra == "I")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if (letra == "o" || letra == "O")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}
else if (letra == "u" || letra == "U")
{
    Console.WriteLine($"Voce digitou a vogal: {letra}");
}