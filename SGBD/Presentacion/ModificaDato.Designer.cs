namespace SGBD.Presentacion
{
    partial class ModificaDato
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
            this.seleccionDato = new System.Windows.Forms.ComboBox();
            this.etiquetaId = new System.Windows.Forms.Label();
            this.seleccionEntidad = new System.Windows.Forms.ComboBox();
            this.etiquetaEntidad = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seleccionDato
            // 
            this.seleccionDato.FormattingEnabled = true;
            this.seleccionDato.Location = new System.Drawing.Point(12, 84);
            this.seleccionDato.Name = "seleccionDato";
            this.seleccionDato.Size = new System.Drawing.Size(339, 21);
            this.seleccionDato.TabIndex = 9;
            this.seleccionDato.SelectedIndexChanged += new System.EventHandler(this.seleccionDato_SelectedIndexChanged);
            // 
            // etiquetaId
            // 
            this.etiquetaId.AutoSize = true;
            this.etiquetaId.Location = new System.Drawing.Point(12, 68);
            this.etiquetaId.Name = "etiquetaId";
            this.etiquetaId.Size = new System.Drawing.Size(65, 13);
            this.etiquetaId.TabIndex = 8;
            this.etiquetaId.Text = "Identificador";
            // 
            // seleccionEntidad
            // 
            this.seleccionEntidad.FormattingEnabled = true;
            this.seleccionEntidad.Location = new System.Drawing.Point(12, 35);
            this.seleccionEntidad.Name = "seleccionEntidad";
            this.seleccionEntidad.Size = new System.Drawing.Size(339, 21);
            this.seleccionEntidad.TabIndex = 7;
            this.seleccionEntidad.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidad_SelectedIndexChanged);
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(12, 15);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(43, 13);
            this.etiquetaEntidad.TabIndex = 6;
            this.etiquetaEntidad.Text = "Enitdad";
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.AutoScroll = true;
            this.panelDatos.Location = new System.Drawing.Point(15, 125);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(357, 215);
            this.panelDatos.TabIndex = 10;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonAceptar.Location = new System.Drawing.Point(12, 346);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 11;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.Location = new System.Drawing.Point(297, 346);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 12;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // ModificaDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.seleccionDato);
            this.Controls.Add(this.etiquetaId);
            this.Controls.Add(this.seleccionEntidad);
            this.Controls.Add(this.etiquetaEntidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaDato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificaDato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionDato;
        private System.Windows.Forms.Label etiquetaId;
        private System.Windows.Forms.ComboBox seleccionEntidad;
        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
    }
}