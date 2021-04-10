using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    class ListaVenta
    {

        NodoVentas Head;

        public void Insertar(Ventas AñadirVenta)
        {

            NodoVentas NuevoNodoVenta = new NodoVentas();

            NuevoNodoVenta.Ventas = AñadirVenta;

            if (Head == null)
            {

                Head = NuevoNodoVenta;

            }
            else
            {

                NodoVentas last = Head;
                while (last.Next != null)
                {

                    last = last.Next;

                }

                last.Next = NuevoNodoVenta;

            }




        }


        //INSERTAR VENTA
        public void InsertarDespues(Ventas NuevoCliente, Ventas Despues)
        {

            NodoVentas tmp = Head;

            while (tmp != null && tmp.Ventas != Despues)
            {

                tmp = tmp.Next;

            }

            NodoVentas NuevoNodoVenta = new NodoVentas();
            NuevoNodoVenta.Ventas = NuevoCliente;

            NuevoNodoVenta.Next = tmp.Next;
            tmp.Next = NuevoNodoVenta;


        }

        public void Imprimir()
        {
            NodoVentas tmp = Head;

            while (tmp != null)
            {

                Console.WriteLine("El cliente es " + tmp.Ventas.Clientes + "  Y compro: " + tmp.Ventas.Productos);

                tmp = tmp.Next;

            }

        }
    }
}
