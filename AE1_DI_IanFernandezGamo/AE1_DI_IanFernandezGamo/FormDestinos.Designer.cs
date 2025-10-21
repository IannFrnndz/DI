namespace AE1_DI_IanFernandezGamo
{
    partial class FormDestinos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl11 = new AE1_DI_IanFernandezGamo.UserControl1();
            this.userControl12 = new AE1_DI_IanFernandezGamo.UserControl1();
            this.userControl13 = new AE1_DI_IanFernandezGamo.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Los destinos más visitados";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 104);
            this.userControl11.Mensaje = "Roma";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(333, 164);
            this.userControl11.TabIndex = 1;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(444, 104);
            this.userControl12.Mensaje = "París";
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(327, 160);
            this.userControl12.TabIndex = 2;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(236, 278);
            this.userControl13.Mensaje = "Nueva York";
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(327, 160);
            this.userControl13.TabIndex = 3;
            // 
            // FormDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "FormDestinos";
            this.Text = "FormDestinos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
    }
}