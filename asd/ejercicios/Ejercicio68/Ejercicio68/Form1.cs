using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        private Persona per; 
        public Form1()
        {
            InitializeComponent();
           
        }
        public void NotificarCambio(string cambio)
        {
            
            MessageBox.Show(cambio);
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            string cambio;
            cambio = "nombre" + per.Nombre + "apellido" + per.Apellido;
            NotificarCambio(cambio);

        }
    }
}
