namespace Formulario
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.mtxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.rtxtConsola = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(213, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(33, 100);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo";
            // 
            // mtxtLegajo
            // 
            this.mtxtLegajo.Location = new System.Drawing.Point(213, 100);
            this.mtxtLegajo.Name = "mtxtLegajo";
            this.mtxtLegajo.Size = new System.Drawing.Size(100, 20);
            this.mtxtLegajo.TabIndex = 5;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(33, 135);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(213, 126);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(121, 21);
            this.cmbPuesto.TabIndex = 7;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(36, 166);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 13);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Ganancia";
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(213, 166);
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(100, 20);
            this.mtxtSalario.TabIndex = 9;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(36, 221);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresa.TabIndex = 10;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(143, 222);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarForm.TabIndex = 11;
            this.btnLimpiarForm.Text = "Limpiar";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(237, 221);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 12;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // rtxtConsola
            // 
            this.rtxtConsola.Location = new System.Drawing.Point(2, 263);
            this.rtxtConsola.Name = "rtxtConsola";
            this.rtxtConsola.Size = new System.Drawing.Size(360, 115);
            this.rtxtConsola.TabIndex = 13;
            this.rtxtConsola.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 390);
            this.Controls.Add(this.rtxtConsola);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.mtxtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.MaskedTextBox mtxtLegajo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.MaskedTextBox mtxtSalario;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.RichTextBox rtxtConsola;
    }
}

