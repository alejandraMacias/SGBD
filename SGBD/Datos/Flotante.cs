using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Flotante : Atributo
    {
        public Flotante(string nombre, string tipo, Diccionario.ClaveAtributo tipoClave) 
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.longitud = 8;
            this.tipoClave = tipoClave;
        }
    }
}
