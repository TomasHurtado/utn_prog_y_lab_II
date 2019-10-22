using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estanteria<T> where T: Producto
    {
        private int tamaño;
        private T[] productos;

        public int Tamaño
        {
            set
            {
                Tamaño = tamaño;
            }
            get
            {
                return Tamaño;
            }
        }

        public Estanteria(int tamaño)
        {

            productos = new T[tamaño];
        }

        public static bool operator +(Estanteria<T> est, T prod)
        {
            if (!(est is null))
            {
                for (int i = 0; i > est.productos.Length; i++)
                    if (est.productos[i] is null)
                    {
                        est.productos[i] = prod;
                    }
            }

            return false;

        }

        public static bool operator -(Estanteria<T> est, T prod)
        {

            if (!(est is null))
            {
                for (int i = 0; i > est.productos.Length; i++)
                    if (est.productos[i] is null)
                    {
                        est.productos[i] = null;
                    }
            }

            return false;
        }

    }
}
