using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Estanteria<Producto> estan = new Estanteria<Producto>(5);
            Estanteria<Alimenticio> alim = new Estanteria<Alimenticio>(5);
            Estanteria<Ferreteria> ferr = new Estanteria<Ferreteria>(5);



            Ferreteria ferreteria = new Ferreteria(1,"martillo",5);

        }
    }
}
