using System;

namespace _6_CuentaBancaria {
    class Program {
        static void Main(string[] args) {

            // Se crean los objetos
            CuentaBancaria persona1 = new CuentaBancaria("Omar", 6000);
            CuentaBancaria persona2 = new CuentaBancaria("Rodrigo", 70000);

            // Se llaman sus métodos
            persona1.mostrarInformacion();
            persona1.retiro(3000);
            persona1.deposito(2500);

            persona2.mostrarInformacion();
            persona2.retiro(72000);
            persona2.deposito(5000);

            Console.WriteLine("Fin del programa\n");
            Console.ReadKey();
        }
    }

    class CuentaBancaria {

        // Atributos

        public string Nombre;
        public long Saldo;

        // Constructor 

        public CuentaBancaria(string nombre, long saldo) {
            Nombre = nombre;
            Saldo = saldo;
        }

        //Métodos

        public void mostrarInformacion() {
            Console.WriteLine("Datos de la cuenta:\nNombre : {0}\nSaldo : {1}\n", Nombre, Saldo);
        }

        public void deposito(long cantDepositar) {
            Console.WriteLine("Saldo anterior al depósito: {0}", Saldo);
            Saldo += cantDepositar;
            Console.WriteLine("Se han depositado {0} a la cuenta.", cantDepositar);
            Console.WriteLine("Saldo actualizado: {0}\n", Saldo);
        }

        public void retiro(long cantRetirar) {
            if (cantRetirar > Saldo) { // Si se desea retirar más saldo del que se tiene actualmente
                Console.WriteLine("Saldo insuficiente para realizar la transacción. ({0})\n Saldo actual: {1}", cantRetirar, Saldo);
            } else {
                Console.WriteLine("Se han retirado {0} satisfactoriamente a la cuenta.\n", cantRetirar);
                Saldo -= cantRetirar;
                Console.WriteLine("Nuevo saldo: {0}\n", Saldo);
            }
        }
    }
}
