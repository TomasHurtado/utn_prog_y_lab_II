namespace Forms
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
            this.lstbTexto = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Mensaje = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtbMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbTexto
            // 
            this.lstbTexto.FormattingEnabled = true;
            this.lstbTexto.Location = new System.Drawing.Point(49, 12);
            this.lstbTexto.Name = "lstbTexto";
            this.lstbTexto.Size = new System.Drawing.Size(349, 199);
            this.lstbTexto.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(425, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(425, 227);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(64, 227);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(238, 227);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(47, 13);
            this.Mensaje.TabIndex = 4;
            this.Mensaje.Text = "Mensaje";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(49, 258);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtbMensaje
            // 
            this.txtbMensaje.Location = new System.Drawing.Point(241, 258);
            this.txtbMensaje.Name = "txtbMensaje";
            this.txtbMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtbMensaje.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 290);
            this.Controls.Add(this.txtbMensaje);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbTexto;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtbMensaje;
    }
}

