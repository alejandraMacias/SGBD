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
        protected string tipo;
        protected int longitud;
        protected Diccionario.ClaveAtributo tipoClave;

        public string Nombre { get { return nombre; } }
        public string Tipo { get { return tipo; } }
        public int Longitud { get { return longitud; } }
        public Diccionario.ClaveAtributo TipoClave { get { return tipoClave; } }

        public void ActualizaNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void ActualizaTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
