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


        /// <summary>
        /// Seleccion el id del a dar de baja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entidad = seleccionEntidad.SelectedItem as Entidad;
            DataRowCollection datos = diccionarioDatos.Consulta(string.Format("SELECT [_id] from {0}", entidad.Nombre)).Rows;

            seleccionDato.Items.Clear();
            foreach (DataRow renglon in datos)
            { 
                var id = renglon.ItemArray[0];
                seleccionDato.Items.Add(id);
            }
        }


        /// <summary>
        /// Boton que da de baja un dato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var entidad = seleccionEntidad.SelectedItem as Entidad;
            var dato = seleccionDato.SelectedItem.ToString();
            
            if(!diccionarioDatos.Sentencia(string.Format("DELETE FROM {0} WHERE [_id] = {1}", entidad.Nombre, dato)))
            {
                MessageBox.Show("No se pudo eliminar el dato, verifique referencias hacia este dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Eliminacion del dato que se selecciono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seleccionDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entidadActual = seleccionEntidad.SelectedItem as Entidad;
            var atributoActual = seleccionDato.SelectedItem.ToString();
            var posicionX = 5;
            var registro = diccionarioDatos.Consulta(string.Format("SELECT * FROM {0} WHERE [_id] = {1}", entidadActual.Nombre, atributoActual)).Rows[0];
            var elemento = 1;

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
                        (controlAtributo as TextBox).Text = registro.ItemArray[elemento].ToString();
                        break;
                    case Diccionario.TipoAtributo.Caracter:
                        controlAtributo = new TextBox();
                        (controlAtributo as TextBox).Size = new Size(333, 21);
                        (controlAtributo as TextBox).MaxLength = 1;
                        (controlAtributo as TextBox).AccessibleName = atributo.Nombre;
                        (controlAtributo as TextBox).Text = registro.ItemArray[elemento].ToString();
                        break;
                    case Diccionario.TipoAtributo.Entero:
                        controlAtributo = new NumericUpDown();
                        (controlAtributo as NumericUpDown).Size = new Size(333, 21);
                        (controlAtributo as NumericUpDown).Maximum = 9223372036854775807;
                        (controlAtributo as NumericUpDown).Minimum = -9223372036854775808;
                        (controlAtributo as NumericUpDown).AccessibleName = atributo.Nombre;
                        (controlAtributo as NumericUpDown).Value = decimal.Parse(registro.ItemArray[elemento].ToString());
                        break;
                    case Diccionario.TipoAtributo.Flotante:
                        controlAtributo = new NumericUpDown();
                        (controlAtributo as NumericUpDown).Size = new Size(333, 21);
                        (controlAtributo as NumericUpDown).Maximum = 9223372036854775807;
                        (controlAtributo as NumericUpDown).Minimum = -9223372036854775808;
                        (controlAtributo as NumericUpDown).DecimalPlaces = 2;
                        (controlAtributo as NumericUpDown).AccessibleName = atributo.Nombre;
                        (controlAtributo as NumericUpDown).Value = decimal.Parse(registro.ItemArray[elemento].ToString());
                        break;
                    default:
                        controlAtributo = new TextBox();
                        (controlAtributo as TextBox).Size = new Size(333, 21);
                        (controlAtributo as TextBox).AccessibleName = atributo.Nombre;
                        (controlAtributo as TextBox).Text = registro.ItemArray[elemento].ToString();
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
                elemento++;
            }
        }
    }
}

