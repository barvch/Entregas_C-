using System;

namespace _2_clap {
    class Program {
        static void Main(string[] args) {
            // Variables para guardar los valores que son metidos por el usuario.
            int num1, num2;

            // Validaciones de num1

            do {
                try {
                    Console.WriteLine("Ingresa el valor de num1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error) {
                    Console.WriteLine("ERROR. Ingresa un número.");

                }
            } while (true);

            // Validaciones de num2

            do
            {
                try {
                    Console.WriteLine("Ingresa el valor de num2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error) {
                    Console.WriteLine("ERROR. Ingresa un número.");
                }
            } while (true);

            Console.WriteLine();

            // Se recorren todos los naturales del 1 al 100 e imprime 'clap' en los casos que hagan match.

            for (int i = 1; i <= 100; i++) {
                if (i % num1 == 0 || i % num2 == 0) {
                    Console.WriteLine("clap");
                } else {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\nFin del programa. Presione una tecla para salir del programa\n");
            Console.ReadKey();
        }
    }
}
