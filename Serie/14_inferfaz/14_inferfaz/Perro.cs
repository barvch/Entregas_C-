using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inferfaz {
    class Perro : IComer {

        //Atributos de un Perro
        public string Nombre { get; set; }
        public string Raza { get; set; }

        // Método

        public string Comer() {
            Console.WriteLine("Los perros comen croquetas.");
            return "Los perros comen croquetas.";
        }
    }
}
