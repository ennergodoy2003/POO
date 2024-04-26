using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
  
        using System;

    // Definición de la interfaz
    interface IAnimal
    {
        void EmitirSonido();
    }

    // Clase que implementa la interfaz
    class Perro : IAnimal
    {
        public void EmitirSonido()
        {
            Console.WriteLine("Guau guau!");
        }
    }
}
