using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Generics
{
    public partial class frmComercio : Form
    {
        public frmComercio()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(cmbEstanteria.Text=="Producto")
            {
                Estanteria<Producto> estanteria = new Estanteria<Producto>(4);
            }
            else if (cmbEstanteria.Text == "Alimenticio")
            {
                Estanteria<Alimenticio> alimento = new Estanteria<Alimenticio>(4);
            }
            else if (cmbEstanteria.Text == "Ferreteria")
            {
                Estanteria<Ferreteria> ferr = new Estanteria<Ferreteria>(4);
            }
            
        }
    }
}
