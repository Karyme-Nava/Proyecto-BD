using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.POJOS;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoBD.BACKEND
{
    class clsDaoProblemas
    {
        public bool EliminarProblema(String p)
        {
            MySqlCommand delete = new MySqlCommand(
                @"delete from Problemas where IDProblema = @id"
                );

            delete.Parameters.AddWithValue("@id", p);
            int resultado = Conexion.ejecutarSentencia(delete);
            return (resultado > 0);

            /*MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=11863"; //Actualizar
            conexion.Open();

            string cadena = "delete from Problemas where IDProblema = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", p);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
            return true;*/
        }

        public bool InsertarProblema(clsProblemas p)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=18194"; //Actualizar
            conexion.Open();

            string cadena = @"insert into Problemas (Nombre, Descripcion, Solucion, IDCategoria, Puntaje, "
                + "NivelDificultad, Gestor, BaseDatos, Visibilidad, FechaCreacion, Fuente) "
                + "values(@Nombre, @Descripcion, @Solucion, @IDCategoria, @Puntaje, @NivelDificultad, "
                + "@Gestor, @BaseDatos, @Visibilidad, @FechaCreacion, @Fuente)";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@Nombre", p.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", p.Descripcion);
            comando.Parameters.AddWithValue("@Solucion", p.Solucion);
            comando.Parameters.AddWithValue("@IDCategoria", p.IDCategoria);
            comando.Parameters.AddWithValue("@Puntaje", p.Puntaje);
            comando.Parameters.AddWithValue("@NivelDificultad", p.NivelDificultad);
            comando.Parameters.AddWithValue("@Gestor", p.Gestor);
            comando.Parameters.AddWithValue("@BaseDatos", p.BaseDatos);
            comando.Parameters.AddWithValue("@Visibilidad", p.Visibilidad);
            comando.Parameters.AddWithValue("@FechaCreacion", p.FechaCreacion);
            comando.Parameters.AddWithValue("@Fuente", p.Fuente);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
            return true;
        }

        public bool ActualizarProblema(clsProblemas p)
        {
           
            // TODO: Corregir ISSUE #3
            MySqlCommand update=new MySqlCommand(@"update Problemas 
                set Nombre = @nombre, Descripcion = @descripcion, Solucion = @solucion, 
                IDCategoria = @idCategoria, Puntaje = @puntaje, NivelDificultad = @nivelDificultad, 
                Gestor = @gestor, BaseDatos = @baseDatos, Visibilidad = @Visibilidad, Fuente = @fuente
                where IDProblema = @IDProblema");

            update.Parameters.AddWithValue("@IDProblema", p.IDProblema);
            update.Parameters.AddWithValue("@nombre", p.Nombre);
            update.Parameters.AddWithValue("@descripcion", p.Descripcion);
            update.Parameters.AddWithValue("@solucion", p.Solucion);
            update.Parameters.AddWithValue("@idCategoria", p.IDCategoria);
            update.Parameters.AddWithValue("@puntaje", p.Puntaje);
            update.Parameters.AddWithValue("@nivelDificultad", p.NivelDificultad);
            update.Parameters.AddWithValue("@gestor", p.Gestor);
            update.Parameters.AddWithValue("@baseDatos", p.BaseDatos);
            update.Parameters.AddWithValue("@Visibilidad", p.Visibilidad);
            update.Parameters.AddWithValue("@fuente", p.Fuente);

            int res = Conexion.ejecutarSentencia(update);
            
            return (res>0);
        }


        public DataTable obtenerNivelDif()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT NivelDificultad
                    FROM Problemas");
            return Conexion.ejecutarConsulta(consulta);
        }

        public DataTable obtenerGestor()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"SELECT Gestor
                    FROM Problemas");
            return Conexion.ejecutarConsulta(consulta);
        }

        public List<clsProblemas> ListaProblemas()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=18194"; //Actualizar
            conexion.Open(); //TODO: Puede arrojar EXCEPTION

            string cadena = "select * from Problemas";

            MySqlDataAdapter da = new MySqlDataAdapter(cadena, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "problemas");

            List<clsProblemas> lstProblemas = new List<clsProblemas>();
            foreach (DataRow dr in ds.Tables["problemas"].Rows)
            {
                clsProblemas problema = new clsProblemas();
                problema.IDProblema = Convert.ToInt32(dr[0]);
                problema.Nombre = dr[1].ToString();
                problema.Descripcion = dr[2].ToString();
                problema.Solucion = dr[3].ToString();
                problema.IDCategoria = Convert.ToInt32(dr[4]);
                problema.Puntaje = Convert.ToInt32(dr[5]);
                problema.NivelDificultad = dr[6].ToString();
                problema.Gestor = dr[7].ToString();
                problema.BaseDatos = dr[8].ToString();
                problema.Visibilidad = dr[9].ToString();
                problema.FechaCreacion = Convert.ToDateTime(dr[10]);
                problema.Fuente = dr[11].ToString();
                lstProblemas.Add(problema);
            }

            return lstProblemas;
        }


        public clsProblemas obtenerProblema(String idProblema) {
                MySqlCommand consulta =
                    new MySqlCommand(@"SELECT * from Problemas
                            WHERE IDProblema=@IDProblema");
            consulta.Parameters.AddWithValue("@IDProblema",idProblema);
            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                clsProblemas problema = new clsProblemas()
                {
                    IDProblema = Convert.ToInt32(idProblema),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                    Solucion = fila["Solucion"].ToString(),
                    IDCategoria = Convert.ToInt32(fila["IDCategoria"].ToString()),
                    Puntaje = Convert.ToInt32(fila["Puntaje"].ToString()),
                    NivelDificultad = fila["NivelDificultad"].ToString(),
                    Gestor = fila["Gestor"].ToString(),
                    BaseDatos = fila["BaseDatos"].ToString(),
                    Visibilidad = fila["Visibilidad"].ToString(),
                    FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]),
                    Fuente = fila["Fuente"].ToString()
                };
                return problema;
            }
            else
                return null;
        }
    }
}
