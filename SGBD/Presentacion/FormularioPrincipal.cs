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
        }

        void diccionario_ActualizacionEntidad(object sender, ActualizacionEntidadEventArgs e)
        {
            GuardaDiccionario();
        }

        private void abrirSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo.AddExtension = true;
            abrirArchivo.DefaultExt = ".db";
            abrirArchivo.Filter = "Diccionario (*.db)|*.db";
            abrirArchivo.InitialDirectory = Application.StartupPath;
            abrirArchivo.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = File.Open(abrirArchivo.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();

            diccionario.Abrir(abrirArchivo.SafeFileName.Replace(".db", ""), (List<Entidad>)formatter.Deserialize(stream));
            stream.Close();
        }

        private void crearSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoArchivo.AddExtension = true;
            nuevoArchivo.DefaultExt = ".db";
            nuevoArchivo.Filter = "Diccionario (*.db)|*.db";
            nuevoArchivo.InitialDirectory = Application.StartupPath;
            nuevoArchivo.ShowDialog();
        }

        private void nuevoArchivo_FileOk(object sender, CancelEventArgs e)
        {
            string[] pathDiccionario = nuevoArchivo.FileName.Split('\\');

            diccionario.Crear(pathDiccionario[pathDiccionario.Length - 1].Replace(".db", ""));
            GuardaDiccionario();
        }

        private void altaEntidad(object sender, EventArgs e)
        {
            AltaEntidad dialogo = new AltaEntidad();

            dialogo.ShowDialog();
        }

        private void bajaEntidad(object sender, EventArgs e)
        {
            BajaEntidad dialogo = new BajaEntidad();
            
            dialogo.ShowDialog();
        }

        private void modificacionEntidad(object sender, EventArgs e)
        {
            ModificaEntidad dialogo = new ModificaEntidad();

            dialogo.ShowDialog();
        }

        private void altaAtributo(object sender, EventArgs e)
        {
            AltaAtributo dialogo = new AltaAtributo();

            dialogo.ShowDialog();
        }

        private void bajaAtributo(object sender, EventArgs e)
        {

        }

        private void modificacionAtributo(object sender, EventArgs e)
        {

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            diccionario.Dispose();
        }

        private void GuardaDiccionario()
        {
            Stream stream = File.Open(diccionario.Nombre + ".db", FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, diccionario.Entidades);
            stream.Close();
        }
    }
}
