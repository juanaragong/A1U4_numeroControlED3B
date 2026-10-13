using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A1U4_numeroControlED3B
{
    internal class Nodo
    {
        public int dato;
        public Nodo Izquierdo=null;
        public Nodo Derecho=null;

        public Nodo(int datito)
        {
            dato = datito;  // Esta asignación es neceseria, sino como toma el dato
            Izquierdo = null;
            Derecho = null;
        }

    }
}
