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

        private void Form_Load(object sender, EventArgs e)
        {
            var p = diccionario.EjecutaPrueba();
        }

        private void abrirSGBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
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
