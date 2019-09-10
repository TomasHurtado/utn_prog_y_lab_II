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
    public partial class Form1 : Form
    {
        public Persona[] personas;


        public Form1()
        {
            InitializeComponent();
            personas = new Persona[3];
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
            
                int dni;
                if (int.TryParse(this.txtDni.Text, out dni))
                {
                    Persona unaPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, dni);
                    for (int i = 0; i < personas.Length; i++)
                    {
                        if (personas[i] == null)
                        {
                            personas[i] = unaPersona;
                            break;
                        }
                    }

                } else
                {
                    MessageBox.Show("DNI invalido");
                }
                Limpiar();
            
            
        }

        public void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtDni.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrar mostar = new FrmMostrar();
            mostar.personas = this.personas;
            mostar.Show();
        }
    }
}
