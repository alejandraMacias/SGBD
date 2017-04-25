using SGBD.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBD.Presentacion
{
    public partial class BajaEntidad : Form
    {
        public BajaEntidad()
        {
            InitializeComponent();
        }

        private void BajaEntidad_Load(object sender, EventArgs e)
        {
        }

        private void butonBaja_Click(object sender, EventArgs e)
        {
            Diccionario diccionario = Diccionario.Instancia;

            diccionario.BajaEntidad(textoEntidad.Text);
        }
    }
}
