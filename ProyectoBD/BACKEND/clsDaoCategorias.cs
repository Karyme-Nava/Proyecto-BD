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
    class clsDaoCategorias
    {
        public bool EliminarCategoria(clsCategorias c)
        {   
            MySqlCommand delete = new MySqlCommand(
                @"delete from Categorias where IDCategoria = @id");

            delete.Parameters.AddWithValue("@id", c.IDCategoria);

            int resultado = Conexion.ejecutarSentencia(delete);

            return (resultado > 0);
        }

        public bool InsertarCategoria(clsCategorias c)
        {
            MySqlCommand insert = new MySqlCommand(
                @"insert into Categorias (NombreCategoria, Descripcion) " +
                "values (@nombre, @descripcion)");
            insert.Parameters.AddWithValue("@nombre", c.NombreCategoria);
            insert.Parameters.AddWithValue("@descripcion", c.Descripcion);

            int resultado = Conexion.ejecutarSentencia(insert);

            return (resultado > 0);
        }

        public bool ActualizarCategoria(clsCategorias c)
        {
            MySqlCommand update = new MySqlCommand(@"update Categorias "
                + "set NombreCategoria = @nombre, Descripcion = @descripcion "
                + "where IDCategoria = @id");
            update.Parameters.AddWithValue("@id", c.IDCategoria);
            update.Parameters.AddWithValue("@nombre", c.NombreCategoria);
            update.Parameters.AddWithValue("@descripcion", c.Descripcion);

            int resultado = Conexion.ejecutarSentencia(update);

            return (resultado > 0);
        }

        public List<clsCategorias> ListaCategorias()
        {
            MySqlCommand consulta =
                new MySqlCommand(@"select * from Categorias");

            DataTable resultado = Conexion.ejecutarConsulta(consulta);
            List<clsCategorias> lstCategorias = new List<clsCategorias>();

            if (resultado != null)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    clsCategorias categoria = new clsCategorias();
                    categoria.IDCategoria = Convert.ToInt32(fila[0]);
                    categoria.NombreCategoria = fila[1].ToString();
                    categoria.Descripcion = fila[2].ToString();
                    lstCategorias.Add(categoria);
                }
            }

            return lstCategorias;
        }

        public clsCategorias obtenerCategoria(int idCategoria)
        {
            MySqlCommand consulta =
                new MySqlCommand(@"select * from Categorias where IDCategoria = @id");

            consulta.Parameters.AddWithValue("@id", idCategoria);

            DataTable resultado = Conexion.ejecutarConsulta(consulta);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                clsCategorias categoria = new clsCategorias();
                categoria.IDCategoria = Convert.ToInt32(fila[0]);
                categoria.NombreCategoria = fila[1].ToString();
                categoria.Descripcion = fila[2].ToString();

                return categoria;
            }
            else
                return null;
        }
    }
}
