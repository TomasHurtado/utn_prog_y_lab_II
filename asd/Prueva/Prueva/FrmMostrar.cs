using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueva
{
    public partial class FrmMostrar : Form
    {
        public Persona[] personas;
        public FrmMostrar()
        {
            InitializeComponent();
        }

       

        private void lstPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            for(int i=0;i<personas.Length;i++)
            {
                lstPersona.Items.Add(personas[i].MostrarDatos());

            }
        }
    }
}
