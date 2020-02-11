using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inferfaz {
    class Grillo {

        //Atributos de un grillo
        public string Nombre { get; set; }
        public string Color { get; set; }

        // Método

        public string Comer() {
            Console.WriteLine("Los grillos comen bichos");
            return "Los grillos comen bichos";
        }
    }
}
