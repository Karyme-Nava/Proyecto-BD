using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoBD.BACKEND
{
    public class Conexion
    {
        static MySqlConnection conexion;
        /// <summary>
        /// Abrir una conexión a MySQL
        /// </summary>
        /// <returns>True si pudo establecer la conexión y False en caso contrario</returns>
        public static bool conectar()
        {
            string parametrosConexion = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=18194";
            
            try
            {
                conexion = new MySqlConnection(parametrosConexion);
                conexion.Open(); //
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Libera la conexión para no ocupar recursos innecesarios del servidor de BD
        /// </summary>
        public static void desconectar()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //Consulta de información (SELECT)
        public static DataTable ejecutarConsulta(MySqlCommand consulta)
        {
            if (conectar())
            {
                try
                {
                    consulta.Connection = conexion;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);
                    DataTable resultado = new DataTable();
                    adaptador.Fill(resultado);
                    return resultado;
                }
                catch (MySqlException ex)
                {
                    throw new NoControllerException();
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                throw new ConexionException();
            }
        }

        //Ejecutar operaciones que afecten los datos
        //(INSERT, UPDATE, DELETE)
        public static int ejecutarSentencia(MySqlCommand sentencia)
        {
            if (conectar())
            {
                try
                {
                    sentencia.Connection = conexion;
                    return sentencia.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) //Duplicado
                    {
                        throw new DuplicationException();
                    }
                    else if (ex.Number == 1451) //Problema con foreign key
                    {
                        throw new ParentException();
                    }
                    else
                    {
                        throw new NoControllerException();
                    }
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                throw new ConexionException();
            }
        }

    }
}
