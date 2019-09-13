using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    public class Estante
    {
        private int ubicacionestante;
        private Producto[] producto;

        private Estante(int capacidad)
        {

            producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionestante = ubicacion;
        }

        public Producto[] GetProducto()
        {

            return this.producto;
        }

        public string MotrarEstante(Estante est)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("estantes: {0}", est.ubicacionestante);
            foreach (Producto prod in est.producto)
            {
                sb.AppendLine(Producto.MostrarProducto(prod));//Producto.mostrar
            }

            return sb.ToString();
        }

        public static bool operator ==(Producto producto, Estante estante)
        {

            if (!(producto is null) && estante != null)
            {
                foreach (Producto produc in estante.producto)
                {
                    if (produc == producto)
                    {
                        return true;
                    }

                }
            }

            return false;
        }

        public static bool operator !=(Producto producto, Estante estante)
        {
            return !(producto == estante);
        }


        public static bool operator +(Producto producto, Estante estante)
        {
          
            if (!(estante is null) && producto != estante )
            {
                for (int i = 0; i > estante.producto.Length; i++)
                    if (estante.producto[i] is null )
                    {
                        estante.producto[i] = producto;
                    }
            }

            return false;
        }

        public static bool operator -(Producto producto, Estante estante)
        {

            if (!(estante is null) && producto == estante)
            {
                for (int i = 0; i > estante.producto.Length; i++)
                    if (estante.producto[i] is null)
                    {
                        estante.producto[i] = null;
                    }
            }

            return false;
        }





    }
}
