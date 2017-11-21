using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
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

        private OleDbConnection coneccion;        
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
        /// <summary>
        /// Database conection String.
        /// </summary>
        private string db;

        private Diccionario()
        {
            listaEntidad = new List<Entidad>();
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


        /// <summary>
        /// Abre un archivo existente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="entidades"></param>
        public void Abrir(string nombre, List<Entidad> entidades)
        {
            TryColse();
            // Asignación del nombre del diccionario.
            this.nombre = nombre;
            // Asignación de entidades.
            listaEntidad = entidades;
            // Abrir conexion a la BD.
            db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + nombre + "/basedatos.accdb;";
            coneccion = new OleDbConnection(db);
            coneccion.Open();
        }


        /// <summary>
        /// Crea un nuevo archivo
        /// </summary>
        /// <param name="nombre"></param>
        public void Crear(string nombre)
        {
            bool exists = System.IO.Directory.Exists(nombre);

            TryColse();
            if (exists)
            {
                System.IO.Directory.Delete(nombre, true);
            }
            System.IO.Directory.CreateDirectory(nombre);
            System.IO.File.Copy("basedatos.accdb", nombre + "/basedatos.accdb", true);
            // Asignación del nombre del diccionario.
            this.nombre = nombre;
            // Eliminacón de entidades de la lista.
            listaEntidad.Clear();
            // Abrir conexion a la BD.
            db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + nombre + "/basedatos.accdb;";
            coneccion = new OleDbConnection(db);
            coneccion.Open();
        }


        /// <summary>
        /// Elimina un archivo existente
        /// </summary>
        /// <param name="nombre"></param>
        public void Eliminar(string nombre)
        {
            bool exists = System.IO.Directory.Exists(nombre);

            if (exists)
            {
                if(nombre == this.nombre)
                {
                    TryColse();
                }
                System.IO.Directory.Delete(nombre, true);
            }
            if (nombre == this.nombre)
            {
                // Asignación del nombre del diccionario.
                this.nombre = string.Empty;
                // Eliminacón de entidades de la lista.
                listaEntidad.Clear();
            }
         }

        /// <summary>
        ///  Funcion que da de alta una entidad y la añade a una lista de entidades
        /// </summary>
        public bool AltaEntidad(string nombre)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            OleDbCommand sentencia;

            try
            {
                // Construcción de la cadena empleada para crear la entidad.
                cadenaSentencia.Append("CREATE TABLE {0}([_id] COUNTER)");
                // Inicialización de los comandos empleados para crear la entidad.
                sentencia = new OleDbCommand(string.Format(cadenaSentencia.ToString(), nombre), coneccion);
                // Ejecución de sentencias.
                sentencia.ExecuteNonQuery();
                // Adición de entidad a la lista de entidades.
                listaEntidad.Add(new Entidad(nombre));

                resultado = true;
                OnActualizacionEntidad(new ActualizacionEntidadEventArgs(string.Format("Entidad {0} agregada", nombre)));
            }
            catch(Exception)
            {
                resultado = false;
                // MessageBox.Show("No se pudo crear la tabla, verifique su existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                if (entidadAEliminar != null)
                {
                    StringBuilder cadenaSentencia = new StringBuilder();
                    OleDbCommand sentencia;

                    // Construcción de la cadena empleada para eliminar la entidad.
                    cadenaSentencia.Append("DROP TABLE {0}");
                    // Inicialización de los comandos empleados para eliminar la entidad.
                    sentencia = new OleDbCommand(string.Format(cadenaSentencia.ToString(), nombre), coneccion);
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
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        /// <summary>
        ///  Funcion que da modifica una entidad 
        /// </summary>
        public bool ModificaEntidad(string nombre, string nuevoNombre)
        {
            bool resultado;
            Entidad entidadAModificar = listaEntidad.Find(e => e.Nombre == nombre);

            try
            {
                if (entidadAModificar != null)
                {
                    StringBuilder cadenaSentencia = new StringBuilder();
                    OleDbCommand sentencia;

                    // Construcción de la cadena empleada para modificar la entidad.
                    cadenaSentencia.Append("EXEC sp_rename '{0}', '{1}'");
                    // Inicialización de los comandos empleados para modificar la entidad.
                    sentencia = new OleDbCommand(string.Format(cadenaSentencia.ToString(), nombre, nuevoNombre), coneccion);
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
            }
            catch (Exception)
            {
                resultado = false;
            }
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
            OleDbCommand sentencia;

            #region Seleccion de tipo de atributo e inserccion de datos a la BD
            try
            {
                switch (tipoAtributo)
                {
                    case TipoAtributo.Entero:
                        atributoNuevo = new Entero(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                        // Construcción de la cadena empleada para agregar el atributo.
                        cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} NUMBER {2}",
                            entidadActual.Nombre,
                            nombreAtributo,
                            clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                            );
                        sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                        // Ejecución de sentencias.
                        sentencia.ExecuteNonQuery();
                        if (entidadClave != null)
                        {
                            cadenaSentencia.Clear();
                            cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD FOREIGN KEY ({4}) REFERENCES {2}({3})",
                                entidadActual.Nombre,
                                nombreAtributo,
                                entidadClave.Nombre,
                                entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                                nombreAtributo
                                );
                            sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                            // Ejecución de sentencias.
                            sentencia.ExecuteNonQuery();
                        }
                        break;
                    case TipoAtributo.Flotante:
                        atributoNuevo = new Flotante(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                        // Construcción de la cadena empleada para agregar el atributo.
                        cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} CURRENCY {2}",
                            entidadActual.Nombre,
                            nombreAtributo,
                            clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                            );
                        sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                        // Ejecución de sentencias.
                        sentencia.ExecuteNonQuery();
                        if (entidadClave != null)
                        {
                            cadenaSentencia.Clear();
                            cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD FOREIGN KEY ({4}) REFERENCES {2}({3})",
                                entidadActual.Nombre,
                                nombreAtributo,
                                entidadClave.Nombre,
                                entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                                nombreAtributo
                                );
                            sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                            // Ejecución de sentencias.
                            sentencia.ExecuteNonQuery();
                        }
                        break;
                    case TipoAtributo.Caracter:
                        atributoNuevo = new Caracter(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                        // Construcción de la cadena empleada para agregar el atributo.
                        cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1} TEXT {2}",
                            entidadActual.Nombre,
                            nombreAtributo,
                            clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                            );
                        sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                        // Ejecución de sentencias.
                        sentencia.ExecuteNonQuery();
                        if (entidadClave != null)
                        {
                            cadenaSentencia.Clear();
                            cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD FOREIGN KEY ({4}) REFERENCES {2}({3})",
                                entidadActual.Nombre,
                                nombreAtributo,
                                entidadClave.Nombre,
                                entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                                nombreAtributo
                                );
                            sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                            // Ejecución de sentencias.
                            sentencia.ExecuteNonQuery();
                        }
                        break;
                    case TipoAtributo.Cadena:
                        atributoNuevo = new Cadena(nombreAtributo, tipoAtributo, clave, longitud, entidadClave);
                        // Construcción de la cadena empleada para agregar el atributo.
                        cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD {1}  TEXT {2}",
                            entidadActual.Nombre,
                            nombreAtributo,
                            clave == ClaveAtributo.Primaria ? "PRIMARY KEY" : ""
                            );
                        sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                        // Ejecución de sentencias.
                        sentencia.ExecuteNonQuery();
                        if (entidadClave != null)
                        {
                            cadenaSentencia.Clear();
                            cadenaSentencia.AppendFormat("ALTER TABLE {0} ADD FOREIGN KEY ({4}) REFERENCES {2}({3})",
                                entidadActual.Nombre,
                                nombreAtributo,
                                entidadClave.Nombre,
                                entidadClave.Atributos.FirstOrDefault(a => a.TipoClave == ClaveAtributo.Primaria).Nombre,
                                nombreAtributo
                                );
                            sentencia = new OleDbCommand(cadenaSentencia.ToString(), coneccion);
                            // Ejecución de sentencias.
                            sentencia.ExecuteNonQuery();
                        }
                        break;
                }
                #endregion
                entidadActual.Atributos.AddLast(atributoNuevo);
                resultado = true;
                OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} agregado", nombreAtributo)));
            }
            catch (Exception)
            {
                resultado = false;
            }
                return resultado;
        }

        /// <summary>
        ///  Funcion que da de baja un atributo 
        /// </summary>
        public bool BajaAtributo(Entidad entidadActual, Atributo atributoAEliminar)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            OleDbCommand sentencia;

            try
            {
                // Construcción de la cadena empleada para modificar la entidad.
                cadenaSentencia.Append("ALTER TABLE {0} DROP COLUMN {1} ");
                // Inicialización de los comandos empleados para modificar la entidad.
                sentencia = new OleDbCommand(string.Format(cadenaSentencia.ToString(), entidadActual.Nombre, atributoAEliminar.Nombre), coneccion);
                // Ejecución de sentencias.
                sentencia.ExecuteNonQuery();

                entidadActual.Atributos.Remove(atributoAEliminar);
                resultado = true;
                OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} eliminado", atributoAEliminar.Nombre)));
            }
            catch (Exception)
            {
                resultado = false;
            }
                return resultado;
        }

        /// <summary>
        ///  Funcion que da de alta un atributo 
        /// </summary>
        public bool ModificaAtributo(Entidad entidadActual, Atributo atributoAModificar, TipoAtributo tipoAtributo, ClaveAtributo clave, Entidad entidadClave, int longitud)
        {
            bool resultado;

            try
            {
                this.BajaAtributo(entidadActual, atributoAModificar);
                this.AltaAtributo(entidadActual, atributoAModificar.Nombre, tipoAtributo, clave, entidadClave, longitud);

                resultado = true;
                OnActualizacionAtributo(new ActualizacionAtributoEventArgs(string.Format("Atributo {0} modificado", atributoAModificar.Nombre)));
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public bool AltaDato(Entidad entidad, List<Control> controles)
        {
            bool resultado;
            StringBuilder cadenaSentencia = new StringBuilder();
            OleDbCommand sentencia;

            try
            {
                // Construcción de la cadena empleada para modificar la entidad.
                cadenaSentencia.Append("INSERT INTO {0} (" + ParametrisaAtributos(entidad.Nombre) + ") VALUES (");
                foreach (Control control in controles)
                {
                    if (control is TextBox)
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
                sentencia = new OleDbCommand(string.Format(cadenaSentencia.ToString(), entidad.Nombre), coneccion);
                // Ejecución de sentencias.
                sentencia.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public DataTable ConsultaTodo(Entidad entidad)
        {
            StringBuilder consulta = new StringBuilder();
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            consulta.AppendFormat("SELECT * FROM {0}", entidad.Nombre);
            OleDbCommand cmd = coneccion.CreateCommand();

            try
            {
                cmd.CommandText = consulta.ToString();
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
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand(consulta, coneccion);

            try
            {
                adaptador.SelectCommand = cmd;
                adaptador.Fill(ds);
                adaptador.Dispose();
                cmd.Dispose();
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Sentencia(string sentencia)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(sentencia, coneccion);

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
        /// Funcion en donde se validan las consultas
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public string ValidaConsulta(string consulta)
        {
            string resultado = "Consulta no válida, error léxico";
            string entrada = new Regex(@"[\s]{1,}").Replace(consulta, " ");
            string patron = @"^SELECT \* FROM (" + ObtenEntidades() + ")$";

            if(Regex.IsMatch(entrada.ToUpper(), patron.ToUpper()))
            { 
                resultado = string.Empty;
            }
            else
            {
                var atributos = ObtenAtributos();
                patron = @"^SELECT (" + atributos + @")(,(" + atributos + "))* FROM (" + ObtenEntidades() + ")$";
                if (Regex.IsMatch(entrada.ToUpper(), patron.ToUpper()))
                {
                    resultado = string.Empty;
                }
                else
                {
                    var clavesPrimarias = ObtenAtributosPrimarios();
                    patron = @"^SELECT (" + atributos + @")(,(" + atributos + "))* FROM (" + ObtenEntidades() + @") WHERE (" + clavesPrimarias + @") = [0-9]+$";
                    if (Regex.IsMatch(entrada.ToUpper(), patron.ToUpper()))
                    {
                        resultado = string.Empty;
                    }
                }
            }
                
            return resultado;
        }
        
        /// <summary>
        /// Funcion en donde se obtiene la entdad que se va a comparar al validar la consultas 
        /// select * From nombreTabla
        /// </summary>
        /// <returns></returns>
        private string ObtenEntidades()
        {
            string resultado = string.Empty;

            foreach(var entidad in listaEntidad)
            {
                resultado += entidad.Nombre.Replace(" ", "") + @"|";
            }
            resultado = resultado.Substring(0, resultado.Length - 1);
            return resultado;
        }
  
        /// <summary>
        /// Funcion en donde se obiene el atributo para la comparacion de al validar la consulta
        /// SELECT (lista de columnas1, lista de columnas2) FROM NombreTabla
        /// </summary>
        /// <param name="nombreEntidad"></param>
        /// <returns></returns>
        private string ObtenAtributos()
        {
            string resultado = string.Empty;
            foreach(var entidad in listaEntidad)
            {
                if (entidad != null)
                {
                    foreach (var atributo in entidad.Atributos)
                    {
                        resultado += atributo.Nombre + @"|";
                    }
                }
            }
            resultado = resultado.Substring(0, resultado.Length - 1);
            return resultado;
        }

        private string ObtenAtributosPrimarios()
        {
            string resultado = string.Empty;
            foreach (var entidad in listaEntidad)
            {
                if (entidad != null)
                {
                    foreach (var atributo in entidad.Atributos)
                    {
                        if(atributo.TipoClave == ClaveAtributo.Primaria)
                        {
                            resultado += atributo.Nombre + @"|";
                        }
                    }
                }
            }
            resultado = resultado.Substring(0, resultado.Length - 1);
            return resultado;
        }

        private string ParametrisaAtributos(string nombreEntidad)
        {
            string resultado = string.Empty;
            var entidad = listaEntidad.FirstOrDefault(m => m.Nombre.ToUpper() == nombreEntidad.ToUpper());

            if (entidad != null)
            {
                foreach (var atributo in entidad.Atributos)
                {
                    resultado += "[" + atributo.Nombre + @"],";
                }
            }
            if(resultado != string.Empty)
            {
                resultado = resultado.Substring(0, resultado.Length - 1);
            }
            return resultado;
        }

        /// <summary>
        /// Libera todos los recursos utilizados por el objeto
        /// </summary>
        public void Dispose()
        {
            try
            {
                coneccion.Close();
                coneccion.Dispose();
            }
            catch (Exception) { }
        }

        private void TryColse()
        {
            try
            {
                coneccion.Close();
                coneccion.Dispose();
            }
            catch (Exception) { }
        }
    }
}
