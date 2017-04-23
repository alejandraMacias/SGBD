using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBD.Datos
{
    class Diccionario: IDisposable
    {
        private static readonly Lazy<Diccionario> lazy =
        new Lazy<Diccionario>(() => new Diccionario());
        private SqlConnection coneccion;

        public static Diccionario Instancia { get { return lazy.Value; } }
        
        public List<Entidad> listaEntidad;

        private Diccionario()
        {
            listaEntidad = new List<Entidad>();
            // Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;
            // Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True
            coneccion = new SqlConnection(@"Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;");
            coneccion.Open();
        }

        public string EjecutaPrueba()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from test", coneccion);

            return cmd.ExecuteScalar().ToString();
        }

        public void Dispose()
        {
            coneccion.Close();
            coneccion.Dispose();
        }
    }
}
