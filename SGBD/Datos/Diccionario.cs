using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBD.Datos
{
    /// <summary>
    ///  Argumentos para el evento de actualización.
    /// </summary>
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

    /// <summary>
    ///  Argumentos para el evento de actualización.
    /// </summary>
    public class ActualizacionAtributoEventArgs : EventArgs
    {
        private string mensaje;

        public ActualizacionAtributoEventArgs(string mensaje)
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
        public enum ClaveAtributo
        {
            SinClave,
            Primaria,
            Foranea
        }
        /// <summary>
        /// Tipos de datos.
        /// </summary>
        public enum TipoAtributo
        {
            Entero,
            Flotante,
            Caracter,
            Cadena
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
        /// <summary>
        /// Provocado al actualizarse una entidad en el diccionario.
        /// </summary>
        public event EventHandler<ActualizacionAtributoEventArgs> ActualizacionAtributo;

        private Diccionario()
        {
            listaEntidad = new List<Entidad>();
            // Data Source=AM-PC;Initial Catalog=Database;Integrated Security=True;
            // Data Source=BECARIOS-PC\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True;
            // Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True
            coneccion = new SqlConnection(@"Data Source=DESKTOP-VQ4NJNJ;Initial Catalog=Database;Integrated Security=True;");
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

        /// <summary>
        /// Provocado al actualizarse una entidad en el diccionario de datos.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnActualizacionAtributo(ActualizacionAtributoEventArgs e)
        {
            EventHandler<ActualizacionAtributoEventArgs> handler = ActualizacionAtributo;
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

        /// <summary>
        ///  Funcion que da de alta una entidad y la añade a una lista de entidades
        /// </summary>
        public bool AltaEntidad(string nombre)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            SqlCommand sentencia;
            
            // Construcción de la cadena empleada para crear la entidad.
            cadenaSentencia.Append("CREATE TABLE {0}(_id bigint identity)");
            // Inicialización de los comandos empleados para crear la entidad.
            sentencia = new SqlCommand(string.Format(cadenaSentencia.ToString(), nombre), coneccion);
            // Ejecución de sentencias.
            sentencia.ExecuteNonQuery();
            // Adición de entidad a la lista de entidades.
            listaEntidad.Add(new Entidad(nombre));

            resultado = true;
            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} agregada", nombre)));
            return resultado;
        }

        /// <summary>
        ///  Funcion que da de baja o elimina una entidad 
        ///  Si la entidad a eliminar es encontrada es removida
        /// </summary>
        public bool BajaEntidad(string nombre)
        {
            bool resultado;
            Entidad entidadAEliminar = listaEntidad.Find(e => e.Nombre == nombre);

            if (entidadAEliminar != null)
            {
                StringBuilder cadenaSentencia = new StringBuilder();
                SqlCommand sentencia;

                // Construcción de la cadena empleada para eliminar la entidad.
                cadenaSentencia.Append("DROP TABLE {0}");
                // Inicialización de los comandos empleados para eliminar la entidad.
                sentencia = new SqlCommand(string.Format(cadenaSentencia.ToString(), nombre), coneccion);
                // Ejecución de sentencias.
                sentencia.ExecuteNonQuery();

                listaEntidad.Remove(entidadAEliminar);
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} eliminada", nombre)));
            return resultado;
        }

        /// <summary>
        ///  Funcion que da modifica una entidad 
        /// </summary>
        public bool ModificaEntidad(string nombre, string nuevoNombre)
        {
            bool resultado;
            Entidad entidadAModificar = listaEntidad.Find(e => e.Nombre == nombre);

            if (entidadAModificar != null)
            {
                StringBuilder cadenaSentencia = new StringBuilder();
                SqlCommand sentencia;

                // Construcción de la cadena empleada para modificar la entidad.
                cadenaSentencia.Append("EXEC sp_rename '{0}', '{1}'");
                // Inicialización de los comandos empleados para modificar la entidad.
                sentencia = new SqlCommand(string.Format(cadenaSentencia.ToString(), nombre, nuevoNombre), coneccion);
                // Ejecución de sentencias.
                sentencia.ExecuteNonQuery();

                entidadAModificar.Nombre = nuevoNombre;
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} modificada", nombre)));
            return resultado;
        }

        /// <summary>
        ///  Funcion que da de alta un atributo 
        /// </summary>
        public bool AltaAtributo(Entidad entidadActual, string nombreAtributo, TipoAtributo tipoAtributo, ClaveAtributo clave, Entidad entidadClave, int longitud)
        {
            bool resultado;
            Atributo atributoNuevo = null;
            StringBuilder cadenaSentencia = new StringBuilder();
            SqlCommand sentencia;

            switch (tipoAtributo)
            {
                case TipoAtributo.Entero:
                    atributoNuevo = new Entero(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                    // Construcción de la cadena empleada para agregar el atributo.
                    cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} bigint {2}",
                        entidadActual.Nombre,
                        nombreAtributo,
                        clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                        );
                    if (entidadClave != null)
                    {
                        cadenaSentencia.AppendFormat("; ALTER TABLE {0} ADD CONSTRAINT FK_{1}_{0} FOREIGN KEY ({4}) REFERENCES {2}({3})",
                            entidadActual.Nombre,
                            nombreAtributo,
                            entidadClave.Nombre,
                            entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                            nombreAtributo
                            );
                    }
                    sentencia = new SqlCommand(cadenaSentencia.ToString(), coneccion);
                    // Ejecución de sentencias.
                    sentencia.ExecuteNonQuery();
                    break;
                case TipoAtributo.Flotante:
                    atributoNuevo = new Flotante(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                    // Construcción de la cadena empleada para agregar el atributo.
                    cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} decimal {2}",
                        entidadActual.Nombre,
                        nombreAtributo,
                        clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                        );
                    if (entidadClave != null)
                    {
                        cadenaSentencia.AppendFormat("; ALTER TABLE {0} ADD CONSTRAINT FK_{1}_{0} FOREIGN KEY ({4}) REFERENCES {2}({3})",
                            entidadActual.Nombre,
                            nombreAtributo,
                            entidadClave.Nombre,
                            entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                            nombreAtributo
                            );
                    }
                    sentencia = new SqlCommand(cadenaSentencia.ToString(), coneccion);
                    // Ejecución de sentencias.
                    sentencia.ExecuteNonQuery();
                    break;
                case TipoAtributo.Caracter:
                    atributoNuevo = new Caracter(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                    // Construcción de la cadena empleada para agregar el atributo.
                    cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} nvarchar(1) {2}",
                        entidadActual.Nombre,
                        nombreAtributo,
                        clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                        );
                    if (entidadClave != null)
                    {
                        cadenaSentencia.AppendFormat("; ALTER TABLE {0} ADD CONSTRAINT FK_{1}_{0} FOREIGN KEY ({4}) REFERENCES {2}({3})",
                            entidadActual.Nombre,
                            nombreAtributo,
                            entidadClave.Nombre,
                            entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                            nombreAtributo
                            );
                    }
                    sentencia = new SqlCommand(cadenaSentencia.ToString(), coneccion);
                    // Ejecución de sentencias.
                    sentencia.ExecuteNonQuery();
                    break;
                case TipoAtributo.Cadena:
                    atributoNuevo = new Cadena(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                    // Construcción de la cadena empleada para agregar el atributo.
                    cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1}  nvarchar({3}) {2}",
                        entidadActual.Nombre,
                        nombreAtributo,
                        clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : "",
                        longitud
                        );
                    if (entidadClave != null)
                    {
                        cadenaSentencia.AppendFormat("; ALTER TABLE {0} ADD CONSTRAINT FK_{1}_{0} FOREIGN KEY ({4}) REFERENCES {2}({3})",
                            entidadActual.Nombre,
                            nombreAtributo,
                            entidadClave.Nombre,
                            entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                            nombreAtributo
                            );
                    }
                    sentencia = new SqlCommand(cadenaSentencia.ToString(), coneccion);
                    // Ejecución de sentencias.
                    sentencia.ExecuteNonQuery();
                    break;
            }
            entidadActual.Atributos.AddLast(atributoNuevo);
            resultado = true;
            OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} agregado", nombreAtributo)));
            return resultado;
        }

        /// <summary>
        ///  Funcion que da de baja un atributo 
        /// </summary>
        public bool BajaAtributo(Entidad entidadActual, Atributo atributoAEliminar)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            SqlCommand sentencia;

            // Construcción de la cadena empleada para modificar la entidad.
            cadenaSentencia.Append("ALTER TABLE {0} DROP COLUMN {1} ");
            // Inicialización de los comandos empleados para modificar la entidad.
            sentencia = new SqlCommand(string.Format(cadenaSentencia.ToString(), entidadActual.Nombre, atributoAEliminar.Nombre), coneccion);
            // Ejecución de sentencias.
            sentencia.ExecuteNonQuery();

            entidadActual.Atributos.Remove(atributoAEliminar);
            resultado = true;
            OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} eliminado", atributoAEliminar.Nombre)));
            return resultado;
        }

        /// <summary>
        ///  Funcion que da de alta un atributo 
        /// </summary>
        public bool ModificaAtributo(Entidad entidadActual, Atributo atributoAModificar, TipoAtributo tipoAtributo, ClaveAtributo clave, Entidad entidadClave, int longitud)
        {
            bool resultado;

            this.BajaAtributo(entidadActual, atributoAModificar);
            this.AltaAtributo(entidadActual, atributoAModificar.Nombre, tipoAtributo, clave, entidadClave, longitud);

            resultado = true;
            OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} modificado", atributoAModificar.Nombre)));
            return resultado;
        }

        public bool AltaDato(Entidad entidad, List<Control> controles)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            SqlCommand sentencia;

            // Construcción de la cadena empleada para modificar la entidad.
            cadenaSentencia.Append("INSERT INTO {0} VALUES (");
            foreach(Control control in controles)
            {
                if(control is TextBox) 
                {
                    var valor = (control as TextBox).Text;
                    cadenaSentencia.Append("'" + valor + "',");
                }
                else if (control is NumericUpDown)
                {
                    var valor = (control as NumericUpDown).Value.ToString();
                    cadenaSentencia.Append("'" + valor + "',");
                }
            }
            cadenaSentencia.Remove(cadenaSentencia.Length - 1, 1);
            cadenaSentencia.Append(")");
            // Inicialización de los comandos empleados para modificar la entidad.
            sentencia = new SqlCommand(string.Format(cadenaSentencia.ToString(), entidad.Nombre), coneccion);
            // Ejecución de sentencias.
            sentencia.ExecuteNonQuery();

            resultado = true;
            return resultado;
        }

        public DataTable ConsultaTodo(Entidad entidad)
        {
            StringBuilder consulta = new StringBuilder();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataSet ds = new DataSet();

            consulta.AppendFormat("SELECT * FROM {0}", entidad.Nombre);
            SqlCommand cmd = new SqlCommand(consulta.ToString(), coneccion);

            try
            {
                adaptador.SelectCommand = cmd;
                adaptador.Fill(ds);
                adaptador.Dispose();
                cmd.Dispose();
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Consulta(string consulta)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(consulta, coneccion);

            try
            {
                adaptador.SelectCommand = cmd;
                adaptador.Fill(ds);
                adaptador.Dispose();
                cmd.Dispose();
                return ds.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Sentencia(string sentencia)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(sentencia, coneccion);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Libera todos los recursos utilizados por el objeto
        /// </summary>
        public void Dispose()
        {
            coneccion.Close();
            coneccion.Dispose();
        }
    }
}
