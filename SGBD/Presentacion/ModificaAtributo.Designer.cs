namespace SGBD.Presentacion
{
    partial class ModificaAtributo
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
            this.atributoPrimario = new System.Windows.Forms.TextBox();
            this.etiquetaAtributo = new System.Windows.Forms.Label();
            this.seleccionEntidadReferencia = new System.Windows.Forms.ComboBox();
            this.etiquetaEntidadReferenciada = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cadena = new System.Windows.Forms.RadioButton();
            this.opcionFlotante = new System.Windows.Forms.RadioButton();
            this.opcionEntero = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.claveForanea = new System.Windows.Forms.RadioButton();
            this.clavePrimaria = new System.Windows.Forms.RadioButton();
            this.claveNO = new System.Windows.Forms.RadioButton();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.longitud = new System.Windows.Forms.NumericUpDown();
            this.etiquetaLongitud = new System.Windows.Forms.Label();
            this.etiquetaNombre = new System.Windows.Forms.Label();
            this.seleccionAtributo = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccionEntidad
            // 
            this.seleccionEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionEntidad.FormattingEnabled = true;
            this.seleccionEntidad.Location = new System.Drawing.Point(13, 26);
            this.seleccionEntidad.Name = "seleccionEntidad";
            this.seleccionEntidad.Size = new System.Drawing.Size(280, 21);
            this.seleccionEntidad.TabIndex = 36;
            this.seleccionEntidad.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidad_SelectedIndexChanged);
            // 
            // etiquetaEntidad
            // 
            this.etiquetaEntidad.AutoSize = true;
            this.etiquetaEntidad.Location = new System.Drawing.Point(12, 9);
            this.etiquetaEntidad.Name = "etiquetaEntidad";
            this.etiquetaEntidad.Size = new System.Drawing.Size(43, 13);
            this.etiquetaEntidad.TabIndex = 35;
            this.etiquetaEntidad.Text = "Entidad";
            // 
            // atributoPrimario
            // 
            this.atributoPrimario.Location = new System.Drawing.Point(13, 297);
            this.atributoPrimario.Name = "atributoPrimario";
            this.atributoPrimario.ReadOnly = true;
            this.atributoPrimario.Size = new System.Drawing.Size(280, 20);
            this.atributoPrimario.TabIndex = 34;
            // 
            // etiquetaAtributo
            // 
            this.etiquetaAtributo.AutoSize = true;
            this.etiquetaAtributo.Location = new System.Drawing.Point(12, 281);
            this.etiquetaAtributo.Name = "etiquetaAtributo";
            this.etiquetaAtributo.Size = new System.Drawing.Size(43, 13);
            this.etiquetaAtributo.TabIndex = 33;
            this.etiquetaAtributo.Text = "Atributo";
            // 
            // seleccionEntidadReferencia
            // 
            this.seleccionEntidadReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionEntidadReferencia.FormattingEnabled = true;
            this.seleccionEntidadReferencia.Location = new System.Drawing.Point(13, 254);
            this.seleccionEntidadReferencia.Name = "seleccionEntidadReferencia";
            this.seleccionEntidadReferencia.Size = new System.Drawing.Size(280, 21);
            this.seleccionEntidadReferencia.TabIndex = 32;
            this.seleccionEntidadReferencia.SelectedIndexChanged += new System.EventHandler(this.seleccionEntidadReferencia_SelectedIndexChanged);
            // 
            // etiquetaEntidadReferenciada
            // 
            this.etiquetaEntidadReferenciada.AutoSize = true;
            this.etiquetaEntidadReferenciada.Location = new System.Drawing.Point(12, 237);
            this.etiquetaEntidadReferenciada.Name = "etiquetaEntidadReferenciada";
            this.etiquetaEntidadReferenciada.Size = new System.Drawing.Size(105, 13);
            this.etiquetaEntidadReferenciada.TabIndex = 31;
            this.etiquetaEntidadReferenciada.Text = "Entidad referenciada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cadena);
            this.groupBox2.Controls.Add(this.opcionFlotante);
            this.groupBox2.Controls.Add(this.opcionEntero);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 35);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // Cadena
            // 
            this.Cadena.AutoSize = true;
            this.Cadena.Location = new System.Drawing.Point(205, 13);
            this.Cadena.Name = "Cadena";
            this.Cadena.Size = new System.Drawing.Size(62, 17);
            this.Cadena.TabIndex = 10;
            this.Cadena.TabStop = true;
            this.Cadena.Text = "Cadena";
            this.Cadena.UseVisualStyleBackColor = true;
            this.Cadena.CheckedChanged += new System.EventHandler(this.Cadena_CheckedChanged);
            // 
            // opcionFlotante
            // 
            this.opcionFlotante.AutoSize = true;
            this.opcionFlotante.Location = new System.Drawing.Point(97, 12);
            this.opcionFlotante.Name = "opcionFlotante";
            this.opcionFlotante.Size = new System.Drawing.Size(63, 17);
            this.opcionFlotante.TabIndex = 8;
            this.opcionFlotante.TabStop = true;
            this.opcionFlotante.Text = "Flotante";
            this.opcionFlotante.UseVisualStyleBackColor = true;
            this.opcionFlotante.CheckedChanged += new System.EventHandler(this.opcionFlotante_CheckedChanged);
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
            this.opcionEntero.CheckedChanged += new System.EventHandler(this.opcionEntero_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.claveForanea);
            this.groupBox1.Controls.Add(this.clavePrimaria);
            this.groupBox1.Controls.Add(this.claveNO);
            this.groupBox1.Location = new System.Drawing.Point(13, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 34);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clave";
            // 
            // claveForanea
            // 
            this.claveForanea.AutoSize = true;
            this.claveForanea.Location = new System.Drawing.Point(205, 12);
            this.claveForanea.Name = "claveForanea";
            this.claveForanea.Size = new System.Drawing.Size(64, 17);
            this.claveForanea.TabIndex = 15;
            this.claveForanea.TabStop = true;
            this.claveForanea.Text = "Foránea";
            this.claveForanea.UseVisualStyleBackColor = true;
            this.claveForanea.CheckedChanged += new System.EventHandler(this.claveForanea_CheckedChanged);
            // 
            // clavePrimaria
            // 
            this.clavePrimaria.AutoSize = true;
            this.clavePrimaria.Location = new System.Drawing.Point(97, 11);
            this.clavePrimaria.Name = "clavePrimaria";
            this.clavePrimaria.Size = new System.Drawing.Size(62, 17);
            this.clavePrimaria.TabIndex = 14;
            this.clavePrimaria.TabStop = true;
            this.clavePrimaria.Text = "Primaria";
            this.clavePrimaria.UseVisualStyleBackColor = true;
            this.clavePrimaria.CheckedChanged += new System.EventHandler(this.clavePrimaria_CheckedChanged);
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
            this.claveNO.CheckedChanged += new System.EventHandler(this.claveNO_CheckedChanged);
            // 
            // botonCancelar
            // 
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.Location = new System.Drawing.Point(218, 335);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 28;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonAgregar.Location = new System.Drawing.Point(12, 335);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 27;
            this.botonAgregar.Text = "Aceptar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // longitud
            // 
            this.longitud.Location = new System.Drawing.Point(13, 163);
            this.longitud.Name = "longitud";
            this.longitud.Size = new System.Drawing.Size(280, 20);
            this.longitud.TabIndex = 26;
            // 
            // etiquetaLongitud
            // 
            this.etiquetaLongitud.AutoSize = true;
            this.etiquetaLongitud.Location = new System.Drawing.Point(10, 146);
            this.etiquetaLongitud.Name = "etiquetaLongitud";
            this.etiquetaLongitud.Size = new System.Drawing.Size(46, 13);
            this.etiquetaLongitud.TabIndex = 25;
            this.etiquetaLongitud.Text = "Tamaño";
            // 
            // etiquetaNombre
            // 
            this.etiquetaNombre.AutoSize = true;
            this.etiquetaNombre.Location = new System.Drawing.Point(10, 56);
            this.etiquetaNombre.Name = "etiquetaNombre";
            this.etiquetaNombre.Size = new System.Drawing.Size(43, 13);
            this.etiquetaNombre.TabIndex = 23;
            this.etiquetaNombre.Text = "Atributo";
            // 
            // seleccionAtributo
            // 
            this.seleccionAtributo.FormattingEnabled = true;
            this.seleccionAtributo.Location = new System.Drawing.Point(13, 72);
            this.seleccionAtributo.Name = "seleccionAtributo";
            this.seleccionAtributo.Size = new System.Drawing.Size(280, 21);
            this.seleccionAtributo.TabIndex = 37;
            this.seleccionAtributo.SelectedIndexChanged += new System.EventHandler(this.seleccionAtributo_SelectedIndexChanged);
            // 
            // ModificaAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 374);
            this.Controls.Add(this.seleccionAtributo);
            this.Controls.Add(this.seleccionEntidad);
            this.Controls.Add(this.etiquetaEntidad);
            this.Controls.Add(this.atributoPrimario);
            this.Controls.Add(this.etiquetaAtributo);
            this.Controls.Add(this.seleccionEntidadReferencia);
            this.Controls.Add(this.etiquetaEntidadReferenciada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.longitud);
            this.Controls.Add(this.etiquetaLongitud);
            this.Controls.Add(this.etiquetaNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaAtributo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifica Atributo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.longitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccionEntidad;
        private System.Windows.Forms.Label etiquetaEntidad;
        private System.Windows.Forms.TextBox atributoPrimario;
        private System.Windows.Forms.Label etiquetaAtributo;
        private System.Windows.Forms.ComboBox seleccionEntidadReferencia;
        private System.Windows.Forms.Label etiquetaEntidadReferenciada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Cadena;
        private System.Windows.Forms.RadioButton opcionFlotante;
        private System.Windows.Forms.RadioButton opcionEntero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton claveForanea;
        private System.Windows.Forms.RadioButton clavePrimaria;
        private System.Windows.Forms.RadioButton claveNO;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.NumericUpDown longitud;
        private System.Windows.Forms.Label etiquetaLongitud;
        private System.Windows.Forms.Label etiquetaNombre;
        private System.Windows.Forms.ComboBox seleccionAtributo;
    }
}