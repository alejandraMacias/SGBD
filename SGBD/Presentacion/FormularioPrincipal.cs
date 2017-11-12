using SGBD.Datos;
using SGBD.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SGBD
{
    public partial class Form1 : Form
    {
        private Diccionario diccionario;

        public Form1()
        {
            InitializeComponent();
            diccionario = Diccionario.Instancia;
            diccionario.ActualizacionEntidad += diccionario_ActualizacionEntidad;
            diccionario.ActualizacionAtributo += diccionario_ActualizacionAtributo;
        }

        void diccionario_ActualizacionAtributo(object sender, ActualizacionAtributoEventArgs e)
        {
            GuardaDiccionario();
            AcualizaTreeView();
        }

        void diccionario_ActualizacionEntidad(object sender, ActualizacionEntidadEventArgs e)
        {
            GuardaDiccionario();
            AcualizaTreeView();
        }

        private void AcualizaTreeView()
        {
            elementosDiccionario.Nodes.Clear();
            foreach (var entidad in diccionario.Entidades)
            {
                var nodo = new TreeNode(entidad.ToString());
                foreach (var atributo in entidad.Atributos)
                {
                    nodo.Nodes.Add(atributo.ToString());
                }
                elementosDiccionario.NodeMouseDoubleClick += elementosDiccionario_Click;
                elementosDiccionario.Nodes.Add(nodo);
                elementosDiccionario.ExpandAll();
            }
        }

        void elementosDiccionario_Click(object sender, EventArgs e)
        {
            var nombreEntidad = elementosDiccionario.SelectedNode.Text;
            var entidad = diccionario.Entidades.Find(ent => ent.Nombre == nombreEntidad);

            if( entidad != null)
            {
                dataGridDatos.DataSource = diccionario.ConsultaTodo(entidad);
                dataGridDatos.ClearSelection();
            }
            elementosDiccionario.ExpandAll();
        }

        /// <summary>
        /// Abre el archivo
        /// Se asigna una extencion al archivo
        /// Establecer el directorio inicial de archivo.
        /// </summary>
        private void abrirSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo.AddExtension = true;
            abrirArchivo.DefaultExt = ".db";
            abrirArchivo.Filter = "Diccionario (*.db)|*.db";
            abrirArchivo.InitialDirectory = Application.StartupPath;
            abrirArchivo.ShowDialog();
        }

        /// <summary>
        /// Abre un archivo  con acceso de solo lectura 
        /// </summary>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = File.Open(abrirArchivo.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();

            diccionario.Abrir(abrirArchivo.SafeFileName.Replace(".db", ""), (List<Entidad>)formatter.Deserialize(stream));
            AcualizaTreeView();
            stream.Close();
        }

        /// <summary>
        /// Crear archivo
        /// Se asigna una extencion al archivo
        /// Establecer el directorio inicial de archivo.
        /// </summary>
        private void crearSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoArchivo.AddExtension = true;
            nuevoArchivo.DefaultExt = ".db";
            nuevoArchivo.Filter = "Diccionario (*.db)|*.db";
            nuevoArchivo.InitialDirectory = Application.StartupPath;
            nuevoArchivo.ShowDialog();
        }

        /// <summary>
        /// Especifica información de ruta de acceso.
        /// </summary>
        private void nuevoArchivo_FileOk(object sender, CancelEventArgs e)
        {
            string[] pathDiccionario = nuevoArchivo.FileName.Split('\\');

            diccionario.Crear(pathDiccionario[pathDiccionario.Length - 1].Replace(".db", ""));
            AcualizaTreeView();
            GuardaDiccionario();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para dar de alta una entidad.
        /// </summary>
        private void altaEntidad(object sender, EventArgs e)
        {
            AltaEntidad dialogo = new AltaEntidad();

            dialogo.ShowDialog();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para dar de baja una entidad.
        /// </summary>
        private void bajaEntidad(object sender, EventArgs e)
        {
            BajaEntidad dialogo = new BajaEntidad();
            
            dialogo.ShowDialog();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para modificar una entidad.
        /// </summary>
        private void modificacionEntidad(object sender, EventArgs e)
        {
            ModificaEntidad dialogo = new ModificaEntidad();

            dialogo.ShowDialog();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para dar de alta una atributo
        /// </summary>
        private void altaAtributo(object sender, EventArgs e)
        {
            AltaAtributo dialogo = new AltaAtributo();

            dialogo.ShowDialog();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para dar de baja un atributo
        /// </summary>
        private void bajaAtributo(object sender, EventArgs e)
        {
            BajaAtributo dialogo = new BajaAtributo();

            dialogo.ShowDialog();
        }

        /// <summary>
        /// Mostrar el cuadro de diálogo para dar modificarun atributo.
        /// </summary>
        private void modificacionAtributo(object sender, EventArgs e)
        {
            ModificaAtributo dialogo = new ModificaAtributo();

            dialogo.ShowDialog();
        }

        /// <summary>
        /// Libera todos los recursos asociados al formulario.
        /// </summary>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            diccionario.Dispose();
        }

        /// <summary>
        /// Guarda el archivo 
        /// </summary>
        private void GuardaDiccionario()
        {
            Stream stream = File.Open(diccionario.Nombre + ".db", FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, diccionario.Entidades);
            stream.Close();
        }

        private void altaDatoMenuItem_Click(object sender, EventArgs e)
        {
            AltaDato dialogo = new AltaDato();

            dialogo.ShowDialog();
        }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            var validacion = diccionario.ValidaConsulta(consultasSQL.Text);
            if (validacion != string.Empty)
            {
                MessageBox.Show(validacion, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridDatos.DataSource = diccionario.Consulta(consultasSQL.Text);
                dataGridDatos.ClearSelection();
            }
        }

        private void bajaDato_Click(object sender, EventArgs e)
        {
            BajaDato dialogo = new BajaDato();

            dialogo.ShowDialog();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaDato dialogo = new ModificaDato();

            dialogo.ShowDialog();
        }

        private void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
