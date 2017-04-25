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
            this.textoModificar = new System.Windows.Forms.TextBox();
            this.butonModifica = new System.Windows.Forms.Button();
            this.butonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(13, 23);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(44, 13);
            this.etiquetaEntidad.TabIndex = 0;
            this.etiquetaEntidad.Text = "Nombre";
            // 
            // textoModificar
            // 
            this.textoModificar.Location = new System.Drawing.Point(16, 48);
            this.textoModificar.Name = "textoModificar";
            this.textoModificar.Size = new System.Drawing.Size(241, 20);
            this.textoModificar.TabIndex = 1;
            // 
            // butonModifica
            // 
            this.butonModifica.Location = new System.Drawing.Point(16, 85);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(75, 23);
            this.butonModifica.TabIndex = 2;
            this.butonModifica.Text = "Modifica";
            this.butonModifica.UseVisualStyleBackColor = true;
            // 
            // butonCancelar
            // 
            this.butonCancelar.Location = new System.Drawing.Point(232, 85);
            this.butonCancelar.Name = "butonCancelar";
            this.butonCancelar.Size = new System.Drawing.Size(75, 23);
            this.butonCancelar.TabIndex = 3;
            this.butonCancelar.Text = "Cancelar";
            this.butonCancelar.UseVisualStyleBackColor = true;
            // 
            // ModificaEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 125);
            this.Controls.Add(this.butonCancelar);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.textoModificar);
            this.Controls.Add(this.etiquetaEntidad);
            this.Name = "ModificaEntidad";
            this.Text = "ModificaEntidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.TextBox textoModificar;
        private System.Windows.Forms.Button butonModifica;
        private System.Windows.Forms.Button butonCancelar;
    }
}