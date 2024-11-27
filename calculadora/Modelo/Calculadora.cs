using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Modelo    
public class calculadora

{
    // Método para somar
    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Método para subtrair
    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    // Método para multiplicar
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método para dividir
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return double.NaN; // Retorna NaN para representar um erro
        }
        return a / b;
    }
}
