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
    public partial class AltaAtributo : Form
    {
        private Diccionario.ClaveAtributo claveAtributo;
        private Diccionario.TipoAtributo tipoAtributo;
        private Diccionario diccionarioDatos = Diccionario.Instancia;
        private Entidad entidadClave;

        public AltaAtributo()
        {
            InitializeComponent();

            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
            
            seleccionEntidadReferencia.DataSource = diccionarioDatos.Entidades.FindAll(entidad => entidad.Atributos.
                FirstOrDefault(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria) != null );
            longitud.Enabled = false;
            seleccionEntidadReferencia.Visible = atributoPrimario.Visible = claveForanea.Checked;
        }

        public AltaAtributo(string entidadActual)
        {
            InitializeComponent();

            seleccionEntidad.DataSource = diccionarioDatos.Entidades;
            var entidadSeleccionada = diccionarioDatos.Entidades.Where(x => x.Nombre == entidadActual).FirstOrDefault(); 
            seleccionEntidad.SelectedItem = entidadSeleccionada;
            seleccionEntidadReferencia.DataSource = diccionarioDatos.Entidades.FindAll(entidad => entidad.Atributos.
                FirstOrDefault(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria) != null);
            longitud.Enabled = false;
            seleccionEntidadReferencia.Visible = atributoPrimario.Visible = claveForanea.Checked;
        }

        /// <summary>
        /// Se asignan valores a la opcion Entero
        /// </summary>
        private void opcionEntero_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Entero;
            longitud.Value = 4;
            longitud.Enabled = false;
        }

        /// <summary>
        /// Se asignan valores a la opcion Flotante
        /// </summary>
        private void opcionFlotante_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Flotante;
            longitud.Value = 8;
            longitud.Enabled = false;
        }

        /// <summary>
        /// Se asignan valores a la opcion Caracter
        /// </summary>
        private void opcionCaracter_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Caracter;
            longitud.Value = 1;
            longitud.Enabled = false;
        }

        /// <summary>
        /// Se asignan valores a la opcion Cadena
        /// </summary>
        private void Cadena_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Cadena;
            longitud.Value = 30;
            longitud.Enabled = Cadena.Checked;
        }

        /// <summary>
        /// Activa cuando no hay clave
        /// </summary>
        private void claveNO_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.SinClave;
            seleccionEntidadReferencia.Visible = atributoPrimario.Visible = claveForanea.Checked;
        }

        /// <summary>
        /// Activa cuando la clave es primaria
        /// </summary>
        private void clavePrimaria_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.Primaria;
            seleccionEntidadReferencia.Visible = atributoPrimario.Visible = claveForanea.Checked;
        }

        /// <summary>
        /// Activa cuando la clave es foranea
        /// </summary>
        private void claveForanea_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.Foranea;
            seleccionEntidadReferencia.Visible = atributoPrimario.Visible = claveForanea.Checked;
        }

        /// <summary>
        /// Da de alta un atributo con todas sus caracteristicas
        /// </summary>
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Entidad entidadActual = seleccionEntidad.SelectedItem as Entidad;

            if (!claveForanea.Checked)
            {
                entidadClave = null;
            }
            diccionarioDatos.AltaAtributo(entidadActual, nombreAtributo.Text, tipoAtributo, claveAtributo, entidadClave, (int)longitud.Value);
            MessageBox.Show("Atributo agregado", "", MessageBoxButtons.OK);
            nombreAtributo.Clear();
            opcionEntero.Checked = false;
            opcionFlotante.Checked = false;
            Cadena.Checked = false;
            claveForanea.Checked = false;
            clavePrimaria.Checked = false;
            claveNO.Checked = false;
        }

        private void seleccionEntidadReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            entidadClave = diccionarioDatos.Entidades.Find(entidad => entidad.Nombre == seleccionEntidadReferencia.SelectedItem.ToString());
            atributoPrimario.Text = entidadClave.Atributos.First(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria).Nombre;
        }

        /// <summary>
        /// Valida si la entidad actual contiene un atributo con clave primario
        /// </summary>
        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entidadActual = seleccionEntidad.SelectedItem as Entidad;
       
            Atributo atributoPrimario = entidadActual.Atributos.FirstOrDefault(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria);
            
            if (atributoPrimario != null)
            {
                clavePrimaria.Enabled = false;
            }
            else
            {
                clavePrimaria.Enabled = true;
            }
        }
    }
}