using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    [Serializable()]
    class Cadena : Atributo
    {
        public Cadena(string nombre, Diccionario.TipoAtributo tipoAtributo,
            Diccionario.ClaveAtributo tipoClave, int longitud, Entidad claveForanea)
        {
            this.nombre = nombre;
            this.tipoAtributo = tipoAtributo;
            this.longitud = longitud;
            this.tipoClave = tipoClave;
            this.claveForanea = claveForanea;
        }
    }
}
