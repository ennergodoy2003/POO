using System;
using interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Perro
        Perro miPerro = new Perro();

        // Llamar al método definido en la interfaz
        miPerro.EmitirSonido();
    }
}