using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimenticio:Producto
    {
        private DateTime vencimiento;

        public Alimenticio(int id_prodcu, string descripcion,DateTime vencimiento):base(id_prodcu,descripcion)
        {
            this.vencimiento = vencimiento;
        }
    }
}
