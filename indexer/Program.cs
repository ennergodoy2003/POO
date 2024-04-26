using System; 

class Libro // Definición de la clase Libro
{
    private string[] paginas = new string[100]; // Declaración de un arreglo de strings para almacenar el contenido de las páginas del libro

    // Indexador
    public string this[int numeroPagina] // Indexador que permite acceder a las páginas del libro por su número
    {
        get
        {
            // Devuelve el contenido de la página solicitada
            return paginas[numeroPagina];
        }
        set
        {
            // Establece el contenido de la página especificada
            paginas[numeroPagina] = value;
        }
    }
}

class Program 
{
    static void Main(string[] args) // Método principal de la aplicación
    {
        Libro miLibro = new Libro(); // Creación de una instancia de la clase Libro

        // Asignación de contenido a las páginas del libro utilizando el indexador
        miLibro[0] = "Introducción";
        miLibro[1] = "Capítulo 1: Historia del libro";

        // Acceso al contenido de la página 1 utilizando el indexador
        string contenidoPagina1 = miLibro[1];

        // Impresión del contenido de la página 1 en la consola
        Console.WriteLine(contenidoPagina1);
    }
}
