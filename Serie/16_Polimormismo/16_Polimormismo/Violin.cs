using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Polimormismo {
    class Violin : InstrumentoAire {
        // Atributos

        public string Madera;
        public string Color;

        public Violin(string madera, string color) {
            Madera = madera;
            Color = color;
        }

        //Metodos
        public string TocarCon() {
            Console.WriteLine("Con su utensilio.");
            return " utensilio";
        }
    }
}
