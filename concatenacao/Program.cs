// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Concatenacao
string nome = "gabriel";
string saudacao = "ola, " + nome + "! bem-vindo.";
Console.WriteLine(saudacao);

// Interpolacao de strings
string nome1 = "gabriel";
string saudacao1 = $"ola, {nome1}! bem-vindo.";
Console.WriteLine(saudacao1);

// Operador GetType()
int numero = 5;
Console.WriteLine(numero.GetType());

// Palavra-chave typeof
Console.WriteLine(typeof(int));

// Metodo Parse
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:" + valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variavel numeroParse e do tipo:" +numero1.GetType());

// Metodo Convert
string valorEmTexto = "100";
Console.WriteLine("Valor da variavel String: " + valorEmTexto);
Console.WriteLine("A variavel valorTexto e do tipo:" + valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("Apos concersao a variavel numeroConvertido e do tipo: " + numeroConvertido.GetType());

// Metodo ToString
int numero = 123;
Console.WriteLine(numero.GetType());

string numeroComoString = numero.ToString();
Console.WriteLine(numeroComoString.GetType());