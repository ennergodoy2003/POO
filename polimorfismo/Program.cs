using System;

// Clase Calculadora con métodos sobrecargados
class Calculadora
{
    // Método que suma dos números enteros
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método que suma dos números decimales
    public double Sumar(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Calculadora
        Calculadora calc = new Calculadora();

        // Llamar a los métodos Sumar de forma polimórfica
        Console.WriteLine(calc.Sumar(5, 3));      // Imprime 8 (usando int)
        Console.WriteLine(calc.Sumar(4.5, 2.5));  // Imprime 7.0 (usando double)
    }
}
