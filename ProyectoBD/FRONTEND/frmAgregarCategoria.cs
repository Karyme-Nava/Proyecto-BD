using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.FRONTEND;
using ProyectoBD.POJOS;
using ProyectoBD.BACKEND;

namespace ProyectoBD.FRONTEND
{
    public partial class frmAgregarCategoria : Form
    {
        Form parent = null;
        int idCategoria;
        public frmAgregarCategoria(Form parent, int idCategoria)
        {
            InitializeComponent();
            this.parent = parent;
            this.idCategoria = idCategoria;
            if (idCategoria > 0)
            {
                this.Text = "Modificar Categoría";
                cargarDatos();
            }
            else
            {
                lblId.Visible = false;
                txtId.Visible = false;
            }
        }
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsCategorias categoria = getCategoria();
            clsDaoCategorias daoCategorias = new clsDaoCategorias();
            try
            {
                if (categoria!=null && idCategoria == 0)
                {
                    daoCategorias.InsertarCategoria(categoria);
                    MessageBox.Show(this, "La categoría se agregó exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (categoria != null)
                {
                    if (daoCategorias.ActualizarCategoria(categoria))
                    {
                        MessageBox.Show(this, "La categoría se actualizó exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (ConexionException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NoControllerException ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void cargarDatos()
        {
            try
            {
                clsDaoCategorias daoCategorias = new clsDaoCategorias();
                clsCategorias categoria = daoCategorias.obtenerCategoria(idCategoria);
                txtId.Text = categoria.IDCategoria.ToString();
                txtNombre.Text = categoria.NombreCategoria;
                txtDescripcion.Text = categoria.Descripcion;
            }
            catch (NoControllerException ex)
            {
                MessageBox.Show(this, ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ConexionException ex)
            {
                MessageBox.Show(this, ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ha ocurrido un error al realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private clsCategorias getCategoria()
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre.Equals(""))
            {
                MessageBox.Show("Debes escribir un nombre para la categoría", "Datos incorrectos");
                return null;
            }

            if (nombre.Length > 70)
            {
                MessageBox.Show("Debes escribir un nombre para la categoría de menos de 70 caracteres", "Datos incorrectos");
                return null;
            }

            string descripcion = txtDescripcion.Text.Trim();
            if (descripcion.Equals(""))
            {
                MessageBox.Show("Debes escribir una descripción para la categoría", "Datos incorrectos");
                return null;
            }

            if (descripcion.Length > 65535)
            {
                MessageBox.Show("Debes escribir una descripción para la categoría de menos de 65535 caracteres", "Datos incorrectos");
                return null;
            }

            clsCategorias categoria = new clsCategorias();
            categoria.IDCategoria = idCategoria;
            categoria.NombreCategoria = nombre;
            categoria.Descripcion = descripcion;
            return categoria;
        }
    }
}
