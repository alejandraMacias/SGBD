using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    [Serializable()]
    abstract class Atributo
    {
        protected string nombre;
        protected Diccionario.TipoAtributo tipoAtributo;
        protected int longitud;
        protected Diccionario.ClaveAtributo tipoClave;
        protected Entidad claveForanea;

        /// <summary>
        /// Nombre de atributo.
        /// </summary>
        public string Nombre { get { return nombre; } }

        public Diccionario.TipoAtributo Tipo { get { return tipoAtributo; } }
        public int Longitud { get { return longitud; } }
        public Diccionario.ClaveAtributo TipoClave { get { return tipoClave; } }
        public Entidad ClaveForanea { get { return claveForanea; } }

        public void ActualizaNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void ActualizaTipo(Diccionario.TipoAtributo tipoAtributo)
        {
            this.tipoAtributo = tipoAtributo;
        }

        public void ActualizaClave(Diccionario.ClaveAtributo tipoClave)
        {
            this.tipoClave = tipoClave;
        }

        public void ActualizaLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        public void ActualizaClaveForanea(Entidad clave)
        {
            this.claveForanea = clave;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
