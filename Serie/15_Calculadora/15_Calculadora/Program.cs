using System;

namespace _15_Calculadora {
    class Program {
        static void Main() {
            do {
                try {
                    Console.Clear();
                    Console.WriteLine("Bienvenido\nIngrese la opcion de la calculadora...\n1) Suma\n2) Resta\n3) Multiplicación\n4) División\n5) Salir del programa");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 5) { // Si se ingresa la opción de salida del programa
                        Console.WriteLine("Fin del programa.");
                        break;
                    }
                    switch (opcion) // Se itera con el número que ingresó
                    {
                        case 1: // Caso de la suma
                            int num1, num2;
                            Console.WriteLine("Ingresa el valor del primer operando: "); // Se solicita el num1 
                            do {
                                try {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num1
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("Ingresa el valor del segundo operando: "); // Se solicita el num2
                            do { //  Hasta que encuentre un operando válido
                                try {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num2
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("El resultado de sumar {0} + {1}  es {2}",num1,num2, num1 + num2); // Se imprime el resultado de la suma
                            Console.ReadKey();
                            break; // Fin de Case 1
                        case 2:
                            //int num1, num2;
                            Console.WriteLine("Ingresa el valor del primer operando: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num1
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("Ingresa el valor del segundo operando: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num2
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("El resultado de restar {0} + {1}  es {2}", num1, num2, num1 - num2);
                            Console.ReadKey();
                            break; // Fin case 2
                        case 3:
                            Console.WriteLine("Ingresa el valor del primer operando: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num1
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("Ingresa el valor del segundo operando: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num2
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                            } while (true);
                            Console.WriteLine("El resultado de multiplicar {0} + {1}  es {2}", num1, num2, num1 * num2);
                            Console.ReadKey();
                            break; // Fin case 3
                        case 4:
                            Console.WriteLine("Ingresa el valor del numerador: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    break; // Se lee correctamente num1
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                                
                            } while (true);
                            Console.WriteLine("Ingresa el valor del denominador: ");
                            do { // Hasta que encuentre un operando válido
                                try {
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    if (num2 == 0) { // División entre cero
                                        Console.WriteLine("ERROR: No se puede divir entre cero");
                                        Console.ReadKey();
                                        Console.WriteLine("Ingresa el valor del denomianador");
                                        //break;
                                    } else {
                                        break; // Se lee correctamente num2
                                    }
                                }
                                catch (FormatException) {
                                    Console.WriteLine("ERROR: No ingresaste un numero");
                                }
                                catch (DivideByZeroException error) {
                                    Console.WriteLine("ERROR: División entre cero inválida");
                                    Console.WriteLine(error.Message);
                                }

                            } while (true);
                            Console.WriteLine("El resultado de dividir {0} / {1}  es {2}", num1, num2, num1 / num2);
                            Console.ReadKey();

                            break; // Fin case 4

                        default:
                            Console.WriteLine("ERROR: Ingresa una opción válida");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException){
                    Console.WriteLine("ERROR. Ingrese un número.");
                }
            } while (true);

            
        }

        /*public int Suma() {
            int resultado;

            return 0;
        }
        */
    }
}
