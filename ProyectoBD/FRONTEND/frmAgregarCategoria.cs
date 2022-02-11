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
    public partial class frmAgregarCategoria : Form
    {
        Form parent = null;
        int type = 0; // defines if should be an update or an insert
        public frmAgregarCategoria(Form parent, int type)
        {
            InitializeComponent();
            this.parent = parent;
            this.type = type;
        }
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
