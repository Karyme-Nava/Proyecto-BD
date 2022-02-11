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

namespace ProyectoBD.FRONTEND
{
    public partial class frmAgregarProblema : Form
    {
        Form parent = null;
        int type = 0; // defines if should be an update or an insert
        public frmAgregarProblema(Form parent, int type)
        {
            InitializeComponent();
            this.parent = parent;
            this.type = type;
        }

        public frmAgregarProblema()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: checar si es update o insert. Se recibe como parametro
            // 0 es agregar y 1 modificar
            // usar emtodo de validar
        }

        private void validar()
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string solution = txtSolucion.Text.Trim();
            string categoria = cbCategoria.SelectedItem.ToString();
            try
            {
                int puntaje = Convert.ToInt32(txtPuntaje.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El puntaje debe ser un número real entre 0 y 100");
            }
            MessageBox.Show(categoria);
            //TODO: END
        }

        private void frmAgregarProblema_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
