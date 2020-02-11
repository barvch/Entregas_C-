using System;
using System.Collections.Generic;
using System.Text;

namespace _17_PilaresPOO
{
    class Monoaural : CanalesDeSonido {
        public string Nombre;
        private int Precio { get; set; } // A

        // Constructores 
        public Monoaural(string nombre, int precio) {
            Nombre = nombre;
        }

        public int Cantidad() {
            return 1;
        }
    }
}
