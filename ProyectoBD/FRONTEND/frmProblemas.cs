﻿using System;
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
    public partial class frmProblemas : Form
    {
        Form parent = null;
        public frmProblemas(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            // Inicializar tabla

        }
        public frmProblemas()
        {
            InitializeComponent();
        }

        

        private void frmProblemas_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProblema form = new frmAgregarProblema(this, 0);
            form.Show();
            this.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregarProblema form = new frmAgregarProblema(this, 1);
            form.Show();
            this.Visible = false;
        }
    }
}
