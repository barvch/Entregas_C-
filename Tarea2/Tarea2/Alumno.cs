using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2 {
    class Alumno {
        //Atributos de un alumno
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public int CalifProyecto { get; set; }
        public int Tareas { get; set; } // 5 como máximo
        public int Participaciones { get; set; } // > 5, aumenta 8% su calif.
        public double Calificacion { get; set; }

        //Constructor 
        public Alumno(string nombre, string appaterno, string apmaterno, int proyecto, int tareas, int participaciones, double calificacion) {
            Nombre = nombre;
            ApPaterno = appaterno;
            ApMaterno = apmaterno;
            CalifProyecto = proyecto;
            Tareas = tareas;
            Participaciones = participaciones;
            Calificacion = calificacion;
        }

    }
    static class Calculadora {
        public static double Calificar(int proyecto, int tareas, int participaciones) {
            //Un par de validaciones 
            if (tareas > 5) {
                tareas = 5;
            }

            if (proyecto > 10) {
                proyecto = 10;
            }

            proyecto *= 6;
            tareas *= 8;

            double calificacion = proyecto + tareas;

            if (participaciones > 5) {
                calificacion *= 1.08;
            }
            if (calificacion < 50)
            {
                calificacion = 50;
            }
            else if (calificacion > 100) {
                calificacion = 100;
            }

            return calificacion;
        }
    }
}


