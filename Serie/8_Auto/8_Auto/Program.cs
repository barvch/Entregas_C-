using System;

namespace _8_Auto {
    class Program {
        static void Main(string[] args) {

            // Se crean dos objetos.

            Auto auto1 = new Auto();
            Auto auto2 = new Auto("Nissan March", "Rojo", 120000);

            // Se mandan a  llamar lo métodos

            auto1.Encender();
            auto2.Imprimir();
            auto2.CambiarColor();
            //auto2.Imprimir();

            Console.WriteLine("\nFin de la ejecución del programa. Presione una tecla para salir");
            Console.ReadKey();
        }
    }

    class Auto {

        //Atributos

        public string Color { get; set; }
        public string Nombre { get; set; }
        public int Precio  { get;set; }


        // Constructores

        public Auto() { // Constructor vacío con valores default
            Color = "Blanco";
            Nombre = "Mazda 3 ";
            Precio = 140000;
        }

        public Auto(string color, string nombre, int precio) { // Constructor con valores pasados
            Color = color;
            Nombre = nombre;
            Precio = precio;
        }
        
        // Métodos

        public void Encender() {
            Console.WriteLine("{0} ahora está encendido.", Nombre);
        }

        public void CambiarColor() {
            Color = "Negro";
            Console.WriteLine("Se ha cambiado el color del coche.\nNuevo color: {0}", Color);
        }

        public void Imprimir() {
            Console.WriteLine("Datos del coche:\nNombre : {0}\nColor : {1}\nPrecio : {2}\n", Nombre, Color, Precio);
        }
    }
}
