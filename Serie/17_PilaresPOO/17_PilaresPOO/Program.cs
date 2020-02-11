using System;

namespace _17_PilaresPOO {
    class Program {
        static void Main(string[] args) {
            Monoaural monofono = new Monoaural("AudioTecnica5000", 50000);
            Stereo audifonos = new Stereo("Bosé 5000", 35000);

            Console.WriteLine("Cantidad de canales en un reproductor de vinilos: {0}", monofono.Cantidad());
            Console.WriteLine("Cantidad de canales en audífonos: {0}", audifonos.Cantidad());
        }
    }
}
