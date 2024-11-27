using calculadora.Modelo;
{
    static void Main(string[] args)
    {
        calculadora calc = new calculadora();
        
        // Solicita ao usuário que escolha uma operação
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        int escolha = int.Parse(Console.ReadLine());

        // Solicita ao usuário os dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Variável para armazenar o resultado
        double resultado = 0;

        // Realiza a operação correspondente
        switch (escolha)
        {
            case 1:
                resultado = calculadora.Somar(numero1, numero2);
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;
            case 2:
                resultado = calculadora.Subtrair(numero1, numero2);
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;
            case 3:
                resultado = calculadora.Multiplicar(numero1, numero2);
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;
            case 4:
                resultado = calculadora.Dividir(numero1, numero2);
                if (!double.IsNaN(resultado))
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                break;
            default:
                Console.WriteLine("Operação inválida!");
                break;
        }

        Console.WriteLine("Obrigado por usar a calculadora!");
    }
}
