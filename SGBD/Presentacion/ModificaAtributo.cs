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
    public partial class ModificaAtributo : Form
    {
        private Diccionario.ClaveAtributo claveAtributo;
        private Diccionario.TipoAtributo tipoAtributo;
        private Diccionario diccionarioDatos = Diccionario.Instancia;
        private Entidad entidadClave;

        public ModificaAtributo()
        {
            InitializeComponent();
            seleccionEntidad.DataSource = diccionarioDatos.Entidades.FindAll(e => e.Atributos.ToList().FindAll(a => a.TipoClave != Diccionario.ClaveAtributo.Primaria).Count > 0);
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
            diccionarioDatos.ModificaAtributo(entidadActual, seleccionAtributo.SelectedItem as Atributo, tipoAtributo, claveAtributo, entidadClave, (int)longitud.Value);
        }

        private void seleccionEntidadReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            entidadClave = diccionarioDatos.Entidades.Find(entidad => entidad.Nombre == seleccionEntidadReferencia.SelectedItem.ToString());
            atributoPrimario.Text = entidadClave.Atributos.First(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria).Nombre;
        }

        private void seleccionEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidad entidadSeleccionada = (seleccionEntidad.SelectedItem as Entidad);
            Atributo atributoPrimario = entidadSeleccionada.Atributos.FirstOrDefault(a => a.TipoClave == Diccionario.ClaveAtributo.Primaria);

            seleccionAtributo.DataSource = entidadSeleccionada.Atributos.ToList().FindAll(a => a.TipoClave != Diccionario.ClaveAtributo.Primaria);
            if ((seleccionAtributo.DataSource as List<Atributo>).Count == 0)
            {
                seleccionAtributo.Text = string.Empty;
            }
            if (atributoPrimario != null)
            {
                clavePrimaria.Enabled = false;
            }
            else
            {
                clavePrimaria.Enabled = true;
            }
        }

        private void seleccionAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atributo atributoSeleccionado = seleccionAtributo.SelectedItem as Atributo;

            if (atributoSeleccionado != null)
            {
                switch (atributoSeleccionado.Tipo)
                {
                    case Diccionario.TipoAtributo.Entero:
                        opcionEntero.Checked = true;
                        break;
                    case Diccionario.TipoAtributo.Flotante:
                        opcionFlotante.Checked = true;
                        break;
                    case Diccionario.TipoAtributo.Caracter:
                        opcionCaracter.Checked = true;
                        break;
                    case Diccionario.TipoAtributo.Cadena:
                        Cadena.Checked = true;
                        break;
                }
                longitud.Value = atributoSeleccionado.Longitud;
                switch (atributoSeleccionado.TipoClave)
                {
                    case Diccionario.ClaveAtributo.SinClave:
                        claveNO.Checked = true;
                        break;
                    case Diccionario.ClaveAtributo.Primaria:
                        clavePrimaria.Checked = true;
                        break;
                    case Diccionario.ClaveAtributo.Foranea:
                        claveForanea.Checked = true;
                        break;
                }
                if (atributoSeleccionado.ClaveForanea != null)
                {
                    seleccionEntidadReferencia.SelectedItem = atributoSeleccionado.ClaveForanea;
                }
            }
        }
    }
}
