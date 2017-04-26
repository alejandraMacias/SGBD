namespace SGBD.Presentacion
{
    partial class AltaAtributo
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
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.nombreAtributo = new System.Windows.Forms.TextBox();
            this.etiquetaLongitud = new System.Windows.Forms.Label();
            this.longitud = new System.Windows.Forms.NumericUpDown();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.claveForanea = new System.Windows.Forms.RadioButton();
            this.clavePrimaria = new System.Windows.Forms.RadioButton();
            this.claveNO = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cadena = new System.Windows.Forms.RadioButton();
            this.opcionCaracter = new System.Windows.Forms.RadioButton();
            this.opcionFlotante = new System.Windows.Forms.RadioButton();
            this.opcionEntero = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(10, 9);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(82, 13);
            this.etiquetaNombre.TabIndex = 0;
            this.etiquetaNombre.Text = "Nombre atributo";
            // 
            // nombreAtributo
            // 
            this.nombreAtributo.Location = new System.Drawing.Point(13, 26);
            this.nombreAtributo.Name = "nombreAtributo";
            this.nombreAtributo.Size = new System.Drawing.Size(280, 20);
            this.nombreAtributo.TabIndex = 1;
            // 
            // etiquetaLongitud
            // 
            this.etiquetaLongitud.AutoSize = true;
            this.etiquetaLongitud.Location = new System.Drawing.Point(10, 111);
            this.etiquetaLongitud.Name = "etiquetaLongitud";
            this.etiquetaLongitud.Size = new System.Drawing.Size(46, 13);
            this.etiquetaLongitud.TabIndex = 7;
            this.etiquetaLongitud.Text = "Tamaño";
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(13, 128);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(280, 20);
            this.longitud.TabIndex = 8;
            // 
            // botonAgregar
            // 
            this.botonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonAgregar.Location = new System.Drawing.Point(12, 219);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 13;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // botonCancelar
            // 
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.Location = new System.Drawing.Point(218, 219);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 14;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.claveForanea);
            this.groupBox1.Controls.Add(this.clavePrimaria);
            this.groupBox1.Controls.Add(this.claveNO);
            this.groupBox1.Location = new System.Drawing.Point(13, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 34);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clave";
            // 
            // claveForanea
            // 
            this.claveForanea.AutoSize = true;
            this.claveForanea.Location = new System.Drawing.Point(123, 12);
            this.claveForanea.Name = "claveForanea";
            this.claveForanea.Size = new System.Drawing.Size(64, 17);
            this.claveForanea.TabIndex = 15;
            this.claveForanea.TabStop = true;
            this.claveForanea.Text = "Foránea";
            this.claveForanea.UseVisualStyleBackColor = true;
            // 
            // clavePrimaria
            // 
            this.clavePrimaria.AutoSize = true;
            this.clavePrimaria.Location = new System.Drawing.Point(55, 12);
            this.clavePrimaria.Name = "clavePrimaria";
            this.clavePrimaria.Size = new System.Drawing.Size(62, 17);
            this.clavePrimaria.TabIndex = 14;
            this.clavePrimaria.TabStop = true;
            this.clavePrimaria.Text = "Primaria";
            this.clavePrimaria.UseVisualStyleBackColor = true;
            // 
            // claveNO
            // 
            this.claveNO.AutoSize = true;
            this.claveNO.Location = new System.Drawing.Point(8, 12);
            this.claveNO.Name = "claveNO";
            this.claveNO.Size = new System.Drawing.Size(41, 17);
            this.claveNO.TabIndex = 13;
            this.claveNO.TabStop = true;
            this.claveNO.Text = "NO";
            this.claveNO.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cadena);
            this.groupBox2.Controls.Add(this.opcionCaracter);
            this.groupBox2.Controls.Add(this.opcionFlotante);
            this.groupBox2.Controls.Add(this.opcionEntero);
            this.groupBox2.Location = new System.Drawing.Point(13, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 35);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // Cadena
            // 
            this.Cadena.AutoSize = true;
            this.Cadena.Location = new System.Drawing.Point(211, 13);
            this.Cadena.Name = "Cadena";
            this.Cadena.Size = new System.Drawing.Size(62, 17);
            this.Cadena.TabIndex = 10;
            this.Cadena.TabStop = true;
            this.Cadena.Text = "Cadena";
            this.Cadena.UseVisualStyleBackColor = true;
            // 
            // opcionCaracter
            // 
            this.opcionCaracter.AutoSize = true;
            this.opcionCaracter.Location = new System.Drawing.Point(140, 13);
            this.opcionCaracter.Name = "opcionCaracter";
            this.opcionCaracter.Size = new System.Drawing.Size(65, 17);
            this.opcionCaracter.TabIndex = 9;
            this.opcionCaracter.TabStop = true;
            this.opcionCaracter.Text = "Carácter";
            this.opcionCaracter.UseVisualStyleBackColor = true;
            // 
            // opcionFlotante
            // 
            this.opcionFlotante.AutoSize = true;
            this.opcionFlotante.Location = new System.Drawing.Point(71, 13);
            this.opcionFlotante.Name = "opcionFlotante";
            this.opcionFlotante.Size = new System.Drawing.Size(63, 17);
            this.opcionFlotante.TabIndex = 8;
            this.opcionFlotante.TabStop = true;
            this.opcionFlotante.Text = "Flotante";
            this.opcionFlotante.UseVisualStyleBackColor = true;
            // 
            // opcionEntero
            // 
            this.opcionEntero.AutoSize = true;
            this.opcionEntero.Location = new System.Drawing.Point(8, 13);
            this.opcionEntero.Name = "opcionEntero";
            this.opcionEntero.Size = new System.Drawing.Size(56, 17);
            this.opcionEntero.TabIndex = 7;
            this.opcionEntero.TabStop = true;
            this.opcionEntero.Text = "Entero";
            this.opcionEntero.UseVisualStyleBackColor = true;
            // 
            // AltaAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.etiquetaLongitud);
            this.Controls.Add(this.nombreAtributo);
            this.Controls.Add(this.etiquetaNombre);
            this.Name = "AltaAtributo";
            this.Text = "AltaAtributo";
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.TextBox nombreAtributo;
        private System.Windows.Forms.Label etiquetaLongitud;
        private System.Windows.Forms.NumericUpDown longitud;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton claveForanea;
        private System.Windows.Forms.RadioButton clavePrimaria;
        private System.Windows.Forms.RadioButton claveNO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Cadena;
        private System.Windows.Forms.RadioButton opcionCaracter;
        private System.Windows.Forms.RadioButton opcionFlotante;
        private System.Windows.Forms.RadioButton opcionEntero;
    }
}