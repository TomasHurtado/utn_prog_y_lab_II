namespace claseHilos
{
    partial class Accion
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
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtAccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(115, 114);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "button1";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // txtAccion
            // 
            this.txtAccion.Location = new System.Drawing.Point(104, 79);
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.Size = new System.Drawing.Size(100, 20);
            this.txtAccion.TabIndex = 1;
            // 
            // Accion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 194);
            this.Controls.Add(this.txtAccion);
            this.Controls.Add(this.btnAccion);
            this.Name = "Accion";
            this.Text = "Accion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.TextBox txtAccion;
    }
}