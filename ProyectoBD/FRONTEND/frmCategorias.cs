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
    public partial class frmCategorias : Form
    {
        Form parent = null;
        public frmCategorias(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria form = new frmAgregarCategoria(this, 0);
            form.Show();
            this.Visible = false;
        }

        private void frmCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria form = new frmAgregarCategoria(this, 1);
            form.Show();
            this.Visible = false;
        }
    }
}
