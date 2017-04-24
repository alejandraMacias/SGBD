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
        public List<Atributo> listaAtributo;
        private string nombre;

        public string Nombre { get { return nombre; } }

        public Entidad(string nombre)
        {
            this.nombre = nombre;
            listaAtributo = new List<Atributo>();
        }
    }
}
