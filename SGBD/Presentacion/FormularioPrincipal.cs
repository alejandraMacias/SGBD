using SGBD.Datos;
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

            diccionario.Crea(abrirArchivo.SafeFileName.Replace(".db", ""));
            diccionario.listaEntidad = (List<Entidad>)formatter.Deserialize(stream);
            stream.Close();
        }

        private void crearSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoArchivo.AddExtension = true;
            nuevoArchivo.DefaultExt = ".db";
            nuevoArchivo.Filter = "Diccionario (*.db)|*.db";
            abrirArchivo.InitialDirectory = Application.StartupPath;
            nuevoArchivo.ShowDialog();
        }

        private void nuevoArchivo_FileOk(object sender, CancelEventArgs e)
        {
            Stream stream = File.Open(nuevoArchivo.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();
            string[] pathDiccionario = nuevoArchivo.FileName.Split('\\');

            diccionario.Crea(pathDiccionario[pathDiccionario.Length - 1].Replace(".db", ""));
            formatter.Serialize(stream, diccionario.listaEntidad);
            stream.Close();
        }

        private void altaEntidad(object sender, EventArgs e)
        {

        }

        private void bajaEntidad(object sender, EventArgs e)
        {

        }

        private void modificacionEntidad(object sender, EventArgs e)
        {

        }

        private void altaAtributo(object sender, EventArgs e)
        {

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
    }
}
