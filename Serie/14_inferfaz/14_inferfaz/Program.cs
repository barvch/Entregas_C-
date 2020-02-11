using System;

namespace _14_inferfaz {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello World!");

            // Se crean objetos de las clases

            Humano humano1 = new Humano();
            Grillo grillo1 = new Grillo();
            Perro doggo1 = new Perro();

            // Se mandan a llamar al método comer, el cual es establecido en la interfaz

            humano1.Comer();
            doggo1.Comer();
            grillo1.Comer();
        }
    }
}
