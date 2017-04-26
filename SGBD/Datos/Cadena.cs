using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Cadena : Atributo
    {
        public Cadena(string nombre, string tipo, int longitud, Diccionario.ClaveAtributo tipoClave)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.longitud = longitud;
            this.tipoClave = tipoClave;
        }
    }
}
