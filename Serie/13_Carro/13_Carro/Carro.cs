using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Carro
{
    class Carro {

        // Atributos
        private double peso; 
        public double Peso { 
            
            get { return peso; } //Métodos get y set
            set { peso = value; }
        }
        private double altura; 
        public double Altura {
            get { return altura; }
            set { altura = value; }
        }
        private bool encendido;
        public bool Encendido {
            get { return encendido; }
            set { encendido = false; }
        }

        //Constructores 

        public Carro(double peso, double altura) { 
            Peso = peso; // Referencia al privado
            Altura = altura; // Referencia al privado
        }

        // Métodos de la clase Carro

        public void Encender() {
            encendido = true; 
            Console.WriteLine("Se ha prendido el coche");
        }
        public void Apagar() {
            encendido = false; 
            Console.WriteLine("Se ha apagado el cocche");
        }

        public void Estado() {
            if (encendido) {//Se valida el valor del campo encendido 
                Console.WriteLine("Encendido");
            } else {
                Console.WriteLine("Apagado");
            }
        }

        public override string ToString() {
            return string.Format("Datos del auto:\nPeso : {0}, Altura : {1}\n",peso, altura);
        }



    }
}
