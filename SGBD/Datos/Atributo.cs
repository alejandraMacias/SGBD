using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    [Serializable()]
    class Atributo
    {
        public string nom;
        public int tipo;
        public int tam;
        public string tipoClave;
    }
}
