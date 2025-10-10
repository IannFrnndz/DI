namespace DI_A1._8Simulacro
{
    partial class FormCarta
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
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(29, 33);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(180, 43);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "🍽️ Comidas";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(379, 33);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(174, 43);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "🍹 Bebidas";
            this.lblB.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 323);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Margarita\n\nHamburguesa Clásica\n\nEnsalada César\n\nTacos al Pastor\n\nPasta Carb" +
    "onara\n\nSushi de Salmón\n\nPollo al Horno\n\nLasagna de Carne\n\nEmpanadas de Queso\n\nSo" +
    "pa de Tomate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 323);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agua Mineral\n\nCafé Americano\n\nTé Verde\n\nJugo de Naranja\n\nLimonada Natural\n\nRefres" +
    "co de Cola\n\nBatido de Fresa\n\nCerveza Artesanal\n\nVino Tinto\n\nChocolate Caliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carta";
            // 
            // FormCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormCarta";
            this.Text = "FormCarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}