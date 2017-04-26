using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Entero : Atributo
    {
        public Entero(string nombre, string tipo, Diccionario.Clave tipoClave)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.longitud = 4;
            this.tipoClave = tipoClave;
        }
    }
}
