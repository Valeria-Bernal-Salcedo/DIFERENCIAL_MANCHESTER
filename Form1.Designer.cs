namespace DIFERENCIAL_MANCHESTER
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
            this.signal = new System.Windows.Forms.TextBox();
            this.GRAFICAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.difManchester = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.difManchester)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEÑAL A GRAFICAR:";
            // 
            // signal
            // 
            this.signal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signal.Location = new System.Drawing.Point(474, 100);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(290, 35);
            this.signal.TabIndex = 2;
            this.signal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GRAFICAR
            // 
            this.GRAFICAR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAFICAR.Location = new System.Drawing.Point(835, 100);
            this.GRAFICAR.Name = "GRAFICAR";
            this.GRAFICAR.Size = new System.Drawing.Size(277, 58);
            this.GRAFICAR.TabIndex = 3;
            this.GRAFICAR.Text = "GRAFICAR";
            this.GRAFICAR.UseVisualStyleBackColor = true;
            this.GRAFICAR.Click += new System.EventHandler(this.GRAFICAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "SEÑAL DIFERENCIAL MANCHESTER";
            // 
            // difManchester
            // 
            this.difManchester.Location = new System.Drawing.Point(58, 203);
            this.difManchester.Name = "difManchester";
            this.difManchester.Size = new System.Drawing.Size(1137, 253);
            this.difManchester.TabIndex = 8;
            this.difManchester.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 723);
            this.Controls.Add(this.difManchester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GRAFICAR);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.difManchester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.Button GRAFICAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox difManchester;
    }
}

