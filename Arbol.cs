using System;
using System.Collections.Generic;
using System.Drawing;//Agregar esta clase
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1U4_numeroControlED3B
{
    internal class Arbol
    {
        public Nodo Raiz;
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (Raiz == null)
            {
                Raiz = nuevo;
                return;
            }

            Nodo auxiliar = Raiz;

            while (true)
            {
                if (dato < auxiliar.dato)
                {
                    if (auxiliar.Izquierdo == null)
                    {
                        auxiliar.Izquierdo = nuevo;
                        break;
                    }

                    auxiliar = auxiliar.Izquierdo;
                }
                else if (dato > auxiliar.dato)
                {
                    if (auxiliar.Derecho == null)
                    {
                        auxiliar.Derecho = nuevo;
                        break;
                    }

                    auxiliar = auxiliar.Derecho;
                }
                else
                {
                    break; // Dato repetido
                }
            }
        }

        #region Metodo Dibujar Arbol
        public void Dibujar(Graphics g, int ancho)
        {
            if (Raiz == null)
                return;

            Queue<(Nodo nodo, int x, int y, int espacio)> cola =
                new Queue<(Nodo, int, int, int)>();

            cola.Enqueue((Raiz, ancho / 2, 40, ancho / 4));

            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();

                int x = actual.x;
                int y = actual.y;
                int espacio = actual.espacio;

                // Hijo izquierdo
                if (actual.nodo.Izquierdo != null)
                {
                    int hijoX = x - espacio;
                    int hijoY = y + 75;

                    g.DrawLine(Pens.Black, x, y, hijoX, hijoY);

                    cola.Enqueue((actual.nodo.Izquierdo,
                        hijoX, hijoY, Math.Max(20, espacio / 2)));
                }

                // Hijo derecho
                if (actual.nodo.Derecho != null)
                {
                    int hijoX = x + espacio;
                    int hijoY = y + 75;

                    g.DrawLine(Pens.Black, x, y, hijoX, hijoY);

                    cola.Enqueue((actual.nodo.Derecho,
                        hijoX, hijoY, Math.Max(20, espacio / 2)));
                }

                // Dibujar círculo
                g.FillEllipse(Brushes.Maroon,
                    x - 20, y - 20, 40, 40);

                g.DrawEllipse(Pens.Black,
                    x - 20, y - 20, 40, 40);

                // Dibujar número
                using (Font fuente = new Font("Arial", 11,
                                             FontStyle.Bold))
                using (StringFormat formato = new StringFormat())
                {
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;

                    g.DrawString(actual.nodo.dato.ToString(),
                        fuente, Brushes.White,
                        new RectangleF(x - 20, y - 20, 40, 40),
                        formato);
                }
            }
        }

        #endregion

    }
}
