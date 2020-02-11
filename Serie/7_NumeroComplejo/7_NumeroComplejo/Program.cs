using System;

namespace _7_NumeroComplejo{
    class Program {
        static void Main(string[] args) {
            //Se crean dos numeros complejos.
            NumeroComplejo num1 = new NumeroComplejo(5,-2);
            NumeroComplejo num2 = new NumeroComplejo(10, 2);

            // Se ejecuatan los métodos 

            num1.imprimir(); // Se imprime el primer número complejo creado
            NumeroComplejo num3 = num2.sumaComplejos(num1); // Se crea un tercer número complejo usando la función suma
            num3.imprimir(); // Se imprime el valor del nuevo numero complejo creado

            Console.WriteLine("Fin del programa. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }

    class NumeroComplejo {
        // Atributos

        public long parteReal;
        public long parteImaginaria;

        // Constructores
        public NumeroComplejo(long partereal, long parteimaginaria) {
            parteImaginaria = parteimaginaria;
            parteReal = partereal;
        }

        // Métodos

        public void imprimir() {
            if (parteImaginaria > 0) { // Entonces se imprime también la parte imaginaria
                Console.WriteLine("{0}+{1}i", parteReal, parteImaginaria);
            } else if (parteImaginaria == 0) { // Entonces se imprime solo la parte real
                Console.WriteLine("{0}", parteReal);
            } else {  // Si la parte real es negativa, se indica que es un número imaginario
                Console.WriteLine("{0}{1}i", parteReal, parteImaginaria);
            }
        }
        public NumeroComplejo sumaComplejos(NumeroComplejo asumar) {
            NumeroComplejo nuevo = new NumeroComplejo(parteReal+asumar.parteReal,parteImaginaria+asumar.parteImaginaria);
            // Se le suma el numero que va a crear la parte real y la parte imaginaria y lo regresa
            return nuevo;
        }
    }
}
