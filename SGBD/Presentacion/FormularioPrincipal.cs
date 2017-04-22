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
            // Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;
            // Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;
            var conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;";
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
    }
}
