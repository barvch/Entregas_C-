using System;
using System.Collections.Generic;
using System.IO;

namespace Consola {
    class Program {
        static void Main(string[] args) {

            List<string> historial = new List<string>();
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            do {
                try {
                    Console.Write("{0}>: ", Directory.GetCurrentDirectory());

                    // Se trabaja con toda la cadena que se manda por medio del prompt 

                    string entrada = Console.ReadLine(); // Se lee toda la entrada
                    if (entrada == "exit") {
                        break; // Se sale del programa
                    }
                    if (entrada == "") { // No se ingresó nada
                         // Se vuelve mostrar el prompt
                    } else {
                        historial.Add(entrada);
                        string[] parse = entrada.Split(' '); // Se guardan todas las palabras ingresadas dentro de un arreglo

                        /*
                        foreach(var paralabra in parse) {
                            Console.WriteLine("{0}", paralabra);                    
                        }*/

                        if (parse.Length == 1) { // Sólo se ejecutó un comando (cls, dir o history)
                            if (parse[0] == "cls") {
                                Console.Clear();
                            } else {
                                if (parse[0] == "dir") {
                                    // Muestra contenido del directorio actual

                                    foreach (var resultado in Directory.GetDirectories(Directory.GetCurrentDirectory())) {
                                        Console.WriteLine(resultado);
                                    }
                                    foreach (var resultado in Directory.GetFiles(Directory.GetCurrentDirectory())) {
                                        Console.WriteLine(resultado);
                                    }
                                } else {
                                    if (parse[0] == "history") {
                                        // Muestra el historial de comandos
                                        Console.WriteLine("Historial:");
                                        foreach (var comando in historial) {
                                            Console.WriteLine(comando);
                                        }
                                    } else {
                                        Console.WriteLine("ERROR: Comando no encontrado.");
                                    }
                                }
                            }
                        } else { // Casos para touch, move, cd, dir para otro dir.
                            switch (parse[0]) {
                                case "move":
                                    if (parse.Length != 3) { // los 3 argumentos que se esperan, tomando en cuenta el propio comando move 
                                        Console.WriteLine("ERROR: Formato no válido para el comando move.\nFormato: move <rutaInicial> <rutaFinal>");
                                    } else { 
                                        if (parse[1].Contains("\\")) {
                                            if (parse[2].Contains("\\")) {
                                                if (File.Exists(parse[1])) { // Si existe el primer argumento
                                                    Console.WriteLine("Moviendo...");
                                                    File.Move(parse[1], parse[2]);
                                                    Console.WriteLine("Éxito.");
                                                } else { 
                                                    Console.WriteLine("No se encontró el directorio el source");
                                                }
                                            } else {
                                                string actual = Directory.GetCurrentDirectory();
                                                if (File.Exists(parse[1])) { // Si existe el primer argumento
                                                    Console.WriteLine("Moviendo...");
                                                    File.Move(parse[1], actual + "\\" + parse[2]);
                                                    Console.WriteLine("Éxito.");
                                                } else {
                                                    Console.WriteLine("No se encontró el directorio el source");
                                                }
                                            }
                                        } else if (parse[2].Contains("\\")) {
                                            string actual = Directory.GetCurrentDirectory();
                                            if (File.Exists(actual + "\\" + parse[1])) { // Si existe el primer argumento
                                                Console.WriteLine("Moviendo...");
                                                File.Move(actual + "\\" + parse[1], parse[2]);
                                                Console.WriteLine("Éxito.");
                                            } else {
                                                Console.WriteLine("No se encontró el directorio el source");
                                            }

                                        } else {
                                            string actual = Directory.GetCurrentDirectory();
                                            Console.WriteLine("{0}\n{1}", actual + "\\" + parse[1], actual + "\\" + parse[2]);
                                            if (File.Exists(actual + "\\" + parse[1])) { // Si existe el primer argumento
                                                Console.WriteLine("Moviendo...");
                                                File.Move(actual + "\\" + parse[1], actual + "\\" + parse[2]);
                                                Console.WriteLine("Éxito.");
                                            } else {
                                                Console.WriteLine("No se encontró el directorio el source");
                                            }
                                        }
                                    }
                                    break; // Fin caso move
                                case "cd":
                                    if (parse.Length != 2) {
                                        Console.WriteLine("ERROR: Formato no válido para el comando cd.\nFormato: cd <rutaNuevoDirectorio>");
                                    } else {
                                        if (parse[1] == "..") { // Caso de moverse al padare del directorio actual
                                            Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
                                        }
                                        if (Directory.Exists(parse[1])) { // Moverse a un directorio en particular
                                            Directory.SetCurrentDirectory(parse[1]);
                                        } else {
                                            Console.WriteLine("ERROR: No se encontró el directorio indicado para cambiarse.");
                                        }
                                    }
                                    break; // Fin caso cd
                                case "dir":
                                    if (parse.Length != 2) { // Se meten más valores de los esperados por el comando dir
                                        Console.WriteLine("ERROR: Formato no válido para el comando dir.\nFormato: dir <rutaDirectorioMostrar>");
                                    } else { 
                                        if (Directory.Exists(parse[1])) { // Se valida que se pueda encontrar el directorio
                                            foreach (var resultado in Directory.GetDirectories(Directory.GetCurrentDirectory())) {
                                                Console.WriteLine(resultado);
                                            }
                                            foreach (var resultado in Directory.GetFiles(Directory.GetCurrentDirectory())) {
                                                Console.WriteLine(resultado);
                                            }
                                            //Console.WriteLine("Contenido de {0}:\n{1}\n{2}",parse[1],Directory.GetFiles(parse[1]), Directory.GetDirectories(parse[1])); // Se muestra el contenido                                        
                                        } else {
                                            Console.WriteLine("ERROR: No se pudo encontrar el directorio indicado.");
                                        }
                                    }
                                    break; // Fin caso dir
                                case "touch":
                                    if (parse.Length != 2) { // Si se meten más valores de los espreados por el comando touch
                                        Console.WriteLine("ERROR: Formato no válido para el comando touch\nFormato: touch <rutaDirectorioYaConArchivoACrear>");
                                    } else { 
                                        if (parse[1].Contains("\\")) { // Contiene una ruta (?) 
                                            if (File.Exists(parse[1])) {
                                                Console.WriteLine("ERROR: El archivo ya existe.");
                                            } else {
                                                File.Create(parse[1]).Close();
                                                
                                            }
                                            
                                        } else {
                                            //Directory.CreateDirectory
                                            string dirActual = Directory.GetCurrentDirectory();
                                            if (File.Exists(dirActual + "\\" + parse[1])) {
                                                Console.WriteLine("ERROR: El archivo ya exite");
                                            } else {
                                                File.Create(dirActual + "\\" + parse[1]).Close();
                                            }
                                        }
                                    }
                                    break; // Fin caso touch
                                default:
                                    Console.WriteLine("ERROR: Comando no conocido. Ingrese un comando válido");
                                    break;
                            }
                        }
                    }
                }
                catch (IOException)  {
                    Console.WriteLine("ERROR!");
                }
            } while (true); // Se ejecuta el programa hasta que se ejecuta el comando exit
        }
    }
}
