namespace proyectofinalB
{
    partial class UCreserva
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCreserva));
            this.label1 = new System.Windows.Forms.Label();
            this.btnatrasreserva = new System.Windows.Forms.Button();
            this.btncerrardashboard = new System.Windows.Forms.PictureBox();
            this.btnminimizardashboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrardashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizardashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libros Reservados";
            // 
            // btnatrasreserva
            // 
            this.btnatrasreserva.BackColor = System.Drawing.Color.LightSalmon;
            this.btnatrasreserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatrasreserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatrasreserva.Location = new System.Drawing.Point(24, 19);
            this.btnatrasreserva.Name = "btnatrasreserva";
            this.btnatrasreserva.Size = new System.Drawing.Size(75, 38);
            this.btnatrasreserva.TabIndex = 3;
            this.btnatrasreserva.Text = "Atras";
            this.btnatrasreserva.UseVisualStyleBackColor = false;
            this.btnatrasreserva.Click += new System.EventHandler(this.btnatrasreserva_Click);
            // 
            // btncerrardashboard
            // 
            this.btncerrardashboard.Image = ((System.Drawing.Image)(resources.GetObject("btncerrardashboard.Image")));
            this.btncerrardashboard.Location = new System.Drawing.Point(780, 0);
            this.btncerrardashboard.Name = "btncerrardashboard";
            this.btncerrardashboard.Size = new System.Drawing.Size(20, 20);
            this.btncerrardashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrardashboard.TabIndex = 5;
            this.btncerrardashboard.TabStop = false;
            this.btncerrardashboard.Click += new System.EventHandler(this.btncerrardashboard_Click);
            // 
            // btnminimizardashboard
            // 
            this.btnminimizardashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizardashboard.Image")));
            this.btnminimizardashboard.Location = new System.Drawing.Point(754, 0);
            this.btnminimizardashboard.Name = "btnminimizardashboard";
            this.btnminimizardashboard.Size = new System.Drawing.Size(20, 20);
            this.btnminimizardashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizardashboard.TabIndex = 4;
            this.btnminimizardashboard.TabStop = false;
            this.btnminimizardashboard.Click += new System.EventHandler(this.btnminimizardashboard_Click);
            // 
            // UCreserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrardashboard);
            this.Controls.Add(this.btnminimizardashboard);
            this.Controls.Add(this.btnatrasreserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCreserva";
            this.Load += new System.EventHandler(this.UCreserva_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCreserva_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrardashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizardashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnatrasreserva;
        private System.Windows.Forms.PictureBox btncerrardashboard;
        private System.Windows.Forms.PictureBox btnminimizardashboard;
    }
}
