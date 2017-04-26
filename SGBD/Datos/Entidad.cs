using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    [Serializable()]
    class Entidad
    {
        private LinkedList<Atributo> atributos;
        public string Nombre { get; set; }

        public LinkedList<Atributo> Atributos { get { return atributos; } }

        public Entidad(string nombre)
        {
            Nombre = nombre;
            atributos = new LinkedList<Atributo>();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
