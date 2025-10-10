namespace DI_A1._9
{
    partial class FormularioPrincipal
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
            this.datosUsuarioControl1 = new DI_A1._9.DatosUsuarioControl();
            this.btnAbrirForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datosUsuarioControl1
            // 
            this.datosUsuarioControl1.Location = new System.Drawing.Point(279, 12);
            this.datosUsuarioControl1.Name = "datosUsuarioControl1";
            this.datosUsuarioControl1.Size = new System.Drawing.Size(246, 234);
            this.datosUsuarioControl1.TabIndex = 0;
            this.datosUsuarioControl1.Load += new System.EventHandler(this.datosUsuarioControl1_Load);
            // 
            // btnAbrirForm
            // 
            this.btnAbrirForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirForm.Location = new System.Drawing.Point(279, 293);
            this.btnAbrirForm.Name = "btnAbrirForm";
            this.btnAbrirForm.Size = new System.Drawing.Size(254, 65);
            this.btnAbrirForm.TabIndex = 1;
            this.btnAbrirForm.Text = "Abrir Formulario Secundario";
            this.btnAbrirForm.UseVisualStyleBackColor = true;
            this.btnAbrirForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirForm);
            this.Controls.Add(this.datosUsuarioControl1);
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DatosUsuarioControl datosUsuarioControl1;
        private System.Windows.Forms.Button btnAbrirForm;
    }
}

