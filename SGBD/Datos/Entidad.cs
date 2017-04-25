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
        public string Nombre { get; set; }

        public Entidad(string nombre)
        {
            Nombre = nombre;
            listaAtributo = new List<Atributo>();
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
