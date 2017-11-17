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
    public partial class ModificaDato : Form
    {
        Diccionario diccionarioDatos = Diccionario.Instancia;

        public ModificaDato()
        {
            InitializeComponent();
            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
        }

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
                elemento ++;
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            var entidadActual = seleccionEntidad.SelectedItem as Entidad;
            StringBuilder sentencia = new StringBuilder();

            sentencia.AppendFormat("UPDATE {0} SET", entidadActual.Nombre);
            foreach(Control control in panelDatos.Controls)
            {
                if(control.AccessibleName != "label")
                {
                    if (control is NumericUpDown) 
                    {
                        sentencia.AppendFormat(" {0} = '{1}',", control.AccessibleName, (control as NumericUpDown).Value.ToString());
                    }
                    else if (control is TextBox)
                    {
                        sentencia.AppendFormat(" {0} = '{1}',", control.AccessibleName, (control as TextBox).Text);
                    }
                }
            }
            sentencia.Remove(sentencia.Length - 1, 1);
            sentencia.AppendFormat(" WHERE [_id] = {0}", seleccionDato.SelectedItem.ToString());
            diccionarioDatos.Sentencia(sentencia.ToString());
        }
    }
}
