namespace SGBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirSGBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.crearSGBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atriibutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.modificacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDatoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.elementosDiccionario = new System.Windows.Forms.TreeView();
            this.dataContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.consultasSQL = new System.Windows.Forms.TextBox();
            this.nuevoArchivo = new System.Windows.Forms.SaveFileDialog();
            this.botonConsulta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainer)).BeginInit();
            this.dataContainer.Panel1.SuspendLayout();
            this.dataContainer.Panel2.SuspendLayout();
            this.dataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.entidadToolStripMenuItem,
            this.atriibutoToolStripMenuItem,
            this.datoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSGBDToolStripMenuItem,
            this.toolStripSeparator1,
            this.crearSGBDToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirSGBDToolStripMenuItem
            // 
            this.abrirSGBDToolStripMenuItem.Name = "abrirSGBDToolStripMenuItem";
            this.abrirSGBDToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirSGBDToolStripMenuItem.Text = "Abrir ";
            this.abrirSGBDToolStripMenuItem.Click += new System.EventHandler(this.abrirSGBDToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // crearSGBDToolStripMenuItem
            // 
            this.crearSGBDToolStripMenuItem.Name = "crearSGBDToolStripMenuItem";
            this.crearSGBDToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.crearSGBDToolStripMenuItem.Text = "Nuevo";
            this.crearSGBDToolStripMenuItem.Click += new System.EventHandler(this.crearSGBDToolStripMenuItem_Click);
            // 
            // entidadToolStripMenuItem
            // 
            this.entidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.toolStripSeparator2,
            this.bajaToolStripMenuItem,
            this.toolStripSeparator3,
            this.modificacionToolStripMenuItem});
            this.entidadToolStripMenuItem.Name = "entidadToolStripMenuItem";
            this.entidadToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.entidadToolStripMenuItem.Text = "Entidad";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaEntidad);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaEntidad);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionEntidad);
            // 
            // atriibutoToolStripMenuItem
            // 
            this.atriibutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.toolStripSeparator4,
            this.bajaToolStripMenuItem1,
            this.toolStripSeparator5,
            this.modificacionToolStripMenuItem1});
            this.atriibutoToolStripMenuItem.Name = "atriibutoToolStripMenuItem";
            this.atriibutoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.atriibutoToolStripMenuItem.Text = "Atributo";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaAtributo);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.bajaToolStripMenuItem1.Text = "Baja";
            this.bajaToolStripMenuItem1.Click += new System.EventHandler(this.bajaAtributo);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // modificacionToolStripMenuItem1
            // 
            this.modificacionToolStripMenuItem1.Name = "modificacionToolStripMenuItem1";
            this.modificacionToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.modificacionToolStripMenuItem1.Text = "Modificacion";
            this.modificacionToolStripMenuItem1.Click += new System.EventHandler(this.modificacionAtributo);
            // 
            // datoToolStripMenuItem
            // 
            this.datoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDatoMenuItem});
            this.datoToolStripMenuItem.Name = "datoToolStripMenuItem";
            this.datoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.datoToolStripMenuItem.Text = "Dato";
            // 
            // altaDatoMenuItem
            // 
            this.altaDatoMenuItem.Name = "altaDatoMenuItem";
            this.altaDatoMenuItem.Size = new System.Drawing.Size(95, 22);
            this.altaDatoMenuItem.Text = "Alta";
            this.altaDatoMenuItem.Click += new System.EventHandler(this.altaDatoMenuItem_Click);
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.FileName = "openFileDialog1";
            this.abrirArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.elementosDiccionario);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.dataContainer);
            this.mainContainer.Size = new System.Drawing.Size(768, 459);
            this.mainContainer.SplitterDistance = 180;
            this.mainContainer.TabIndex = 1;
            // 
            // elementosDiccionario
            // 
            this.elementosDiccionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementosDiccionario.Location = new System.Drawing.Point(12, 3);
            this.elementosDiccionario.Name = "elementosDiccionario";
            this.elementosDiccionario.Size = new System.Drawing.Size(165, 444);
            this.elementosDiccionario.TabIndex = 0;
            // 
            // dataContainer
            // 
            this.dataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataContainer.IsSplitterFixed = true;
            this.dataContainer.Location = new System.Drawing.Point(0, 0);
            this.dataContainer.Name = "dataContainer";
            this.dataContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // dataContainer.Panel1
            // 
            this.dataContainer.Panel1.Controls.Add(this.dataGridDatos);
            // 
            // dataContainer.Panel2
            // 
            this.dataContainer.Panel2.Controls.Add(this.botonConsulta);
            this.dataContainer.Panel2.Controls.Add(this.consultasSQL);
            this.dataContainer.Size = new System.Drawing.Size(584, 459);
            this.dataContainer.SplitterDistance = 303;
            this.dataContainer.TabIndex = 0;
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDatos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Location = new System.Drawing.Point(3, 3);
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.Size = new System.Drawing.Size(569, 297);
            this.dataGridDatos.TabIndex = 0;
            // 
            // consultasSQL
            // 
            this.consultasSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultasSQL.Location = new System.Drawing.Point(3, 3);
            this.consultasSQL.Multiline = true;
            this.consultasSQL.Name = "consultasSQL";
            this.consultasSQL.Size = new System.Drawing.Size(569, 113);
            this.consultasSQL.TabIndex = 0;
            // 
            // nuevoArchivo
            // 
            this.nuevoArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.nuevoArchivo_FileOk);
            // 
            // botonConsulta
            // 
            this.botonConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonConsulta.Location = new System.Drawing.Point(497, 122);
            this.botonConsulta.Name = "botonConsulta";
            this.botonConsulta.Size = new System.Drawing.Size(75, 23);
            this.botonConsulta.TabIndex = 1;
            this.botonConsulta.Text = "Ejecutar";
            this.botonConsulta.UseVisualStyleBackColor = true;
            this.botonConsulta.Click += new System.EventHandler(this.botonConsulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 483);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SGBD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.dataContainer.Panel1.ResumeLayout(false);
            this.dataContainer.Panel2.ResumeLayout(false);
            this.dataContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainer)).EndInit();
            this.dataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirSGBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem crearSGBDToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog abrirArchivo;
        private System.Windows.Forms.ToolStripMenuItem entidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atriibutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.SplitContainer dataContainer;
        private System.Windows.Forms.TextBox consultasSQL;
        private System.Windows.Forms.SaveFileDialog nuevoArchivo;
        private System.Windows.Forms.TreeView elementosDiccionario;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.ToolStripMenuItem datoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDatoMenuItem;
        private System.Windows.Forms.Button botonConsulta;
    }
}

