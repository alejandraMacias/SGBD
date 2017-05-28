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
    public partial class AltaDato : Form
    {
        private Diccionario diccionarioDatos = Diccionario.Instancia;

        public AltaDato()
        {
            InitializeComponent();

            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
        }

        /// <summary>
        /// Se dan de alta los datos en un atributo determinado 
        /// </summary>
        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entidadActual = seleccionEntidad.SelectedItem as Entidad;
            var posicionX = 5;

            panelDatos.Controls.Clear();
            foreach (var atributo in entidadActual.Atributos)
            {
                var controlAtributo = new TextBox();
                var etiquetaAtributo = new Label();

                etiquetaAtributo.Text = atributo.Nombre;
                etiquetaAtributo.Size = new Size(333, 21);
                etiquetaAtributo.Location = new Point(3, posicionX);
                posicionX += 22;
                panelDatos.Controls.Add(etiquetaAtributo);
                controlAtributo.Size = new Size(333, 21);
                controlAtributo.Location = new Point(3, posicionX);
                controlAtributo.AccessibleName = atributo.Nombre;
                posicionX += 30;
                panelDatos.Controls.Add(controlAtributo);
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
