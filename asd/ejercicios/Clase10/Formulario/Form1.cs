using Clase10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void btnCargar_Click(object sender, EventArgs e)
        {
            if (this.txbNombre.Text != null && this.txbCuit.Text != null)
            {
                switch (cmbTipo.Text)
                {
                    case "Empleado":
                        Persona p;
                        p = new Empleado("asda", 123, 124);
                        this.Personas.Add(p);
                        break;
                    case "Jefe":
                        break;
                    case "Vendedor":
                        break;
                }
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }
    }
}
