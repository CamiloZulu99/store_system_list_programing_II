using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    class ListaCliente
    {

        NodoCliente Head;

        public void Insertar(Cliente AñadirCliente)
        {

            NodoCliente NuevoNodoCliente = new NodoCliente();

            NuevoNodoCliente.Cliente = AñadirCliente;

            if (Head == null)
            {

                Head = NuevoNodoCliente;

            }
            else
            {

                NodoCliente last = Head;
                while (last.Next != null)
                {

                    last = last.Next;

                }

                last.Next = NuevoNodoCliente;

            }




        }


        //INSERTAR CLIENTE
        public void InsertarDespues (Cliente NuevoCliente, Cliente Despues)
        {

            NodoCliente tmp = Head;

            while(tmp != null && tmp.Cliente != Despues)
            {

                tmp = tmp.Next;

            }

            NodoCliente NuevoNodoCliente = new NodoCliente();
            NuevoNodoCliente.Cliente = NuevoCliente;

            NuevoNodoCliente.Next = tmp.Next;
            tmp.Next = NuevoNodoCliente;


        }



        public void Imprimir()
        {
            NodoCliente tmp = Head;

            while (tmp != null)
            {

                Console.WriteLine("El nombre del cliente es: " + tmp.Cliente.Nombre );

                tmp = tmp.Next;

            }


        }

    }
}
