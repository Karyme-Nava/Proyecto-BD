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
    public partial class frmAgregarProblema : Form
    {
        Form parent = null;
        int type = 0; // defines if should be an update or an insert
        public frmAgregarProblema(Form parent, int type)
        {
            InitializeComponent();
            this.parent = parent;
            this.type = type;
            //Inicializar el combobox de categorias
            clsDaoCategorias daoCategorias = new clsDaoCategorias();
            List<clsCategorias> categorias = daoCategorias.ListaCategorias();
            List<Tuple<Int32, String>> listaCat = new List<Tuple<int, string>>();
            foreach (clsCategorias categoria in categorias)
            {
                listaCat.Add(Tuple.Create<Int32, string>(categoria.IDCategoria, categoria.NombreCategoria));
            }
            cbCategoria.DataSource = listaCat;
            cbCategoria.ValueMember = "Item1";
            cbCategoria.DisplayMember = "Item2";            
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
            clsDaoProblemas daoProblemas = new clsDaoProblemas();
            clsProblemas problema = getProblema();
            if (type == 0) // Dato nuevo, INSERT
            {
                // TODO: Descomentar
                //daoProblemas.InsertarProblema(problema);
            }
            else if (type == 1) // Dato a actualizar, UPDATE
            {
                // TODO: Descomentar
                //daoProblemas.ActualizarProblema(problema);
            }
        }
        
        /// <summary>
        /// Valida todos los campos, de estar incorrectos muestra un mensaje con información al respecto y retorna null.
        /// Si los campos son válidos, retorna un objeto tipo Problema con todos sus datos necesarios.
        /// </summary>
        /// <returns></returns>
        private clsProblemas getProblema()
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre.Equals(""))
            {
                MessageBox.Show("Debe escribir un nombre para el problema", "Datos incorrectos");
                return null;
            }

            string descripcion = txtDescripcion.Text.Trim();
            if (descripcion.Equals(""))
            {
                MessageBox.Show("Debe escribir una descripcion para el problema", "Datos incorrectos");
                return null;
            }

            string solucion = txtSolucion.Text.Trim();
            if (solucion.Equals(""))
            {
                MessageBox.Show("Debe escribir la solución del problema", "Datos incorrectos");
                return null;
            }

            int categoria = 0;
            try
            {
                categoria = Convert.ToInt32(cbCategoria.SelectedValue);
            }catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Datos incorrectos");
                return null;
            }

            int puntaje = 0;
            try
            {
                puntaje = Convert.ToInt32(txtPuntaje.Text);
                if (puntaje < 0 || puntaje > 100)
                {
                    MessageBox.Show("El puntaje debe ser un número real entre 0 y 100", "Datos incorrectos");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El puntaje debe ser un número real entre 0 y 100", "Datos incorrectos");
                return null;
            }

            string dificultad = "";
            try
            {
                dificultad = cbDificultad.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un nivel de dificultad", "Datos incorrectos");
                return null;
            }

            string gestor = "";
            try
            {
                gestor = cbGestor.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un gestor", "Datos incorrectos");
                return null;
            }

            string baseDeDatos = txtBD.Text.Trim();
            if (baseDeDatos.Equals(""))
            {
                MessageBox.Show("Debe mencionar el nombre de la BD a usar", "Datos incorrectos");
                return null;
            }

            string visibilidad = "";
            for (int i = 0; i <gbVisibilidad.Controls.Count; i++)
            {
                if (((RadioButton)gbVisibilidad.Controls[i]).Checked)
                    visibilidad = ((RadioButton)gbVisibilidad.Controls[i]).Text;
            }
            if (visibilidad.Equals(""))
            {
                MessageBox.Show("Debe escoger un tipo de visibilidad.");
                return null;
            }
            
            

            DateTime date = DateTime.Now;

            string fuente = txtFuente.Text.Trim();
            if (fuente.Equals(""))
            {
                MessageBox.Show("Debe escribir una fuente del problema", "Datos incorrectos");
                return null;
            }

            clsProblemas problema = new clsProblemas();
            problema.Nombre = nombre;
            problema.Descripcion = descripcion;
            problema.Solucion = solucion;
            problema.IDCategoria = categoria; //TODO: Checar con mas casos
            problema.Puntaje = puntaje;
            problema.NivelDificultad = dificultad;
            problema.Gestor = gestor;
            problema.BaseDatos = baseDeDatos;
            problema.Visibilidad = visibilidad;
            problema.FechaCreacion = date; // Esta la especifico desde aquí porque en el DAO la lee del objeto, aun que haya un default
            problema.Fuente = fuente;
            return problema;
    }

        private void frmAgregarProblema_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
