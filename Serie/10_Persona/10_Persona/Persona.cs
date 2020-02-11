using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;

namespace _10_Persona {
    class Persona {

        DateTime ahora = new DateTime(2020, 2, 9, 12, 00, 0); //Obtiene la 

        // Atributos

        public string Nombre;
        public int Año_Nacimiento; // Como cadena porque no se van a hacer operaciones con la edad. (?)
        public int Estatura; //En cm.
        public int Peso; // En kg.

        // Constructor

        public Persona(string nombre, int año, int estatura, int peso) {
            Nombre = nombre;
            Año_Nacimiento = año;
            Estatura = estatura;
            Peso = peso;
        } 

        // Métodos

        public void calcularEdad(int edad) {
            int edad_persona = ahora.Year - edad; // Se calcula la edad actual
            Console.WriteLine("\n{0} tiene {1} años de edad.", Nombre, edad_persona);
        }

        public void cmToft(int estatura) {
            double estaturaEnFt = estatura * 0.032808; //Factor de conversión (cm -> ft)
            Console.WriteLine("\n{0} mide {1} ft. ({2} cm)", Nombre, estaturaEnFt, estatura);
        }

        public void kgTolb(int peso) {
            double pesoEnlb = peso * 2.20462; // Factor de conversión (kg -> lb)
            Console.WriteLine("\n{0} pesa {1} libras. ({2} kg)", Nombre, pesoEnlb, peso);
        }
    }
}
