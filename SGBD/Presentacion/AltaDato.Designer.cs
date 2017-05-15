namespace SGBD.Presentacion
{
    partial class AltaDato
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
            this.seleccionEntidad = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(13, 15);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(43, 13);
            this.etiquetaEntidad.TabIndex = 0;
            this.etiquetaEntidad.Text = "Enitdad";
            // 
            // seleccionEntidad
            // 
            this.seleccionEntidad.FormattingEnabled = true;
            this.seleccionEntidad.Location = new System.Drawing.Point(13, 35);
            this.seleccionEntidad.Name = "seleccionEntidad";
            this.seleccionEntidad.Size = new System.Drawing.Size(339, 21);
            this.seleccionEntidad.TabIndex = 1;
            this.seleccionEntidad.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidad_SelectedIndexChanged);
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.AutoScroll = true;
            this.panelDatos.Location = new System.Drawing.Point(13, 63);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(359, 246);
            this.panelDatos.TabIndex = 2;
            // 
            // botonAgregar
            // 
            this.botonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonAgregar.Location = new System.Drawing.Point(13, 326);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 3;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.Location = new System.Drawing.Point(297, 326);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 4;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.seleccionEntidad);
            this.Controls.Add(this.etiquetaEntidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaDato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaDato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.ComboBox seleccionEntidad;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonCancelar;
    }
}