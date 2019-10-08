namespace FormsSistemaSolar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregarSat = new System.Windows.Forms.Button();
            this.btnAgregarPla = new System.Windows.Forms.Button();
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.OrbitaPLaneta = new System.Windows.Forms.TextBox();
            this.numRotaPlaneta = new System.Windows.Forms.NumericUpDown();
            this.numLunas = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatel = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatel = new System.Windows.Forms.NumericUpDown();
            this.cmbPLaneta = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotaPlaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar rotecion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de planete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Planeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en comlpetar la orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en completar la rotacion";
            // 
            // btnAgregarSat
            // 
            this.btnAgregarSat.Location = new System.Drawing.Point(330, 229);
            this.btnAgregarSat.Name = "btnAgregarSat";
            this.btnAgregarSat.Size = new System.Drawing.Size(283, 30);
            this.btnAgregarSat.TabIndex = 9;
            this.btnAgregarSat.Text = "Agregar Satelite";
            this.btnAgregarSat.UseVisualStyleBackColor = true;
            this.btnAgregarSat.Click += new System.EventHandler(this.btnAgregarSat_Click);
            // 
            // btnAgregarPla
            // 
            this.btnAgregarPla.Location = new System.Drawing.Point(32, 229);
            this.btnAgregarPla.Name = "btnAgregarPla";
            this.btnAgregarPla.Size = new System.Drawing.Size(283, 30);
            this.btnAgregarPla.TabIndex = 10;
            this.btnAgregarPla.Text = "Agregar planeta";
            this.btnAgregarPla.UseVisualStyleBackColor = true;
            this.btnAgregarPla.Click += new System.EventHandler(this.btnAgregarPla_Click);
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(167, 265);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(283, 30);
            this.btnMostar.TabIndex = 11;
            this.btnMostar.Text = "Mostrar informacion";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(167, 300);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(283, 30);
            this.btnMover.TabIndex = 12;
            this.btnMover.Text = "Mover Astros";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(181, 38);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePlaneta.TabIndex = 13;
            // 
            // OrbitaPLaneta
            // 
            this.OrbitaPLaneta.Location = new System.Drawing.Point(181, 75);
            this.OrbitaPLaneta.Name = "OrbitaPLaneta";
            this.OrbitaPLaneta.Size = new System.Drawing.Size(100, 20);
            this.OrbitaPLaneta.TabIndex = 14;
            // 
            // numRotaPlaneta
            // 
            this.numRotaPlaneta.Location = new System.Drawing.Point(181, 114);
            this.numRotaPlaneta.Name = "numRotaPlaneta";
            this.numRotaPlaneta.Size = new System.Drawing.Size(120, 20);
            this.numRotaPlaneta.TabIndex = 15;
            // 
            // numLunas
            // 
            this.numLunas.Location = new System.Drawing.Point(181, 151);
            this.numLunas.Name = "numLunas";
            this.numLunas.Size = new System.Drawing.Size(120, 20);
            this.numLunas.TabIndex = 16;
            // 
            // numOrbitaSatel
            // 
            this.numOrbitaSatel.Location = new System.Drawing.Point(492, 107);
            this.numOrbitaSatel.Name = "numOrbitaSatel";
            this.numOrbitaSatel.Size = new System.Drawing.Size(120, 20);
            this.numOrbitaSatel.TabIndex = 17;
            // 
            // numRotacionSatel
            // 
            this.numRotacionSatel.Location = new System.Drawing.Point(492, 150);
            this.numRotacionSatel.Name = "numRotacionSatel";
            this.numRotacionSatel.Size = new System.Drawing.Size(120, 20);
            this.numRotacionSatel.TabIndex = 18;
            // 
            // cmbPLaneta
            // 
            this.cmbPLaneta.FormattingEnabled = true;
            this.cmbPLaneta.Location = new System.Drawing.Point(492, 29);
            this.cmbPLaneta.Name = "cmbPLaneta";
            this.cmbPLaneta.Size = new System.Drawing.Size(121, 21);
            this.cmbPLaneta.TabIndex = 19;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(181, 189);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 20;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(492, 67);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSatelite.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(644, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 318);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 342);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPLaneta);
            this.Controls.Add(this.numRotacionSatel);
            this.Controls.Add(this.numOrbitaSatel);
            this.Controls.Add(this.numLunas);
            this.Controls.Add(this.numRotaPlaneta);
            this.Controls.Add(this.OrbitaPLaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.btnAgregarPla);
            this.Controls.Add(this.btnAgregarSat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tomas Hurtado";
            ((System.ComponentModel.ISupportInitialize)(this.numRotaPlaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarSat;
        private System.Windows.Forms.Button btnAgregarPla;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox OrbitaPLaneta;
        private System.Windows.Forms.NumericUpDown numRotaPlaneta;
        private System.Windows.Forms.NumericUpDown numLunas;
        private System.Windows.Forms.NumericUpDown numOrbitaSatel;
        private System.Windows.Forms.NumericUpDown numRotacionSatel;
        private System.Windows.Forms.ComboBox cmbPLaneta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

