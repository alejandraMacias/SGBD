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
        Diccionario diccionario = Diccionario.Instancia;

        /// <summary>
        ///  es en realidad una llamada de método a la 
        ///  clase parcial del control 
        /// </summary>
        public BajaEntidad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se asignan valores a la opcion Entero
        /// </summary>
        private void BajaEntidad_Load(object sender, EventArgs e)
        {
            entidades.DataSource = diccionario.Entidades;
        }

        /// <summary>
        /// Se asignan valores a la opcion Entero
        /// </summary>
        private void butonBaja_Click(object sender, EventArgs e)
        {
            diccionario.BajaEntidad(entidades.SelectedItem.ToString());
        }
    }
}
