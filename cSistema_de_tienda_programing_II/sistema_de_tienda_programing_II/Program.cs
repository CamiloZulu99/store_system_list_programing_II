using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    public class Program
    {
        static void Main(string[] args)
        {

            //
            ListaProduto ListaProductos = new ListaProduto();

            Producto Pro1 = new Producto();

            Pro1.Nombre = "Arroz";
            Pro1.Id = "01";
            Pro1.Precio = 1500;
            Pro1.Unidades = 10;
            Pro1.PrecioPorUnidad();
            ListaProductos.Insertar(Pro1);


            Producto Pro2 = new Producto();

            Pro2.Nombre = "Frijol";
            Pro2.Id = "02";
            Pro2.Precio = 900;
            Pro2.Unidades = 1;
            Pro2.PrecioPorUnidad();
            ListaProductos.Insertar(Pro2);


            Producto Pro3 = new Producto();

            Pro3.Nombre = "Leche";
            Pro3.Id = "03";
            Pro3.Precio = 2000;
            Pro3.Unidades = 2;
            Pro3.PrecioPorUnidad();
            ListaProductos.Insertar(Pro3);


            Producto Pro4 = new Producto();

            Pro4.Nombre = "Cafe";
            Pro4.Id = "04";
            Pro4.Precio = 2300;
            Pro4.Unidades = 6;
            Pro4.PrecioPorUnidad();
            ListaProductos.Insertar(Pro4);
            //

            //
            ListaCliente ListaClientes = new ListaCliente();

            Cliente Cli1 = new Cliente();

            Cli1.Nombre = "Camilo";
            Cli1.Producto = Pro2 ;
            Cli1.Producto = Pro4;
            ListaClientes.Insertar(Cli1);


            Cliente Cli2 = new Cliente();

            Cli2.Nombre = "Karyn";
            Cli2.Producto = Pro1;
            Cli2.Producto = Pro4;
            ListaClientes.Insertar(Cli2);


            Cliente Cli3 = new Cliente();

            Cli3.Nombre = "Camilo";
            Cli3.Producto = Pro1;
            Cli3.Producto = Pro2;
            Cli3.Producto = Pro3;
            Cli3.Producto = Pro4;
            ListaClientes.Insertar(Cli3);
            //


            //
            ListaVenta ListaVentas = new ListaVenta();

            Ventas Ven1 = new Ventas();

            Ven1.AñadirCliente(Cli1);
            Ven1.AñadirProducto(Pro2);
            Ven1.AñadirProducto(Pro4);
            ListaVentas.Insertar(Ven1);



            Ventas Ven2 = new Ventas();

            Ven2.AñadirCliente(Cli2);
            Ven2.AñadirProducto(Pro1);
            Ven2.AñadirProducto(Pro4);
            ListaVentas.Insertar(Ven2);


            Ventas Ven3 = new Ventas();

            Ven3.AñadirCliente(Cli3);
            Ven3.AñadirProducto(Pro1);
            Ven3.AñadirProducto(Pro4);
            Ven3.AñadirProducto(Pro3);
            Ven3.AñadirProducto(Pro2);
            ListaVentas.Insertar(Ven3);
            //

            Console.WriteLine("--------LAS VENTAS QUE SE GENERARON FUERON----------");
            ListaVentas.Imprimir();


            Console.WriteLine("--------LOS CLIENTES QUE INGRESARON FUERON----------");
            ListaClientes.Imprimir();


            Console.WriteLine("--------LAS PRODUCTOS QUE SE VENDIERON FUERON----------");
            ListaProductos.Imprimir();

            float Ventastotales = Pro1.PrecioPorUnidad() + Pro2.PrecioPorUnidad() + Pro3.PrecioPorUnidad() + Pro4.PrecioPorUnidad();

            Console.WriteLine("El toal de la suma de las ventas es : " + Ventastotales + "$");

            float MediaVentastotales = (Pro1.PrecioPorUnidad() + Pro2.PrecioPorUnidad() +
                                        Pro3.PrecioPorUnidad() + Pro4.PrecioPorUnidad()) / (4);

            Console.WriteLine("La media del precio total de las ventas es :  " + MediaVentastotales + "$");


            Console.WriteLine("NOTA:NO FUI CAPAZ DE IMPRIMIR LA LISTA DE LAS VENTAS, NO ENCONTRE EL ERROR");

            Console.WriteLine("--------EJEMPLO DE INSERTAR----------");
            ListaProductos.InsertarDespues(Pro4 , Pro1);



            Console.ReadKey();









        }
    }
}
