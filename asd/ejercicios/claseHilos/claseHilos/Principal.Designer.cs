namespace claseHilos
{
    partial class Principal
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
            this.btnMostraruno = new System.Windows.Forms.Button();
            this.btnMostrardos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostraruno
            // 
            this.btnMostraruno.Location = new System.Drawing.Point(113, 59);
            this.btnMostraruno.Name = "btnMostraruno";
            this.btnMostraruno.Size = new System.Drawing.Size(75, 23);
            this.btnMostraruno.TabIndex = 0;
            this.btnMostraruno.Text = "Mostrar1";
            this.btnMostraruno.UseVisualStyleBackColor = true;
            this.btnMostraruno.Click += new System.EventHandler(this.btnMostraruno_Click);
            // 
            // btnMostrardos
            // 
            this.btnMostrardos.Location = new System.Drawing.Point(113, 105);
            this.btnMostrardos.Name = "btnMostrardos";
            this.btnMostrardos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrardos.TabIndex = 1;
            this.btnMostrardos.Text = "Mostrar2";
            this.btnMostrardos.UseVisualStyleBackColor = true;
            this.btnMostrardos.Click += new System.EventHandler(this.btnMostrardos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 297);
            this.Controls.Add(this.btnMostrardos);
            this.Controls.Add(this.btnMostraruno);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostraruno;
        private System.Windows.Forms.Button btnMostrardos;
    }
}

