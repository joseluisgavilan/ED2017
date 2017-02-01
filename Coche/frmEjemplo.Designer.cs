namespace Coche
{
    partial class frmEjemplo
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.bttCrear = new System.Windows.Forms.Button();
            this.udVelocidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAlerta = new System.Windows.Forms.GroupBox();
            this.bttComprueba = new System.Windows.Forms.Button();
            this.nUDLimite = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCoche = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.udVelocidad)).BeginInit();
            this.gbAlerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLimite)).BeginInit();
            this.gbCoche.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca del coche:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(107, 19);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(120, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // bttCrear
            // 
            this.bttCrear.Location = new System.Drawing.Point(247, 19);
            this.bttCrear.Name = "bttCrear";
            this.bttCrear.Size = new System.Drawing.Size(151, 61);
            this.bttCrear.TabIndex = 2;
            this.bttCrear.Text = "Crear";
            this.bttCrear.UseVisualStyleBackColor = true;
            this.bttCrear.Click += new System.EventHandler(this.bttCrear_Click);
            // 
            // udVelocidad
            // 
            this.udVelocidad.Location = new System.Drawing.Point(107, 45);
            this.udVelocidad.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.udVelocidad.Name = "udVelocidad";
            this.udVelocidad.Size = new System.Drawing.Size(120, 20);
            this.udVelocidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Velocidad del coche";
            // 
            // gbAlerta
            // 
            this.gbAlerta.Controls.Add(this.bttComprueba);
            this.gbAlerta.Controls.Add(this.nUDLimite);
            this.gbAlerta.Controls.Add(this.label3);
            this.gbAlerta.Enabled = false;
            this.gbAlerta.Location = new System.Drawing.Point(24, 134);
            this.gbAlerta.Name = "gbAlerta";
            this.gbAlerta.Size = new System.Drawing.Size(404, 100);
            this.gbAlerta.TabIndex = 5;
            this.gbAlerta.TabStop = false;
            this.gbAlerta.Text = "Alertas";
            // 
            // bttComprueba
            // 
            this.bttComprueba.Location = new System.Drawing.Point(317, 31);
            this.bttComprueba.Name = "bttComprueba";
            this.bttComprueba.Size = new System.Drawing.Size(75, 23);
            this.bttComprueba.TabIndex = 2;
            this.bttComprueba.Text = "Comprueba";
            this.bttComprueba.UseVisualStyleBackColor = true;
            this.bttComprueba.Click += new System.EventHandler(this.bttComprueba_Click);
            // 
            // nUDLimite
            // 
            this.nUDLimite.Location = new System.Drawing.Point(169, 31);
            this.nUDLimite.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nUDLimite.Name = "nUDLimite";
            this.nUDLimite.Size = new System.Drawing.Size(120, 20);
            this.nUDLimite.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Elige el límite de velocidad";
            // 
            // gbCoche
            // 
            this.gbCoche.Controls.Add(this.txtMarca);
            this.gbCoche.Controls.Add(this.udVelocidad);
            this.gbCoche.Controls.Add(this.label1);
            this.gbCoche.Controls.Add(this.label2);
            this.gbCoche.Controls.Add(this.bttCrear);
            this.gbCoche.Location = new System.Drawing.Point(24, 28);
            this.gbCoche.Name = "gbCoche";
            this.gbCoche.Size = new System.Drawing.Size(404, 100);
            this.gbCoche.TabIndex = 6;
            this.gbCoche.TabStop = false;
            this.gbCoche.Text = "Coche";
            // 
            // frmEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.gbCoche);
            this.Controls.Add(this.gbAlerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEjemplo";
            this.Text = "AppEjemplo";
            this.Load += new System.EventHandler(this.frmEjemplo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udVelocidad)).EndInit();
            this.gbAlerta.ResumeLayout(false);
            this.gbAlerta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLimite)).EndInit();
            this.gbCoche.ResumeLayout(false);
            this.gbCoche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button bttCrear;
        private System.Windows.Forms.NumericUpDown udVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAlerta;
        private System.Windows.Forms.GroupBox gbCoche;
        private System.Windows.Forms.Button bttComprueba;
        private System.Windows.Forms.NumericUpDown nUDLimite;
        private System.Windows.Forms.Label label3;
    }
}

