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

namespace ProyectoBD
{
    public partial class Problemas : Form
    {
        public Problemas()
        {
            InitializeComponent();
        }

        private void pbxProblemas_Click(object sender, EventArgs e)
        {
            frmProblemas form = new frmProblemas(this);
            form.Show();
            this.Visible = false;
        }

        private void pbxCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias form = new frmCategorias(this);
            form.Show();
            this.Visible = false;
        }
    }
}
