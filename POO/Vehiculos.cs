using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Herencia Encapsulamiento, abstraccion y propiedades
namespace POO
{
    internal class Vehiculos

    {
        // Propiedades comunes
        public string Color { get; set; }
        public string Marca { get; set; }

        // Método para acelerar
        public virtual void Acelerar()
        {
            Console.WriteLine("El vehículo está acelerando.");
        }

        // Método para frenar
        public virtual void Frenar()
        {
            Console.WriteLine("El vehículo está frenando.");
        }
    }

    // Clase camioneta 
    class Camioneta : Vehiculos
    {
        // Constructor
        public Camioneta()
        {
            Color = "Corinto";
            Marca = "Honda";
        }
    }

    // Clase PikUp 
    class PikUp : Vehiculos
    {
        // Constructor
        public PikUp()
        {
            Color = "Verde";
            Marca = "Toyota";
        }
    }
}
  
    