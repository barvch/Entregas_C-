using System;
using System.Globalization;
using System.Threading;

namespace _10_Persona {
    class Program {
        static void Main(string[] args) {

            // Variables para la ejecución del programa
            string nombre_ingresado;
            int anio_ingresado;
            int altura_ingresado;
            int peso_ingresado;

            Console.Write("Conversion de datos de una persona al sistema inglés.\nIngresa los datos de la persona:\n");
            Console.WriteLine("Nombre : ");
            nombre_ingresado = Console.ReadLine();

            // Validación para el año

            do {
                try {
                    Console.WriteLine("Año de nacimiento (YYYY) : ");
                    anio_ingresado = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingrese un año correcto.");
                }
            } while (true);

            // Validación para la altura

            do
            {
                try {
                    Console.WriteLine("Altura (cm) : ");
                    altura_ingresado = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingrese una altura correcta.");
                }
            } while (true);

            // Validación para el peso

            do
            {
                try {
                    Console.WriteLine("Peso (kg) : ");
                    peso_ingresado = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingrese un peso correcto.");
                }
            } while (true);

            // Se validan todos los datos, se crea el objeto tipo Persona
            Persona nuevo = new Persona(nombre_ingresado, anio_ingresado, altura_ingresado, peso_ingresado);

            // Se mandan a llamar a los 3 métodos 

            nuevo.calcularEdad(anio_ingresado);
            nuevo.cmToft(altura_ingresado);
            nuevo.kgTolb(peso_ingresado);

            Console.WriteLine("\nFin del programa. Ingrese un caracter para finalizar");
            Console.ReadKey();
        }
    }
}