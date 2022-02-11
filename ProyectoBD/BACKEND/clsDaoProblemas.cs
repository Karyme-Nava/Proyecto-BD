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
        public bool EliminarProblema(clsProblemas p)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = ""; //Actualizar
            conexion.Open();

            string cadena = "delete from Problemas where IDProblema = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", p.IDProblema);

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

        public bool InsertarProblema(clsProblemas p)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = ""; //Actualizar
            conexion.Open();

            string cadena = "insert into Problemas (Nombre, Descripcion, Solucion, IDCategoria, Puntaje, "
                + "NivelDificultad, Gestor, BaseDatos, Visibilidad, FechaCreacion, Fuente) "
                + "values('@nombre', '@descripcion', '@solucion', @idCategoria, @puntaje, '@nivelDificultad', "
                + "'@gestor', '@baseDatos', '@visibilidad', '@fechaCreacion', '@fuente')";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
            comando.Parameters.AddWithValue("@solucion", p.Solucion);
            comando.Parameters.AddWithValue("@idCategoria", p.IDCategoria);
            comando.Parameters.AddWithValue("@puntaje", p.Puntaje);
            comando.Parameters.AddWithValue("@nivelDificultad", p.NivelDificultad);
            comando.Parameters.AddWithValue("@gestor", p.Gestor);
            comando.Parameters.AddWithValue("@baseDatos", p.BaseDatos);
            comando.Parameters.AddWithValue("@visibilidad", p.Visibilidad);
            comando.Parameters.AddWithValue("@fechaCreacion", p.FechaCreacion);
            comando.Parameters.AddWithValue("@fuente", p.Fuente);

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
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = ""; //Actualizar
            conexion.Open();

            string cadena = "update Problemas "
                + "set Nombre = @nombre, Descripcion = @descripcion, Solucion = @solucion, "
                + "IDCategoria = @idCategoria, Puntaje = @puntaje, NivelDificultad = @nivelDificultad, "
                + "Gestor = @gestor, BaseDatos = @baseDatos, Visibilidad = @visibilidad, "
                + "fechaCreacion = @fechaCreacion, Fuente = @fuente"
                + "where IDProblema = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
            comando.Parameters.AddWithValue("@solucion", p.Solucion);
            comando.Parameters.AddWithValue("@idCategoria", p.IDCategoria);
            comando.Parameters.AddWithValue("@puntaje", p.Puntaje);
            comando.Parameters.AddWithValue("@nivelDificultad", p.NivelDificultad);
            comando.Parameters.AddWithValue("@gestor", p.Gestor);
            comando.Parameters.AddWithValue("@baseDatos", p.BaseDatos);
            comando.Parameters.AddWithValue("@visibilidad", p.Visibilidad);
            comando.Parameters.AddWithValue("@fechaCreacion", p.FechaCreacion);
            comando.Parameters.AddWithValue("@fuente", p.Fuente);
            comando.Parameters.AddWithValue("@id", p.IDProblema);

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

        public List<clsProblemas> ListaProblemas()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = ""; //Actualizar
            conexion.Open();

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
    }
}
