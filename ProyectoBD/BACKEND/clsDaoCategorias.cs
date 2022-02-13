﻿using System;
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
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=11863"; //Actualizar
            conexion.Open();

            string cadena = "delete from Categorias where IDCategoria = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", c.IDCategoria);

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

        public bool InsertarCategoria(clsCategorias c)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=12723"; //Actualizar
            conexion.Open();

            string cadena = "insert into Categorias (NombreCategoria, Descripcion) " +
                "values (@nombre, @descripcion)";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@nombre", c.NombreCategoria);
            comando.Parameters.AddWithValue("@descripcion", c.Descripcion);

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

        public bool ActualizarCategoria(clsCategorias c)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=12723"; //Actualizar
            conexion.Open();

            string cadena = "update Categorias "
                + "set NombreCategoria = @nombre, Descripcion = @descripcion "
                + "where IDCategoria = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", c.IDCategoria);
            comando.Parameters.AddWithValue("@nombre", c.NombreCategoria);
            comando.Parameters.AddWithValue("@descripcion", c.Descripcion);

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

        public clsCategorias Categoria(int idCategoria)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=12723"; //Actualizar
            conexion.Open();

            string cadena = "select * from Categorias where IDCategoria = @id";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@id", idCategoria);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds, "categoria");

            clsCategorias categoria = new clsCategorias();
            foreach (DataRow dr in ds.Tables["categoria"].Rows)
            {
                categoria.IDCategoria = Convert.ToInt32(dr[0]);
                categoria.NombreCategoria = dr[1].ToString();
                categoria.Descripcion = dr[2].ToString();
            }

            return categoria;
        }

        public List<clsCategorias> ListaCategorias()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=8.tcp.ngrok.io;uid=myuser;pwd=myuser;database=bdProblemas;port=11863"; //Actualizar
            conexion.Open();

            string cadena = "select * from Categorias";
            
            MySqlDataAdapter da = new MySqlDataAdapter(cadena, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds, "categorias");

            List<clsCategorias> lstCategorias = new List<clsCategorias>();
            foreach (DataRow dr in ds.Tables["categorias"].Rows)
            {
                clsCategorias categoria = new clsCategorias();
                categoria.IDCategoria = Convert.ToInt32(dr[0]);
                categoria.NombreCategoria = dr[1].ToString();
                categoria.Descripcion = dr[2].ToString();
                lstCategorias.Add(categoria);
            }

            return lstCategorias;
        }
    }
}
