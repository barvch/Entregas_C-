using System;

namespace _13_Carro {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello World!");
            Carro Jetta = new VW(1200, 1.50) { Modelo = "2019" };
            Carro Silverado = new Ford(7000, 2) { Modelo = "3RX" };

            // Se ejecutan lo métodos

            Console.WriteLine(Jetta.ToString());
            Jetta.Estado();
            Jetta.Encender();
            Jetta.Estado();
            Jetta.Apagar();
            Jetta.Estado();

            Console.WriteLine(Silverado.ToString());
            Silverado.Estado();
            Silverado.Encender();
            Silverado.Estado();
            Silverado.Apagar();
            Silverado.Estado();

        }
    }
}
