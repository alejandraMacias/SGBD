using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Caracter : Atributo
    {
        public Caracter(string nombre, string tipo, Diccionario.ClaveAtributo tipoClave)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.longitud = 1;
            this.tipoClave = tipoClave;
        }
    }
}
