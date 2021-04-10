using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    public class ListaProduto
    {

        NodoProducto Head;

        public void Insertar(Producto AñadirProducto)
        {

            NodoProducto NuevoNodoProducto = new NodoProducto();

            NuevoNodoProducto.Producto = AñadirProducto;

            if (Head == null)
            {

                Head = NuevoNodoProducto;

            }
            else
            {

                NodoProducto last = Head;
                while (last.Next != null)
                {

                    last = last.Next;

                }

                last.Next = NuevoNodoProducto;

            }

            


        }


        //INSERTAR PRODUCTO
        public void InsertarDespues(Producto NuevoProducto, Producto Despues)
        {

            NodoProducto tmp = Head;

            while (tmp != null && tmp.Producto != Despues)
            {

                tmp = tmp.Next;

            }

            NodoProducto NuevoNodoProducto = new NodoProducto();
            NuevoNodoProducto.Producto = NuevoProducto;

            NuevoNodoProducto.Next = tmp.Next;
            tmp.Next = NuevoNodoProducto;


        }

        public void Imprimir()
        {
            NodoProducto tmp = Head;

            while (tmp != null)
            {

                Console.WriteLine("El nombre del producto es: " + tmp.Producto.Nombre + 
                                  "  Se vendio en una cantidad de: " + tmp.Producto.Unidades + "  Tiene un precio de unidad de: " + 
                                  tmp.Producto.Precio + "  Su id es: " + tmp.Producto.Id + 
                                  "  Su precio total es: " + tmp.Producto.PrecioPorUnidad());

                tmp = tmp.Next;

            }


        }
    }   
}
