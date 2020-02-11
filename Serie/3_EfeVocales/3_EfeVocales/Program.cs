using System;
using System.Linq;

namespace _3_EfeVocales {
    class Program {
        static void Main(string[] args) {

            // Variables para la ejecución del programa

            string cadena;
            char[] Vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string output = ""; // Será la cadena final después de la conversión

            // Se lee la cadena si ingresa alguna, en caso contrario, pide que ingrese un cadena.
            // Se recorre caracter por caracter hasta encontrar una vocal

            do {
                Console.WriteLine("Ingresa la cadena: ");
                cadena = Console.ReadLine();
                if (cadena.Length != 0) {
                    foreach (char letra in cadena) {
                        if (Vocales.Contains(letra)) { // Si la letra que se itera es una vocal
                            output += "f" + letra; //Se agrega f al principio de la vocal y al output
                        } else {
                            output += letra; // Se agrega la letra actual al output
                        }
                    }
                    Console.WriteLine("Cadena convertida: {0}", output);
                    break;
                }
                else {
                    Console.WriteLine("No se ha ingresado una cadena. Intente de nuevo...");
                }
            } while (true);
            Console.WriteLine("Fin del programa. Presione una tecla para salir del programa.");
            Console.ReadKey();
        }
    }
}
