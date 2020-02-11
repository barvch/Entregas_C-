using System;
using System.Collections.Generic;
using System.Text;

namespace _14_inferfaz
{
    interface IComer {
        /*Muchos seres vivos pueden comer, pero no todos lo hacen la misma manera ni comen lo mismo*/
        string Comer(); // Se define le método de Comer, que es el que compartirán todas las clases
    }
}
