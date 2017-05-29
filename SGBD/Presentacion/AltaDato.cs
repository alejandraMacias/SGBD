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
                Control controlAtributo;
                var etiquetaAtributo = new Label();

                switch (atributo.Tipo) 
                {
                    case Diccionario.TipoAtributo.Cadena:
                        controlAtributo = new TextBox();
                        (controlAtributo as TextBox).Size = new Size(333, 21);
                        (controlAtributo as TextBox).MaxLength = atributo.Longitud;
                        (controlAtributo as TextBox).AccessibleName = atributo.Nombre;
                        break;
                    case Diccionario.TipoAtributo.Caracter:
                        controlAtributo = new TextBox();
                        (controlAtributo as TextBox).Size = new Size(333, 21);
                        (controlAtributo as TextBox).MaxLength = 1;
                        (controlAtributo as TextBox).AccessibleName = atributo.Nombre;
                        break;
                    case Diccionario.TipoAtributo.Entero:
                        controlAtributo = new NumericUpDown();
                        (controlAtributo as NumericUpDown).Size = new Size(333, 21);
                        (controlAtributo as NumericUpDown).Maximum = 9223372036854775807;
                        (controlAtributo as NumericUpDown).Minimum = -9223372036854775808;
                        (controlAtributo as NumericUpDown).AccessibleName = atributo.Nombre;
                        break;
                    case Diccionario.TipoAtributo.Flotante:
                        controlAtributo = new NumericUpDown();
                        (controlAtributo as NumericUpDown).Size = new Size(333, 21);
                        (controlAtributo as NumericUpDown).Maximum = 9223372036854775807;
                        (controlAtributo as NumericUpDown).Minimum = -9223372036854775808;
                        (controlAtributo as NumericUpDown).DecimalPlaces = 2;
                        (controlAtributo as NumericUpDown).AccessibleName = atributo.Nombre;
                        break;
                    default:
                        controlAtributo = new TextBox();
                        (controlAtributo as TextBox).Size = new Size(333, 21);
                        (controlAtributo as TextBox).AccessibleName = atributo.Nombre;
                        break;
                }
                etiquetaAtributo.AccessibleName = "label";
                etiquetaAtributo.Text = atributo.Nombre;
                etiquetaAtributo.Size = new Size(333, 21);
                etiquetaAtributo.Location = new Point(3, posicionX);
                posicionX += 22;
                panelDatos.Controls.Add(etiquetaAtributo);
                controlAtributo.Location = new Point(3, posicionX);
                controlAtributo.AccessibleName = atributo.Nombre;
                posicionX += 30;
                panelDatos.Controls.Add(controlAtributo);
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            var entidadActual = seleccionEntidad.SelectedItem as Entidad;
            List<Control> controls = new List<Control>();

            foreach(Control control in panelDatos.Controls)
            {
                if(control.AccessibleName != "label")
                {
                    controls.Add(control);
                }
            }
            diccionarioDatos.AltaDato(entidadActual, controls);
        }
    }
}
