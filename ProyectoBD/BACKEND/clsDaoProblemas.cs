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
                @"delete from Problemas where IDProblema = @id");

            delete.Parameters.AddWithValue("@id", p);

            int resultado = Conexion.ejecutarSentencia(delete);
            
            return (resultado > 0);
        }

        public bool InsertarProblema(clsProblemas p)
        {
            MySqlCommand insert = new MySqlCommand(
                @"insert into Problemas (Nombre, Descripcion, Solucion, IDCategoria, Puntaje, "
                + "NivelDificultad, Gestor, BaseDatos, Visibilidad, FechaCreacion, Fuente) "
                + "values(@Nombre, @Descripcion, @Solucion, @IDCategoria, @Puntaje, @NivelDificultad, "
                + "@Gestor, @BaseDatos, @Visibilidad, @FechaCreacion, @Fuente)");

            insert.Parameters.AddWithValue("@Nombre", p.Nombre);
            insert.Parameters.AddWithValue("@Descripcion", p.Descripcion);
            insert.Parameters.AddWithValue("@Solucion", p.Solucion);
            insert.Parameters.AddWithValue("@IDCategoria", p.IDCategoria);
            insert.Parameters.AddWithValue("@Puntaje", p.Puntaje);
            insert.Parameters.AddWithValue("@NivelDificultad", p.NivelDificultad);
            insert.Parameters.AddWithValue("@Gestor", p.Gestor);
            insert.Parameters.AddWithValue("@BaseDatos", p.BaseDatos);
            insert.Parameters.AddWithValue("@Visibilidad", p.Visibilidad);
            insert.Parameters.AddWithValue("@FechaCreacion", p.FechaCreacion);
            insert.Parameters.AddWithValue("@Fuente", p.Fuente);

            int resultado = Conexion.ejecutarSentencia(insert);

            return (resultado > 0);
        }

        public bool ActualizarProblema(clsProblemas p)
        {
           
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

            int resultado = Conexion.ejecutarSentencia(update);
            
            return (resultado > 0);
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
            MySqlCommand consulta =
                new MySqlCommand(@"select * from Problemas");

            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            List<clsProblemas> lstProblemas = new List<clsProblemas>();

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    clsProblemas problema = new clsProblemas();
                    problema.IDProblema = Convert.ToInt32(fila[0]);
                    problema.Nombre = fila[1].ToString();
                    problema.Descripcion = fila[2].ToString();
                    problema.Solucion = fila[3].ToString();
                    problema.IDCategoria = Convert.ToInt32(fila[4]);
                    problema.Puntaje = Convert.ToInt32(fila[5]);
                    problema.NivelDificultad = fila[6].ToString();
                    problema.Gestor = fila[7].ToString();
                    problema.BaseDatos = fila[8].ToString();
                    problema.Visibilidad = fila[9].ToString();
                    problema.FechaCreacion = Convert.ToDateTime(fila[10]);
                    problema.Fuente = fila[11].ToString();
                    lstProblemas.Add(problema);
                }
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
