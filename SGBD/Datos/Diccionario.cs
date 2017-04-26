using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBD.Datos
{
    // Argumentos para el evento de actualización.
    public class ActualizacionEntidadEventArgs : EventArgs
    {
        private string mensaje;

        public ActualizacionEntidadEventArgs(string mensaje)
        {
            this.mensaje = mensaje;
        }

        /// <summary>
        /// Indica la acción realizada sobre la entidad.
        /// </summary>
        public string Mensaje { get { return mensaje; } }
    }

    class Diccionario: IDisposable
    {
        private static readonly Lazy<Diccionario> lazy = new Lazy<Diccionario>(() => new Diccionario());
        public static Diccionario Instancia { get { return lazy.Value; } }

        private SqlConnection coneccion;        
        private List<Entidad> listaEntidad;
        private string nombre;

        /// <summary>
        /// Claves válidas para un atributo.
        /// </summary>
        public enum Clave
        {
            Primaria,
            Foranea
        }
        /// <summary>
        /// Nombre del diccionario.
        /// </summary>
        public string Nombre { get { return nombre; } }
        /// <summary>
        /// Entidades contenidas dentro del diccionario.
        /// </summary>
        public List<Entidad> Entidades { get { return listaEntidad; } }
        /// <summary>
        /// Provocado al actualizarse una entidad en el diccionario.
        /// </summary>
        public event EventHandler<ActualizacionEntidadEventArgs> ActualizacionEntidad;

        private Diccionario()
        {
            listaEntidad = new List<Entidad>();
            // Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;
            // Data Source=BECARIOS-PC\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True;
            // Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True
            coneccion = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;Connect Timeout=10");
            coneccion.Open();
        }

        /// <summary>
        /// Provocado al actualizarse una entidad en el diccionario de datos.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnActualizacionEntidad(ActualizacionEntidadEventArgs e)
        {
            EventHandler<ActualizacionEntidadEventArgs> handler = ActualizacionEntidad;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void Abrir(string nombre, List<Entidad> entidades)
        {
            // Asignación del nombre del diccionario.
            this.nombre = nombre;
            // Asignación de entidades.
            listaEntidad = entidades;
        }

        public void Crear(string nombre)
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

        public bool AltaEntidad(string nombre)
        {
            bool resultado;

            listaEntidad.Add(new Entidad(nombre));
            resultado = true;

            Stream stream = File.Open(this.nombre + ".db", FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, Entidades);
            stream.Close();

            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} agregada", nombre)));
            return resultado;
        }

        public bool BajaEntidad(string nombre)
        {
            bool resultado;
            Entidad entidadAEliminar = listaEntidad.Find(e => e.Nombre == nombre);

            if (entidadAEliminar != null)
            {
                listaEntidad.Remove(entidadAEliminar);
                resultado = true;

                Stream stream = File.Open(this.nombre + ".db", FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Entidades);
                stream.Close();
            }
            else
            {
                resultado = false;
            }

            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} eliminada", nombre)));
            return resultado;
        }

        public bool ModificaEntidad(string nombre, string nuevoNombre)
        {
            bool resultado;
            Entidad entidadAModificar = listaEntidad.Find(e => e.Nombre == nombre);

            if (entidadAModificar != null)
            {
                entidadAModificar.Nombre = nuevoNombre;
                resultado = true;

                Stream stream = File.Open(this.nombre + ".db", FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Entidades);
                stream.Close();
            }
            else
            {
                resultado = false;
            }

            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} modificada", nombre)));
            return resultado;
        }

        public void Dispose()
        {
            coneccion.Close();
            coneccion.Dispose();
        }
    }
}
