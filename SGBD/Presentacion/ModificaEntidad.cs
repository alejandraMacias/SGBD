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
    public partial class ModificaEntidad : Form
    {
        Diccionario diccionario = Diccionario.Instancia;

        public ModificaEntidad()
        {
            InitializeComponent();
        }

        private void ModificaEntidad_Load(object sender, EventArgs e)
        {
            entidades.DataSource = diccionario.Entidades;
        }


        private void botonModifica_Click(object sender, EventArgs e)
        {
            if(!diccionario.ModificaEntidad(entidades.SelectedItem.ToString(), nuevoNombre.Text))
            {
                MessageBox.Show("No se pudo modificar la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
