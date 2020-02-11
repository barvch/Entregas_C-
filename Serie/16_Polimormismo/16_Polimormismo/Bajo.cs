using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Polimormismo {
    class Bajo : InstrumentoAire {
        // Atributos

        public int Num_cuerdas;
        public string Color;

        // Constructores
        public Bajo(int cuerdas, string color) {
            Num_cuerdas = cuerdas;
            Color = color;
        }
        //Metodos
        public string TocarCon() {
            Console.WriteLine("Con y sin espiga.");    
            return "con y sin espiga";
        }
    }
}
