namespace SGBD.Presentacion
{
    partial class BajaAtributo
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
            this.botonBaja = new System.Windows.Forms.Button();
            this.butonCancelar = new System.Windows.Forms.Button();
            this.etiquetaAtributo = new System.Windows.Forms.Label();
            this.seleccionEntidad = new System.Windows.Forms.ComboBox();
            this.seleccionAtributo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonBaja
            // 
            this.botonBaja.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonBaja.Location = new System.Drawing.Point(15, 131);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(75, 23);
            this.botonBaja.TabIndex = 0;
            this.botonBaja.Text = "Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // butonCancelar
            // 
            this.butonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butonCancelar.Location = new System.Drawing.Point(257, 131);
            this.butonCancelar.Name = "butonCancelar";
            this.butonCancelar.Size = new System.Drawing.Size(75, 23);
            this.butonCancelar.TabIndex = 1;
            this.butonCancelar.Text = "Cancelar";
            this.butonCancelar.UseVisualStyleBackColor = true;
            // 
            // etiquetaAtributo
            // 
            this.etiquetaAtributo.AutoSize = true;
            this.etiquetaAtributo.Location = new System.Drawing.Point(12, 9);
            this.etiquetaAtributo.Name = "etiquetaAtributo";
            this.etiquetaAtributo.Size = new System.Drawing.Size(43, 13);
            this.etiquetaAtributo.TabIndex = 2;
            this.etiquetaAtributo.Text = "Entidad";
            // 
            // seleccionEntidad
            // 
            this.seleccionEntidad.FormattingEnabled = true;
            this.seleccionEntidad.Location = new System.Drawing.Point(12, 25);
            this.seleccionEntidad.Name = "seleccionEntidad";
            this.seleccionEntidad.Size = new System.Drawing.Size(320, 21);
            this.seleccionEntidad.TabIndex = 3;
            this.seleccionEntidad.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidad_SelectedIndexChanged);
            // 
            // seleccionAtributo
            // 
            this.seleccionAtributo.FormattingEnabled = true;
            this.seleccionAtributo.Location = new System.Drawing.Point(12, 81);
            this.seleccionAtributo.Name = "seleccionAtributo";
            this.seleccionAtributo.Size = new System.Drawing.Size(320, 21);
            this.seleccionAtributo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atributo";
            // 
            // BajaAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 166);
            this.Controls.Add(this.seleccionAtributo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionEntidad);
            this.Controls.Add(this.etiquetaAtributo);
            this.Controls.Add(this.butonCancelar);
            this.Controls.Add(this.botonBaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BajaAtributo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BajaAtributo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button butonCancelar;
        private System.Windows.Forms.Label etiquetaAtributo;
        private System.Windows.Forms.ComboBox seleccionEntidad;
        private System.Windows.Forms.ComboBox seleccionAtributo;
        private System.Windows.Forms.Label label1;
    }
}