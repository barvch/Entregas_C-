using System;
/*
 * 
Invesigación sobre Math.

    - Se incluye dentro de System.

    - Es una biblioteca que contiene constantes y métodos definidos para las constantes globales a trigonometría y funciones afines.

    - Sirve para realizar operaciones como conversión a ángulos, funciones trigonométricas, y demás operaciones con números en general
    que sobresalgan con lo que no se pueda obtener con las operaciones y operandos básicos.

     
*/
namespace _9_Math {
    class Program {
        static void Main(string[] args) {

            Circulo circulo = new Circulo(3.1416); // Se crea un objeto  Circulo de Radio = Pi
            Rectangulo rectangulo = new Rectangulo(3,5); // Se crea un objeto Rectángulo de Base 3 y Altura 5

            // Se manda a llamar a los métodos

            circulo.ExplicarArea();
            circulo.calcularArea();
            circulo.Datos();

            rectangulo.calcularArea();
            rectangulo.mostrarDatos();
            rectangulo.propiedadesRectanuglo();

            Console.WriteLine("Fin del programa. Ingrese una tecla para salir");
            Console.ReadKey();
            
        }
    }

    class Circulo {
        double Pi = Math.PI;
        public double Radio; // Atributo
        // Area es calculable sabiendo sólo el radio y la fórmula

        public Circulo(double radio) { // Constructor 
            Radio = radio;
        }

        public void ExplicarArea() {
            Console.WriteLine("El área de un círculo se calcula multiplicando  la constante universar Pi y el radio del círculo al cuadrado (r*r)");
        }

        public void Datos() {
            Console.WriteLine("Datos del círculo:\nRadio : {0}\nArea : {1}", Radio, Radio*Radio*Pi);
        }

        public void calcularArea() {
            Console.WriteLine("Mi area es de : {0}", Radio * Radio * Pi);
        }
    }

    class Rectangulo { 
        //Atributos
        public int Base;
        public int Altura;
        
        //Constructor
        public Rectangulo(int x, int y) {
            Base = x; 
            Altura = y;
        }

        //Métodos
        public void calcularArea() {
            Console.WriteLine("Mi area es: {0}", Base*Altura);
        }

        public void mostrarDatos() {
            Console.WriteLine("Mis datos son:\nBase : {0}\nAltura : {1}", Base, Altura);
        }

        public void propiedadesRectanuglo() {
            Console.WriteLine("Todos los ángulos de un rectánugulo son de 90 grados.");
        }
    }
}
