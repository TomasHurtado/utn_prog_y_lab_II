using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseHilos
{
    public delegate void msaje(string mensaje);
    public partial class Accion : Form
    {
        public event msaje enviarMensaje;
        public Accion()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            enviarMensaje.Invoke(this.txtAccion.Text);
        }
    }
}
