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
        private static readonly Lazy<Diccionario> lazy = new Lazy<Diccionario>(() => new Diccionario());
        public static Diccionario Instancia { get { return lazy.Value; } }

        private SqlConnection coneccion;        
        public List<Entidad> listaEntidad;
        private string nombre;

        /// <summary>
        /// Nombre del diccionario.
        /// </summary>
        public string Nombre { get { return nombre; } }

        private Diccionario()
        {
            listaEntidad = new List<Entidad>();
            // Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;
            // Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;
            coneccion = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;");
            coneccion.Open();
        }

        public void Crea(string nombre)
        {
            StringBuilder cadenaEliminacionEsquema = new StringBuilder();
            SqlCommand sentenciaEliminarEsquema;
            SqlCommand sentenciaCrearEsquema;

            // Construcción de la cadena empleada para eliminar el diccionario de datos en caso de existir.
            cadenaEliminacionEsquema.Append("IF EXISTS (SELECT * FROM sys.schemas WHERE name = '{0}')");
            cadenaEliminacionEsquema.Append("BEGIN EXEC('DROP SCHEMA {0}') END");
            // Inicialización de los comandos empleados para crear el diccionario.
            sentenciaEliminarEsquema = new SqlCommand(string.Format(cadenaEliminacionEsquema.ToString(), nombre), coneccion);
            sentenciaCrearEsquema = new SqlCommand(string.Format("create schema {0}", nombre), coneccion);
            // Asignación del nombre del diccionario.
            this.nombre = nombre;
            // Eliminacón de entidades de la lista.
            listaEntidad.Clear();
            // Ejecución de sentencias.
            sentenciaEliminarEsquema.ExecuteNonQuery();
            sentenciaCrearEsquema.ExecuteNonQuery();
        }

        public void Dispose()
        {
            coneccion.Close();
            coneccion.Dispose();
        }
    }
}
