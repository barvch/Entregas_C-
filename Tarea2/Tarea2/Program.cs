using System;

namespace Tarea2 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ingresa la cantidad de alumnos a evaluar: ");
            int num_alumnos = System.Convert.ToInt32(System.Console.ReadLine());
            Alumno[] alumnos = new Alumno[num_alumnos];

            //Se capturan los datos de los alumnos
            for (int i = 0; i < num_alumnos; i++) {
                string nuevoAlumno = "Alumno" + System.Convert.ToString(i);
                Console.WriteLine("Ingresa los datos del alumno {0}: ", i);
                Console.WriteLine("Nombre(s): ");
                //alumnos[i].Nombre = Console.ReadLine();
                string Nombre = Console.ReadLine();
                Console.WriteLine("Apellido Paterno: ");
                //alumnos[i].ApPaterno = Console.ReadLine();
                string ApPaterno = Console.ReadLine();
                Console.WriteLine("Apellido Materno: ");
                //alumnos[i].ApMaterno = Console.ReadLine();
                string ApMaterno = Console.ReadLine();
                Console.WriteLine("Calificación del Proyecto: ");
                //alumnos[i].CalifProyecto = System.Convert.ToInt32(System.Console.ReadLine());
                int CalifProyecto = System.Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("Número de tareas: ");
                //alumnos[i].Tareas = System.Convert.ToInt32(System.Console.ReadLine());
                int Tareas = System.Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("Número de participaciones: ");
                //alumnos[i].Participaciones = System.Convert.ToInt32(System.Console.ReadLine());
                int Participaciones = System.Convert.ToInt32(System.Console.ReadLine());

                double Calificacion = Calculadora.Calificar(CalifProyecto, Tareas, Participaciones);

                alumnos[i] = new Alumno(Nombre, ApPaterno, ApMaterno, CalifProyecto, Tareas, Participaciones, Calificacion);
                Console.WriteLine();
            }


            //Se imprimen los alumnos con las calificaciones registradas

            foreach (var sujeto in alumnos) {
                Console.WriteLine("La calificación de {0} {1} {2} es {3}", sujeto.Nombre, sujeto.ApPaterno, sujeto.ApMaterno, sujeto.Calificacion);
                Console.WriteLine();
            }
            Console.WriteLine("Fin del programa, ingrese una tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
