using System;
using System.Collections.Generic;
using System.Text;

namespace _17_PilaresPOO {
    class Stereo : CanalesDeSonido
    {
        public string Nombre;
        private int Precio { get; set; }

        // Constructores
        public Stereo(string nombre, int precio) {
            Nombre = nombre;
        }

        public int Cantidad() {
            return 2;
        }
    }
}
