using System;

namespace POO
{ 
class Program
    {
    static void Main(string[] args)
    {
        // Crear una instancia de Camioneta
        Camioneta camioneta = new Camioneta();
        Console.WriteLine($"Camioneta - Color: {camioneta.Color}, Marca: {camioneta.Marca}");
        camioneta.Acelerar();
        camioneta.Frenar();

        // Crear una instancia de PicUp
        PikUp pikUp = new PikUp();
        Console.WriteLine($"PicUp - Color: {pikUp.Color}, Marca: {pikUp.Marca}");
        pikUp.Acelerar();
        pikUp.Frenar();
    }
    }
}
