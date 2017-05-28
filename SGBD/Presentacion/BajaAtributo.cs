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
    public partial class BajaAtributo : Form
    {
        Diccionario diccionarioDatos = Diccionario.Instancia;
        public BajaAtributo()
        {
            InitializeComponent();
            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
        }

        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener el elemento seleccionado actualmente
            seleccionAtributo.DataSource = (seleccionEntidad.SelectedItem as Entidad).Atributos.ToList();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            //Se manda llamar el metodobaja atributo
            diccionarioDatos.BajaAtributo(seleccionEntidad.SelectedItem as Entidad, 
                seleccionAtributo.SelectedItem as Atributo);
        }
    }
}
