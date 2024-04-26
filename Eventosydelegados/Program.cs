using System;

public class Alarma
{
    // Declaración de un evento para la alarma
    // Aquí se utiliza un delegado implícito llamado EventHandler
    public event EventHandler Despertar;

    // Método para activar la alarma
    public void Activar()
    {
        Console.WriteLine("¡Despierta! Es hora de comenzar el día.");

        //Despertar es un evento, al invocarlo se invoca el delegado EventHandler
        Despertar?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la alarma
        Alarma alarma = new Alarma();

        // Suscribir un método anónimo al evento de despertar
        alarma.Despertar += (sender, eventArgs) =>
        {
            Console.WriteLine("¡Estás despierto! ¡Es hora de levantarse!");
        };

        // Activar la alarma
        alarma.Activar();

        Console.ReadLine();
    }
}
