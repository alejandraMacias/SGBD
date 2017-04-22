using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBD
{
    public partial class Form1 : Form
    {
        public SqlConnection coneccion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var conString = Properties.Settings.Default.ConnectionString;
            coneccion = new SqlConnection(conString);
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from test", coneccion);
            var registros = cmd.ExecuteScalar().ToString();
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
    }
}
