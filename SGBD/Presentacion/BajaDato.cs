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
    public partial class BajaDato : Form
    {
        Diccionario diccionarioDatos = Diccionario.Instancia;

        public BajaDato()
        {
            InitializeComponent();
            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
        }

        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entidad = seleccionEntidad.SelectedItem as Entidad;
            DataRowCollection datos = diccionarioDatos.Consulta(string.Format("SELECT _id from {0}", entidad.Nombre)).Rows;

            seleccionDato.Items.Clear();
            foreach (DataRow renglon in datos)
            { 
                var id = renglon.ItemArray[0];
                seleccionDato.Items.Add(id);
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var entidad = seleccionEntidad.SelectedItem as Entidad;
            var dato = seleccionDato.SelectedItem.ToString();
            
            diccionarioDatos.Sentencia(string.Format("DELETE FROM {0} WHERE _id = {1}", entidad.Nombre, dato));
        }
    }
}

