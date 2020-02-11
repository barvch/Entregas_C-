using System;
using System.Collections.Generic;


namespace _12_BecarioMart {
    class Program {

        // Cración de las listas para los productos que serán ingreasdos.

        static void Main() {
            int Total = 0;
            List<string> products = new List<string>();
            List<int> prices = new List<int>();
            do {
                try {
                    Console.Clear();
                    Console.WriteLine("Becario Mart\nMENU\n1) Agregar artículos al carrito\n2) Ver el carrito\n3) Salir del programa\nSeleccione una opción: ");
                    int opc1 = Convert.ToInt32(Console.ReadLine());
                    if (opc1 == 1) { // Desea agregar productos al carrito
                        AgregarProducto(products, prices);
                        Total = ConsultarCarrito(products, prices);
                    } else if (opc1 == 2) {
                        Carrito(products, prices);
                    } else if (opc1 == 3) {
                        Console.WriteLine("Fin del programa.");
                        Console.ReadKey();
                        break;
                    } else { 
                        Console.WriteLine("ERROR: Ingresa una opción valida");
                    }
                } 
                catch (FormatException) {
                    Console.WriteLine("ERROR: Ingresa un número.");
                }
            } while (true);

            void Carrito(List<string> productos, List<int> precios) {
                do {
                    try {
                        Console.Clear();
                        Console.WriteLine("CARRITO\nSeleccione una opción:\n1)Comprar carrito\n2)Editar Carrito\n3)Regresar al menú anterior : ");
                        int opc2 = Convert.ToInt32(Console.ReadLine());
                        if (opc2 == 1) { // Quiere comprar el carrito actual
                            if (Total > 500) { // Si el total del carrito es más de 500
                                Console.WriteLine("ERROR: Tu carrito supera los 500.");
                                Console.ReadKey();
                            } else {
                                Console.WriteLine("Muchas gracias por tu compra!\nFin del programa");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        } else if (opc2 == 2) {  // Si se desea eliminar algo dentro del carrito
                            do {
                                try {
                                    Console.Clear();
                                    Console.WriteLine("Eliminar un producto del carrito\n\nSeleccione un producto a eliminar indicando el índice del mismo: ");
                                    Total = ConsultarCarrito(products, prices);
                                    Console.WriteLine("Índice del producto a eliminar: ");
                                    int indice = Convert.ToInt32(Console.ReadLine());
                                    if (indice > prices.Count) {
                                        Console.WriteLine("Ingresa un índice correcto");
                                        Console.ReadKey();
                                    }
                                    products.RemoveAt(indice);
                                    prices.RemoveAt(indice);
                                    Total = ConsultarCarrito(products, prices); // Se actualiza el total del pedido al finalizar el retiro del producto
                                    break;
                                }
                                catch (FormatException) {
                                    Console.WriteLine("Ingresa un número");
                                }
                            } while (true);

                        } else if (opc2 == 3) {
                            Console.WriteLine("Regresando al menú...");
                            break;
                        } else {
                            Console.WriteLine("No se ha ingresado una opción correcta.");
                            Console.ReadKey();
                        }
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERROR: Ingrese un numero");
                        Console.ReadKey();
                    }
                } while (true);
            }

            static int ConsultarCarrito(List<string> prodcutos, List<int> precios) {
                int totalCarrito = 0;
                for(int i = 0; i < precios.Count; i ++) {
                    Console.WriteLine("{0}) Nombre del producto: {1}  Precio : {2}\n",i, prodcutos[i], precios[i]);
                    totalCarrito += precios[i];
                }
                return totalCarrito;
            }

            void AgregarProducto(List<string> productos, List<int> precios) {
                do {
                    Console.Clear();
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    string producto = Console.ReadLine();
                    productos.Add(producto);

                    do {
                        try {
                            Console.WriteLine("Ahora ingrese el precio de {0}: ", producto);
                            int precio_ingresado = Convert.ToInt32(Console.ReadLine());
                            precios.Add(precio_ingresado);
                            break;

                        }
                        catch (FormatException) {
                            Console.WriteLine("ERROR: Ingresa un valor correcto para el precio.");
                        }
                    } while (true); // Bucle validación de precio

                    Console.WriteLine("{0} agregado correctamete.\nDeseas agregar otro producto al carrito? (S/N): ", producto);
                    char choise = Convert.ToChar(Console.ReadLine());
                    if (choise == 'N' || choise == 'n')
                    {
                        break;
                    }
                    else if (choise == 'S' || choise == 's') {
                        continue;
                    }  else  {
                        Console.WriteLine("ERROR: Ingresa una opción correcta");
                        Console.ReadKey();
                    }
                } while (true);
            } // Fin AgregarProducto
        } // Fin Main
    } // Fin Programa
}
