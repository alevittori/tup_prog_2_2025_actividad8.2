namespace Ejercicio1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lsbVer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.tbImporte);
            this.groupBox1.Controls.Add(this.dtpVencimiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(39, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbVer);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Controls.Add(this.btnImportar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Location = new System.Drawing.Point(41, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vistas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(190, 50);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(148, 22);
            this.tbPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Importe";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(190, 95);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(148, 22);
            this.dtpVencimiento.TabIndex = 7;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(190, 150);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 22);
            this.tbImporte.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(561, 53);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(136, 47);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(561, 37);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 47);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(561, 109);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(136, 47);
            this.btnImportar.TabIndex = 11;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(561, 181);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(136, 47);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // lsbVer
            // 
            this.lsbVer.FormattingEnabled = true;
            this.lsbVer.ItemHeight = 16;
            this.lsbVer.Location = new System.Drawing.Point(19, 37);
            this.lsbVer.Name = "lsbVer";
            this.lsbVer.Size = new System.Drawing.Size(503, 180);
            this.lsbVer.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lsbVer;
    }
}

