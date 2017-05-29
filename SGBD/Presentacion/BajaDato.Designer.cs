namespace SGBD.Presentacion
{
    partial class BajaDato
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
            this.seleccionEntidad = new System.Windows.Forms.ComboBox();
            this.etiquetaEntidad = new System.Windows.Forms.Label();
            this.etiquetaId = new System.Windows.Forms.Label();
            this.seleccionDato = new System.Windows.Forms.ComboBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seleccionEntidad
            // 
            this.seleccionEntidad.FormattingEnabled = true;
            this.seleccionEntidad.Location = new System.Drawing.Point(10, 41);
            this.seleccionEntidad.Name = "seleccionEntidad";
            this.seleccionEntidad.Size = new System.Drawing.Size(339, 21);
            this.seleccionEntidad.TabIndex = 3;
            this.seleccionEntidad.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidad_SelectedIndexChanged);
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(10, 21);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(43, 13);
            this.etiquetaEntidad.TabIndex = 2;
            this.etiquetaEntidad.Text = "Enitdad";
            // 
            // etiquetaId
            // 
            this.etiquetaId.AutoSize = true;
            this.etiquetaId.Location = new System.Drawing.Point(10, 74);
            this.etiquetaId.Name = "etiquetaId";
            this.etiquetaId.Size = new System.Drawing.Size(65, 13);
            this.etiquetaId.TabIndex = 4;
            this.etiquetaId.Text = "Identificador";
            // 
            // seleccionDato
            // 
            this.seleccionDato.FormattingEnabled = true;
            this.seleccionDato.Location = new System.Drawing.Point(10, 90);
            this.seleccionDato.Name = "seleccionDato";
            this.seleccionDato.Size = new System.Drawing.Size(339, 21);
            this.seleccionDato.TabIndex = 5;
            // 
            // botonAceptar
            // 
            this.botonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonAceptar.Location = new System.Drawing.Point(13, 128);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.Location = new System.Drawing.Point(274, 128);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // BajaDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 163);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.seleccionDato);
            this.Controls.Add(this.etiquetaId);
            this.Controls.Add(this.seleccionEntidad);
            this.Controls.Add(this.etiquetaEntidad);
            this.Name = "BajaDato";
            this.Text = "BajaDato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionEntidad;
        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.Label etiquetaId;
        private System.Windows.Forms.ComboBox seleccionDato;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
    }
}