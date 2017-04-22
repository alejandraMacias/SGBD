using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Entidad
    {
        public List<Atributo> listaAtributo;

        public Entidad()
        {
            listaAtributo = new List<Atributo>();
        }
    }
}
