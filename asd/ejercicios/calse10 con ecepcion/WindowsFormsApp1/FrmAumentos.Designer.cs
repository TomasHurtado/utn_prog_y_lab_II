﻿namespace WindowsFormsApp1
{
    partial class FrmAumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAumentar = new System.Windows.Forms.Button();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lstNomina = new System.Windows.Forms.ListBox();
            this.btnagregar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(323, 41);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 0;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(12, 41);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(132, 20);
            this.txtPorcentaje.TabIndex = 2;
            // 
            // lstNomina
            // 
            this.lstNomina.FormattingEnabled = true;
            this.lstNomina.Location = new System.Drawing.Point(12, 82);
            this.lstNomina.Name = "lstNomina";
            this.lstNomina.Size = new System.Drawing.Size(386, 251);
            this.lstNomina.TabIndex = 3;
            // 
            // btnagregar2
            // 
            this.btnagregar2.Location = new System.Drawing.Point(336, 339);
            this.btnagregar2.Name = "btnagregar2";
            this.btnagregar2.Size = new System.Drawing.Size(75, 23);
            this.btnagregar2.TabIndex = 4;
            this.btnagregar2.Text = "Agregar";
            this.btnagregar2.UseVisualStyleBackColor = true;
            this.btnagregar2.Click += new System.EventHandler(this.btnagregar2_Click);
            // 
            // FrmAumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 362);
            this.Controls.Add(this.btnagregar2);
            this.Controls.Add(this.lstNomina);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.btnAumentar);
            this.Name = "FrmAumentos";
            this.Text = "FrmAumentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.ListBox lstNomina;
        private System.Windows.Forms.Button btnagregar2;
    }
}