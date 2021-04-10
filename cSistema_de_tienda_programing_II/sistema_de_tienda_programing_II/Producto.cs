using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_tienda_programing_II
{
    public class Producto
    {
        public String Nombre;

        public float Precio;

        public float Unidades = 10;
        
        public String Id;



        public float PrecioPorUnidad()
        {

            return Precio * Unidades;

        }


    }
}
