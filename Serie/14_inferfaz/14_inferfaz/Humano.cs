using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inferfaz
{
    class Humano : IComer {

        //Atributos de un humano
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Método

        public string Comer() {
            Console.WriteLine("Los humanos comen tanto animales como vegetales");
            return "Los humanos comen tanto animales como vegetales.";
        }

    }
}
