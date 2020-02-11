using System;
using System.IO;

namespace _18_ManejoArchivos {
    class Program { 
        static void Main() {
            string path = Directory.GetCurrentDirectory(); // Se obtiene el directorio actual
            string archivo = path + "\\texto.txt"; // Se busca el archivo a abrir
            try {
                string texto = System.IO.File.ReadAllText(archivo); // Se lee todo el contenido
                Console.WriteLine("Conteido del archivo: {0}", texto); // Se imprime

            }
            catch (FileNotFoundException) { // Si no logra encontrar el archivo
                Console.WriteLine("No se encontró el archivo");
            } 
        }
    }
}
