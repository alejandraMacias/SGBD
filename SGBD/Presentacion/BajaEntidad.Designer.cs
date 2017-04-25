namespace SGBD.Presentacion
{
    partial class BajaEntidad
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
            this.butonBaja = new System.Windows.Forms.Button();
            this.butonCancelar = new System.Windows.Forms.Button();
            this.etiqetaEntidad = new System.Windows.Forms.Label();
            this.entidades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // butonBaja
            // 
            this.butonBaja.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butonBaja.Location = new System.Drawing.Point(12, 79);
            this.butonBaja.Name = "butonBaja";
            this.butonBaja.Size = new System.Drawing.Size(75, 23);
            this.butonBaja.TabIndex = 0;
            this.butonBaja.Text = "Baja";
            this.butonBaja.UseVisualStyleBackColor = true;
            this.butonBaja.Click += new System.EventHandler(this.butonBaja_Click);
            // 
            // butonCancelar
            // 
            this.butonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butonCancelar.Location = new System.Drawing.Point(250, 79);
            this.butonCancelar.Name = "butonCancelar";
            this.butonCancelar.Size = new System.Drawing.Size(75, 23);
            this.butonCancelar.TabIndex = 1;
            this.butonCancelar.Text = "Cancelar";
            this.butonCancelar.UseVisualStyleBackColor = true;
            // 
            // etiqetaEntidad
            // 
            this.etiqetaEntidad.AutoSize = true;
            this.etiqetaEntidad.Location = new System.Drawing.Point(12, 9);
            this.etiqetaEntidad.Name = "etiqetaEntidad";
            this.etiqetaEntidad.Size = new System.Drawing.Size(44, 13);
            this.etiqetaEntidad.TabIndex = 3;
            this.etiqetaEntidad.Text = "Nombre";
            // 
            // entidades
            // 
            this.entidades.FormattingEnabled = true;
            this.entidades.Location = new System.Drawing.Point(12, 38);
            this.entidades.Name = "entidades";
            this.entidades.Size = new System.Drawing.Size(313, 21);
            this.entidades.TabIndex = 4;
            // 
            // BajaEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 114);
            this.Controls.Add(this.entidades);
            this.Controls.Add(this.etiqetaEntidad);
            this.Controls.Add(this.butonCancelar);
            this.Controls.Add(this.butonBaja);
            this.Name = "BajaEntidad";
            this.Text = "BajaEntidad";
            this.Load += new System.EventHandler(this.BajaEntidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonBaja;
        private System.Windows.Forms.Button butonCancelar;
        private System.Windows.Forms.Label etiqetaEntidad;
        private System.Windows.Forms.ComboBox entidades;
    }
}