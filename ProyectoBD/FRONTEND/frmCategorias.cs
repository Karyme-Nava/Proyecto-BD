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
    public partial class frmCategorias : Form
    {
        Form parent = null;
        public frmCategorias(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            actualizarTabla();
        }

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria form = new frmAgregarCategoria(this, 0);
            this.Visible = false;
            form.ShowDialog();

            actualizarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgCategorias.SelectedRows[0].Cells[0].Value);
                frmAgregarCategoria form = new frmAgregarCategoria(this, id);
                Console.WriteLine(id);
                this.Visible = false;
                form.ShowDialog();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("Selecciona una categoría para poder editarla", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count > 0)
            {
                clsDaoCategorias daoCategorias = new clsDaoCategorias();
                clsCategorias categoria = new clsCategorias();
                categoria.IDCategoria = Convert.ToInt32(dgCategorias.SelectedRows[0].Cells[0].Value);
                categoria.NombreCategoria = dgCategorias.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult respuesta = MessageBox.Show(this, "¿Estás seguro de que quieres eliminar la categoría " +
                  categoria.NombreCategoria + " con ID=" + categoria.IDCategoria + "?", "Eliminación de categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                try
                {
                    if (respuesta == DialogResult.Yes)
                    {
                        if (daoCategorias.EliminarCategoria(categoria))
                        {
                            actualizarTabla();
                            MessageBox.Show("Categoría eliminada", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Error al eliminar", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ParentException ex)
                {
                    MessageBox.Show(this, ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ConexionException ex)
                {
                    MessageBox.Show(ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NoControllerException ex)
                {
                    MessageBox.Show(this, ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ha ocurrido un error al realizar la operación", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Selecciona una categoría para poder eliminarla", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarTabla()
        {
            try
            {
                clsDaoCategorias daoCategorias = new clsDaoCategorias();
                List<clsCategorias> categorias = daoCategorias.ListaCategorias();
                dgCategorias.DataSource = categorias;
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
    }
}
