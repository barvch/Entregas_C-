using System;

namespace _11_Matrices {
    class Program {
        static void Main() {
            int medida = 0;
            // Se lee la dimensión de la matriz hasta que se ingrese un número válido
            do {
                try {
                    Console.WriteLine("Ingrese la proporción de la matriz (Ej. 2 -> 2x2): "); // Se muestra el menú                                                                                                                //Se lee la opcion seleccionada por el usuario
                    medida = Convert.ToInt32(Console.ReadLine());
                    if (medida <= 1) {
                        Console.WriteLine("Ingrese un número mayor a 1 para crear la matriz.");
                        Console.ReadKey();
                    } else {
                        break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("ERROR: Ingresa un número.");
                    //Console.ReadKey();
                }
            } while (true); // Se valida que sea una medida válida


            //Se crean ambas matrices vacías

            int[,] matriz1 = new int[medida, medida];
            int[,] matriz2 = new int[medida, medida];


            // Se llenan ambas matrices con los datos del usuario

            matriz1 = LlenarValores(matriz1,medida);
            matriz2 = LlenarValores(matriz2, medida);

            // Se muestra el menú hasta que usuario indique que desea salir del programa.
            do {
                try {
                    int[,] matrizResultado = new int[medida, medida]; // Reset a la matriz resultado
                    Console.Clear();
                    Console.WriteLine("Selecciona una operación a realizar con las matrices");
                    Console.WriteLine("(S)umar\n(R)estar\n(M)ultiplicar\nX : Salir del programa");
                    char opcion = Convert.ToChar(Console.ReadLine()); // Se lee la opción
                    if(opcion == 'X' || opcion == 'x') { // Si desea salir del programa
                        Console.WriteLine("Fin del programa.");
                        break; // Se sale del bucle infinito
                    }
                    switch (opcion) { // Se itera con la operación que ingresó
                        case 'S': // Si es suma 
                            Console.WriteLine("Sumando matrices...");

                            // Se hace la suma de las matrices
                            for (int fila = 0; fila < medida; fila++) { 
                                for (int columna = 0; columna < medida; columna++) {
                                    matrizResultado[fila, columna] = matriz1[fila, columna] + matriz2[fila, columna];
                                }
                            }
                            Console.WriteLine("Matriz 1");
                            mostrarArrelgo(matriz1,medida);
                            Console.WriteLine("\nMatriz 2");
                            mostrarArrelgo(matriz2, medida);
                            Console.WriteLine("\nResultado de la suma: ");
                            mostrarArrelgo(matrizResultado, medida);
                            Console.ReadKey();

                            break; // Del case S.

                        case 'R':
                            Console.WriteLine("Restando matrices...");

                            // Se hace la resta de las matrices
                            for (int fila = 0; fila < medida; fila++) {
                                for (int columna = 0; columna < medida; columna++) {
                                    matrizResultado[fila, columna] = matriz1[fila, columna] - matriz2[fila, columna];
                                }
                            }

                            // Se imprimen las matrices con las que se realizó el cálculo y el resultado

                            Console.WriteLine("Matriz 1");
                            mostrarArrelgo(matriz1, medida); 
                            Console.WriteLine("\nMatriz 2");
                            mostrarArrelgo(matriz2, medida);
                            Console.WriteLine("\nResultado de la suma: ");
                            mostrarArrelgo(matrizResultado, medida);
                            Console.ReadKey();

                            break; // Del case R

                        case 'M':
                            Console.WriteLine("Multiplicando matrices...");

                            // Se hace la suma de las matrices
                            for (int fila = 0; fila < medida; fila++) {
                                for (int columna = 0; columna < medida; columna++) {
                                    matrizResultado[fila, columna] = matriz1[fila, columna] * matriz2[fila, columna];
                                }
                            }

                            // Se imprimen las matrices con las que se realizó el cálculo y el resultado

                            Console.WriteLine("Matriz 1");
                            mostrarArrelgo(matriz1, medida);
                            Console.WriteLine("\nMatriz 2");
                            mostrarArrelgo(matriz2, medida);
                            Console.WriteLine("\nResultado de la suma: ");
                            mostrarArrelgo(matrizResultado, medida);
                            Console.ReadKey();
                            break;
                        default :
                            Console.WriteLine("Opción ingresada inválida.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("ERROR");
                    //Console.ReadKey();
                }
            } while (true); 
        }

        public static void mostrarArrelgo(int [,] arreglo, int medida) {  // Recorre y mueatra el contenido de una matriz con su formato
            for (int i = 0; i < medida; i++) { 
                for (int j = 0; j < medida; j++) {
                    Console.Write(arreglo[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
        }

        public static int[,] LlenarValores(int[,] arreglo, int dimension) { // Regresa el mismo objeto que recibe, pero ya con los valores que han sido ingresados por el usuario.
            do {
                try {
                    Console.Clear();
                    Console.WriteLine("Por favor, ingresa los valores para {0}", arreglo);

                    // Se recorre la matriz y va llenando. 
                    for (int i = 0; i < dimension; i++){
                        for (int j = 0; j < dimension; j++) {
                            Console.WriteLine("Ingrese el valor para [{0}][{1}] : ", i, j);
                            int valor = Convert.ToInt32(Console.ReadLine());
                            if (valor > 0 || valor < 100) {
                                arreglo[i, j] = valor;
                            } else {
                                Console.WriteLine("Ingrese un número entre 0 y 100");
                                Console.ReadKey();
                            }
                        }
                    }
                    return arreglo; // Regresa la matriz llena.
                } 
                catch (FormatException) { // Ingresa algo que no sea un número.
                    Console.WriteLine("ERROR: ingresa un número");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
