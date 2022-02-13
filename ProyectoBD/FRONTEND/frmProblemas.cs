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
using ProyectoBD.BACKEND;
using ProyectoBD.POJOS;

namespace ProyectoBD.FRONTEND
{
    public partial class frmProblemas : Form
    {
        Form parent = null;
        public frmProblemas(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            // TODO: Inicializar tabla
            cargarProblemas();

        }
        public frmProblemas()
        {
            InitializeComponent();

        }

        private void cargarProblemas()
        {
            try
            {
                clsDaoProblemas daoProblemas = new clsDaoProblemas();
                List<clsProblemas> problemas = daoProblemas.ListaProblemas();
                dgProblemas.DataSource = problemas;

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

        private void frmProblemas_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProblema form = new frmAgregarProblema(this, "");
            this.Visible = false;
            form.ShowDialog();

            cargarProblemas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProblemas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                String Id = dgProblemas.SelectedRows[0].Cells[0].Value.ToString();
                frmAgregarProblema form = new frmAgregarProblema(this, Id);
                this.Visible = false;
                form.ShowDialog();
                cargarProblemas();
            }
            else
            {
                MessageBox.Show("Selecciona al problema que deseas editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProblemas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                String idProblema = dgProblemas.SelectedRows[0].Cells[0].Value.ToString();
                String nombreProblema = dgProblemas.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult respuesta = MessageBox.Show(this, "¿Estás seguro de que quieres eliminar el problema " +
                   nombreProblema + " con ID=" + idProblema + "?", "Eliminación de problema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                try
                {
                    if (respuesta == DialogResult.Yes)
                    {
                        clsDaoProblemas dao = new clsDaoProblemas();
                        if (dao.EliminarProblema(idProblema))
                        {
                            MessageBox.Show("Problema eliminado");
                            cargarProblemas();
                        }
                        else
                            MessageBox.Show("Error al eliminar");
                    }
                }
                catch (ParentException ex)
                {
                    MessageBox.Show(this, ex.Message, "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
                MessageBox.Show("Selecciona el problema que deseas eliminar");



        }
    }
}

