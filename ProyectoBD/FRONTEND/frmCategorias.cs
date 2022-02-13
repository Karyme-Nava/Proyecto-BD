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
            frmAgregarCategoria form = new frmAgregarCategoria(this, 0, -1);
            form.Show();
            this.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgCategorias.SelectedRows[0].Cells[0].Value);
                frmAgregarCategoria form = new frmAgregarCategoria(this, 1, id);
                Console.WriteLine(id);
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(this, "Seleccione una categoría para poder editarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    daoCategorias.EliminarCategoria(categoria);
                    actualizarTabla();
                    MessageBox.Show(this, "La categoría seleccionada se eliminó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show(this, "Seleccione una categoría para poder eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategorias_VisibleChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            clsDaoCategorias daoCategorias = new clsDaoCategorias();
            List<clsCategorias> categorias = daoCategorias.ListaCategorias();
            dgCategorias.DataSource = categorias;
        }
    }
}
