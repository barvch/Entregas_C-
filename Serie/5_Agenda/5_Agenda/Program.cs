using System;
using System.Collections.Generic;

namespace Serie._5
{
    class Program {
        static void Main(string[] args) {

            // Variables para el programa

            Dictionary<string, int> agenda = new Dictionary<string, int>();
            int opcion = 0;

            while (opcion != 4) { // Mientas no se ingrese la opción de salida dentro del programa
                try {
                    // Si la opción está dentro de las permitidas
                    while (opcion > 4 || opcion == 0 || opcion < 1) {
                        do {
                            try {
                                Console.Clear(); //Se limpia la pantalla 
                                Console.WriteLine("***MENU***");
                                Console.WriteLine("1) Agregar un contacto\n 2) Eliminar un contacto\n 3) Mostrar un contacto\n 4) Salir del programa\n"); // Se muestra el menú
                                                                                                                                                          //Se lee la opcion seleccionada por el usuario
                                opcion = Convert.ToInt32(Console.ReadLine());
                                if (opcion > 4 || opcion < 1) { // Si el número ingresado es inválido
                                    Console.WriteLine("ERROR: Opción inválida.\n");
                                }
                                break; // Se sale de la valiacíón de que se a un número
                            } 
                            catch (FormatException) {
                                Console.WriteLine("ERROR: Ingresa un número.");
                                Console.ReadKey();
                            }
                            
                        } while (true);
                    }
                }
                catch (FormatException) {
                    //En caso de que ocurra un error en la seleccion de la opcion se muestra este mensaje
                    Console.WriteLine("ERROR: Ingrese un numero entero");
                    Console.ReadKey();
                }
                finally { // Cuando se valida que sea una opción de las que se encuentran disponibles
                    switch (opcion) {
                        case 0: // Menú
                            break;
                        case 1: // Agregar un contacto
                            Console.WriteLine("Nombre del contacto: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Numero de {0} :", nombre);
                            string numero = "";
                            numero = Console.ReadLine();
                            while (numero.Length != 10) { // Se verifica la longitud del numero ingresado hasta que sea 10
                                Console.WriteLine("Longitud invalida para un numero de telefono, intente de nuevo");
                                numero = Console.ReadLine();
                            }
                            int x = Convert.ToInt32(numero);
                            agenda.Add(nombre,x);
                            Console.WriteLine("{0} ha sido agregado a la agenda con exito\n", nombre);
                            Console.ReadKey();
                            opcion = 0; // Reset a la variable
                            break; // Se regresa al menú

                        case 2: // Eliminar un contacto) 
                            do {
                                Console.WriteLine("Ingrese el nombre del contacto a eliminar");
                                nombre = Console.ReadLine();

                                // Se busca el contacto en caso de existir

                                bool existe2= agenda.ContainsKey(nombre);
                                if (existe2) { // Si se encuentra
                                    agenda.Remove(nombre); // Se elimina
                                    Console.WriteLine("{0} fue eliminado con exito\n", nombre);
                                    Console.ReadKey();
                                    break;
                                } else { // Si no se encuentra
                                    Console.WriteLine("{0} no existe en la agenda\n", nombre);
                                }
                            } while (true);
                            opcion = 0;
                            break; // Break caso 2, regresa al manu
                        case 3:
                            do {
                                Console.WriteLine("Ingrese el nombre contacto a revisar");
                                nombre = Console.ReadLine();

                                // Se busca el contacto en caso de existir

                                bool existe2 = agenda.ContainsKey(nombre);
                                if (existe2) { // Si se encuentra
                                    Console.WriteLine("Numero de {0} : {1}\n", nombre, agenda[nombre]);
                                    Console.ReadKey();
                                    break;
                                } else { // Si no se encuentra
                                    Console.WriteLine("{0} no existe en la agenda\n", nombre);
                                }
                            } while (true);
                            opcion = 0;
                            break; // Break caso 3, regresa al menú
                    }
                }
            }
        }
    }
}