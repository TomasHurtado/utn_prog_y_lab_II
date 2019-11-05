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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMostraruno_Click(object sender, EventArgs e)
        {
            Accion frm = new Accion();

            frm.Show();

        }

        private void btnMostrardos_Click(object sender, EventArgs e)
        {
            mensaje frm = new mensaje();

            frm.Show();
        }
    }
}
