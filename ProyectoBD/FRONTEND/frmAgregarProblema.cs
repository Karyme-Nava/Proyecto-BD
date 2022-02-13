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
        String idProblema =""; // defines if should be an update or an insert
        public frmAgregarProblema(Form parent, String idProblema)
        {
            InitializeComponent();
            this.parent = parent;
            this.idProblema = idProblema;
            if (idProblema.Length == 0)
            {
                cargarCategorias();

            }
            else if (idProblema.Length > 0)
            {
                this.Text = "Editar problema ID" + idProblema;
                clsDaoProblemas daoProblem = new clsDaoProblemas();
                cargarCategorias();
                try
                {
                    clsProblemas problem = daoProblem.obtenerProblema(idProblema);
                    txtId.Text = idProblema;
                    txtNombre.Text = problem.Nombre;
                    txtDescripcion.Text = problem.Descripcion;
                    txtSolucion.Text = problem.Solucion;
                    cbCategoria.SelectedValue = problem.IDCategoria;
                    cbDificultad.SelectedItem = problem.NivelDificultad;
                    txtBD.Text = problem.BaseDatos;
                    txtPuntaje.Text = Convert.ToString(problem.Puntaje);
                    cbGestor.SelectedItem = problem.Gestor;
                    dtFecha.Value = problem.FechaCreacion;
                    txtFuente.Text = problem.Fuente;
                    if (problem.Visibilidad.Equals("Privado"))
                        rbPrivada.Checked = true;
                    else if (problem.Visibilidad.Equals("Publico"))
                        rbPublico.Checked = true;
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

        private void cargarCategorias() {
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

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsDaoProblemas daoProblemas = new clsDaoProblemas();
            clsProblemas problema = getProblema();
         

            if (problema!=null && idProblema.Length==0) // Dato nuevo, INSERT
            {
                daoProblemas.InsertarProblema(problema);
                MessageBox.Show(this, "Problema almacenado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(problema != null) // Dato a actualizar, UPDATE
            {
                problema.IDProblema = Convert.ToInt32(idProblema);
                if (daoProblemas.ActualizarProblema(problema))
                {
                    MessageBox.Show(this, "Problema almacenado exitosamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
            if (nombre.Length>70)
            {
                MessageBox.Show("El nombre del problema debe contener a lo más 70 caracteres", "Datos incorrectos");
                return null;
            }

            string descripcion = txtDescripcion.Text.Trim();
            if (descripcion.Equals(""))
            {
                MessageBox.Show("Debe escribir una descripcion para el problema", "Datos incorrectos");
                return null;
            }
            if (descripcion.Length > 65535)
            {
                MessageBox.Show("Debe escribir una descripción para la categoría de menos de 65535 caracteres", "Datos incorrectos");
                return null;
            }

            string solucion = txtSolucion.Text.Trim();
            if (solucion.Equals(""))
            {
                MessageBox.Show("Debe escribir la solución del problema", "Datos incorrectos");
                return null;
            }
            if (solucion.Length > 65535)
            {
                MessageBox.Show("Debe escribir una solución para la categoría de menos de 65535 caracteres", "Datos incorrectos");
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
            if (baseDeDatos.Length > 50)
            {
                MessageBox.Show("El nombre de la base de datos debe contener a lo más 50 caracteres", "Datos incorrectos");
                return null;
            }

            string visibilidad = "";
            if (rbPrivada.Checked)
                visibilidad = rbPrivada.Text;
            else if (rbPublico.Checked)
                visibilidad = rbPublico.Text;
            else if (visibilidad.Equals(""))
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
            if (fuente.Length > 50)
            {
                MessageBox.Show("El fuente del problema debe contener a lo más 50 caracteres", "Datos incorrectos");
                return null;
            }

            clsProblemas problema = new clsProblemas();
            problema.Nombre = nombre;
            problema.Descripcion = descripcion;
            problema.Solucion = solucion;
            problema.IDCategoria = categoria; 
            problema.Puntaje = puntaje;
            problema.NivelDificultad = dificultad;
            problema.Gestor = gestor;
            problema.BaseDatos = baseDeDatos;
            problema.Visibilidad = visibilidad;
            problema.FechaCreacion = date; 
            problema.Fuente = fuente;
            return problema;
    }

        private void frmAgregarProblema_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
