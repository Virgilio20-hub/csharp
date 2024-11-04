// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Operadores Aritmeticos
double resultado1 = 12 + 8 + 12 / 3;
Console.WriteLine(resultado1);

double resultado2 = (12 + 8 + 12) / 3;
Console.WriteLine(resultado2);

double resultado3 = (2 + 8) * 2 / 4;
Console.WriteLine(resultado3);

// And Logico
bool a = true;
bool b = false;
Console.WriteLine(a && b);

// OR Logico
bool c = true;
bool d = false;
Console.WriteLine(c || d);

// NOT Logico
bool e = true;
Console.WriteLine( !e );

// XOR Logico
bool f = true;
bool g = false;
Console.WriteLine(f^g);

// Exemplo de Precedencia
bool h = true;
bool i = false;
bool j = false;
bool resultado4 = !h || (i && j);
Console.WriteLine(resultado4);

// Exemplo de Precedencia 2
bool k = false;
bool l = false;
bool m = false;
bool resultado5 = !k || l && m;
Console.WriteLine(resultado5);
