using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    public class Producto
    {
        private string codigodebarra;
        private string marca;
        private double precio;


        public string GetMarcar(string marca)
        {

            return marca = this.marca;
        }

        public double GetPrecio(double precio)
        {
            return precio = this.precio;

        }

        public static  string MostrarProducto(Producto producto)
        {
            return string.Format("EL codigo de barra es:{0}  la marca es: {1} el precio es: {2}",producto.codigodebarra,producto.marca,producto.precio);
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigodebarra;
        }


        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool hola;
            if(producto1.codigodebarra==producto2.codigodebarra && producto1.marca==producto2.marca)
            {
                hola = true;

            }
            else
            {
                hola = false;
            }

           return hola;    
        }


        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1== producto2);
        }



        public static bool operator ==(Producto producto1,string marca)
        {
            bool hola;

            if(producto1.marca==marca)
            {
                hola = true;
            }
            else
            {
                hola = false;
            }

            return hola;
        }


        public static bool operator !=(Producto producto1, string marca)
        {
            return !(producto1.marca == marca);
        }

    }
}
