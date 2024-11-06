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
int numero2 = 123;
Console.WriteLine(numero2.GetType());

string numero2ComoString = numero2.ToString();
Console.WriteLine(numero2ComoString.GetType());

// Personalizacao de Formatacao para data e hora
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataHoraFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm");
Console.WriteLine(dataHoraFormatada);
