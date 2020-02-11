using System;

namespace _1_Naturales {
    class Program {
        static void Main(string[] args) {

            // Variables para la ejeción del programa.

            int n;
            int resultado = 0;

            // Se valida y captura el dato ingresado por el usuario

            do {
                try {
                    Console.WriteLine("N: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error) {
                    Console.WriteLine("ERROR. Ingresa un número.");
                
                }
            } while (true);
            
            // Se valida que el número ingresado sea mayor a cero 

            if (n > 0 ) {
                for (int contador = 1; contador <= n; contador++) {
                   resultado += contador;
                }
                Console.WriteLine("\nLa suma de los primeros {0} números naturales es {1}.\nFin del programa. Presione una tecla para salir.\n", n, resultado);
                Console.ReadKey();
            } else {
                // 
                Console.WriteLine("\nFin del programa.");
                Console.ReadKey();
            }
        }
    }
}
