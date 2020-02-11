using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Polimormismo
{
    class Guitarra : InstrumentoAire {
        // Atributos

        public string Marca;
        public string Color;

        public Guitarra(string marca,string color ) {
            Marca = marca;
            Color = color;
        }

        //Metodos
        public string TocarCon() {
            Console.WriteLine("Con espiga");
            return "espiga";
        }
    }
}
