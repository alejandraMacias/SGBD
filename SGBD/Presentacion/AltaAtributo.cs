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
            seleccionEntidadReferencia.Enabled = false;
        }

        private void opcionEntero_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Entero;
            longitud.Value = 4;
            longitud.Enabled = false;
        }

        private void opcionFlotante_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Flotante;
            longitud.Value = 8;
            longitud.Enabled = false;
        }

        private void opcionCaracter_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Caracter;
            longitud.Value = 1;
            longitud.Enabled = false;
        }

        private void Cadena_CheckedChanged(object sender, EventArgs e)
        {
            tipoAtributo = Diccionario.TipoAtributo.Cadena;
            longitud.Value = 30;
            longitud.Enabled = true;
        }

        private void claveNO_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.SinClave;
            seleccionEntidadReferencia.Enabled = claveForanea.Checked;
        }

        private void clavePrimaria_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.Primaria;
            seleccionEntidadReferencia.Enabled = claveForanea.Checked;
        }

        private void claveForanea_CheckedChanged(object sender, EventArgs e)
        {
            claveAtributo = Diccionario.ClaveAtributo.Foranea;
            seleccionEntidadReferencia.Enabled = claveForanea.Checked;
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Entidad entidadActual = seleccionEntidad.SelectedItem as Entidad;

            if (!claveForanea.Checked)
            {
                entidadClave = null;
            }
            diccionarioDatos.AltaAtributo(entidadActual, nombreAtributo.Text, tipoAtributo, claveAtributo, entidadClave, (int)longitud.Value);
        }

        private void seleccionEntidadReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            entidadClave = diccionarioDatos.Entidades.Find(entidad => entidad.Nombre == seleccionEntidadReferencia.SelectedItem.ToString());
            atributoPrimario.Text = entidadClave.Atributos.First(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria).Nombre;
        }
    }
}
