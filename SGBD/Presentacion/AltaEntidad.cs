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
    public partial class AltaEntidad : Form
    {
        public AltaEntidad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El evento se desencadena se hace clic en el control. 
        /// </summary>
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Diccionario diccionario = Diccionario.Instancia;

            if (!diccionario.AltaEntidad(textoEntidad.Text))
            {
                MessageBox.Show("No se pudo crear la tabla, verifique su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
