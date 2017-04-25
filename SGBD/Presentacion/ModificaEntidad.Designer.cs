namespace SGBD.Presentacion
{
    partial class ModificaEntidad
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
            this.etiquetaEntidad = new System.Windows.Forms.Label();
            this.botonModifica = new System.Windows.Forms.Button();
            this.butonCancelar = new System.Windows.Forms.Button();
            this.entidades = new System.Windows.Forms.ComboBox();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.etiquetaNuevoNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(9, 9);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(44, 13);
            this.etiquetaEntidad.TabIndex = 0;
            this.etiquetaEntidad.Text = "Nombre";
            // 
            // botonModifica
            // 
            this.botonModifica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonModifica.Location = new System.Drawing.Point(12, 135);
            this.botonModifica.Name = "botonModifica";
            this.botonModifica.Size = new System.Drawing.Size(75, 23);
            this.botonModifica.TabIndex = 2;
            this.botonModifica.Text = "Modifica";
            this.botonModifica.UseVisualStyleBackColor = true;
            this.botonModifica.Click += new System.EventHandler(this.botonModifica_Click);
            // 
            // butonCancelar
            // 
            this.butonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butonCancelar.Location = new System.Drawing.Point(254, 135);
            this.butonCancelar.Name = "butonCancelar";
            this.butonCancelar.Size = new System.Drawing.Size(75, 23);
            this.butonCancelar.TabIndex = 3;
            this.butonCancelar.Text = "Cancelar";
            this.butonCancelar.UseVisualStyleBackColor = true;
            // 
            // entidades
            // 
            this.entidades.FormattingEnabled = true;
            this.entidades.Location = new System.Drawing.Point(12, 34);
            this.entidades.Name = "entidades";
            this.entidades.Size = new System.Drawing.Size(317, 21);
            this.entidades.TabIndex = 4;
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(12, 94);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(317, 20);
            this.nuevoNombre.TabIndex = 5;
            // 
            // etiquetaNuevoNombre
            // 
            this.etiquetaNuevoNombre.AutoSize = true;
            this.etiquetaNuevoNombre.Location = new System.Drawing.Point(12, 73);
            this.etiquetaNuevoNombre.Name = "etiquetaNuevoNombre";
            this.etiquetaNuevoNombre.Size = new System.Drawing.Size(44, 13);
            this.etiquetaNuevoNombre.TabIndex = 6;
            this.etiquetaNuevoNombre.Text = "Nombre";
            // 
            // ModificaEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 170);
            this.Controls.Add(this.etiquetaNuevoNombre);
            this.Controls.Add(this.nuevoNombre);
            this.Controls.Add(this.entidades);
            this.Controls.Add(this.butonCancelar);
            this.Controls.Add(this.botonModifica);
            this.Controls.Add(this.etiquetaEntidad);
            this.Name = "ModificaEntidad";
            this.Text = "ModificaEntidad";
            this.Load += new System.EventHandler(this.ModificaEntidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.Button botonModifica;
        private System.Windows.Forms.Button butonCancelar;
        private System.Windows.Forms.ComboBox entidades;
        private System.Windows.Forms.TextBox nuevoNombre;
        private System.Windows.Forms.Label etiquetaNuevoNombre;
    }
}