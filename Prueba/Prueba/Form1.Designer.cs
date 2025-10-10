namespace Prueba
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
            this.btnHola = new System.Windows.Forms.Button();
            this.lblSaludos = new System.Windows.Forms.Label();
            this.userControl12 = new Prueba.UserControl1();
            this.userControl11 = new Prueba.UserControl1();
            this.SuspendLayout();
            // 
            // btnHola
            // 
            this.btnHola.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHola.Location = new System.Drawing.Point(223, 142);
            this.btnHola.Name = "btnHola";
            this.btnHola.Size = new System.Drawing.Size(129, 83);
            this.btnHola.TabIndex = 0;
            this.btnHola.Text = "Saludo";
            this.btnHola.UseVisualStyleBackColor = false;
            this.btnHola.Click += new System.EventHandler(this.btnHola_Click);
            // 
            // lblSaludos
            // 
            this.lblSaludos.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaludos.Location = new System.Drawing.Point(151, 54);
            this.lblSaludos.Name = "lblSaludos";
            this.lblSaludos.Size = new System.Drawing.Size(201, 38);
            this.lblSaludos.TabIndex = 1;
            this.lblSaludos.Text = "Ventana de saludos";
            this.lblSaludos.Click += new System.EventHandler(this.label1_Click);
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl12.Location = new System.Drawing.Point(409, 67);
            this.userControl12.Mensaje = null;
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(311, 130);
            this.userControl12.TabIndex = 3;
            this.userControl12.Load += new System.EventHandler(this.userControl12_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControl11.Location = new System.Drawing.Point(141, 276);
            this.userControl11.Mensaje = "Hola mundo";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(308, 123);
            this.userControl11.TabIndex = 2;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.lblSaludos);
            this.Controls.Add(this.btnHola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHola;
        private System.Windows.Forms.Label lblSaludos;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

