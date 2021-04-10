using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    class Ventas
    {




        public Cliente[] Clientes = new Cliente[5];

        public Producto[] Productos = new Producto[5];

        public int ContadorProducto = 0;

        public int ContadorClientes = 0;


        public void AñadirProducto(Producto newProductos)
        {

            Productos[ContadorProducto] = newProductos;

            ContadorProducto++;

            //if(ContadorProducto == 0)
            //{

            //    Console.WriteLine("No hay mas productos disponibles");

            //}

        }

        public void AñadirCliente(Cliente newVCliente)
        {

            Clientes[ContadorClientes] = newVCliente;

            ContadorClientes++;

        }


    }
}
