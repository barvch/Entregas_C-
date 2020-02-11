using System;

namespace _16_Polimormismo {
    class Program {
        static void Main() {
            Bajo bajo = new Bajo(4,"Rojo");
            Violin violin = new Violin("Cedro","Café");
            Guitarra guitarra = new Guitarra("Fender", "Negro");

            Console.WriteLine("El bajo se toca " + bajo.TocarCon());
            Console.WriteLine("El violin se toca con " + violin.TocarCon()); 
            Console.WriteLine("La guitarra se toca con " + guitarra.TocarCon());



            Console.WriteLine("\nFin del prorama");
            Console.ReadKey();
        }
    }
}
