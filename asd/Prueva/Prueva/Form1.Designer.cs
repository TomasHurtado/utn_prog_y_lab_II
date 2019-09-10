namespace Prueva
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbxProvincias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdtnFemenino = new System.Windows.Forms.RadioButton();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.rdtnOtro = new System.Windows.Forms.RadioButton();
            this.gpbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(144, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(144, 73);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(144, 114);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(278, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(278, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(278, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(147, 312);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(481, 312);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(147, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Vive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbxProvincias
            // 
            this.cmbxProvincias.FormattingEnabled = true;
            this.cmbxProvincias.Location = new System.Drawing.Point(278, 148);
            this.cmbxProvincias.Name = "cmbxProvincias";
            this.cmbxProvincias.Size = new System.Drawing.Size(121, 21);
            this.cmbxProvincias.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Provincia";
            // 
            // rdtnMasculino
            // 
            this.rdtnMasculino.AutoSize = true;
            this.rdtnMasculino.Location = new System.Drawing.Point(0, 38);
            this.rdtnMasculino.Name = "rdtnMasculino";
            this.rdtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdtnMasculino.TabIndex = 14;
            this.rdtnMasculino.TabStop = true;
            this.rdtnMasculino.Text = "Masculino";
            this.rdtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdtnFemenino
            // 
            this.rdtnFemenino.AutoSize = true;
            this.rdtnFemenino.Location = new System.Drawing.Point(97, 38);
            this.rdtnFemenino.Name = "rdtnFemenino";
            this.rdtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdtnFemenino.TabIndex = 15;
            this.rdtnFemenino.TabStop = true;
            this.rdtnFemenino.Text = "Femenino";
            this.rdtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.rdtnOtro);
            this.gpbGenero.Controls.Add(this.rdtnMasculino);
            this.gpbGenero.Controls.Add(this.rdtnFemenino);
            this.gpbGenero.Location = new System.Drawing.Point(147, 214);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(317, 75);
            this.gpbGenero.TabIndex = 16;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Genero";
            // 
            // rdtnOtro
            // 
            this.rdtnOtro.AutoSize = true;
            this.rdtnOtro.Location = new System.Drawing.Point(207, 38);
            this.rdtnOtro.Name = "rdtnOtro";
            this.rdtnOtro.Size = new System.Drawing.Size(45, 17);
            this.rdtnOtro.TabIndex = 16;
            this.rdtnOtro.TabStop = true;
            this.rdtnOtro.Text = "Otro";
            this.rdtnOtro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxProvincias);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Carga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbxProvincias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdtnMasculino;
        private System.Windows.Forms.RadioButton rdtnFemenino;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.RadioButton rdtnOtro;
    }
}

