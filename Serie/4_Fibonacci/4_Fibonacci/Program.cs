using System;

namespace _4_Fibonacci {
    class Program {
        static void Main(string[] args) {
           
            // Variables necesarias
            int num;
            long actual = 0, siguiente = 1;

            // Se valida el número de elementos de la serie.

            do {
                try {
                    Console.WriteLine("Ingresa hasta qué número de la serie tengo que imprimir: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error) {
                    Console.WriteLine("ERROR. Ingresa un número.");
                }
            } while (true);

            Console.Write("Serie:\n\n");

            Fibonacci(num,actual,siguiente); // Se llama a la función con los valores iniciales 

            static long Fibonacci(int faltantes, long actual, long siguiente) {
                Console.WriteLine(actual); // Imprime valor actual
                if (faltantes == 1) {
                    Console.WriteLine("FIN"); //Ya no se necesitan más números
                    return 0;
                } else { 
                    return Fibonacci(faltantes-1,siguiente,siguiente+=actual); // Recursividad
                }
            }
        }
    }
}
