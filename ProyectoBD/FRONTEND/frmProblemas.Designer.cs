
namespace ProyectoBD.FRONTEND
{
    partial class frmProblemas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgProblemas = new System.Windows.Forms.DataGridView();
            this.IdProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelDificultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseDeDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProblemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProblemas
            // 
            this.dgProblemas.AllowUserToAddRows = false;
            this.dgProblemas.AllowUserToDeleteRows = false;
            this.dgProblemas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProblemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProblemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProblemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProblema,
            this.Nombre,
            this.Descripcion,
            this.Solucion,
            this.IdCategoria,
            this.Puntaje,
            this.NivelDificultad,
            this.Gestor,
            this.BaseDeDatos,
            this.Visibilidad,
            this.FechaCreacion,
            this.Fuente});
            this.dgProblemas.Location = new System.Drawing.Point(12, 45);
            this.dgProblemas.Name = "dgProblemas";
            this.dgProblemas.ReadOnly = true;
            this.dgProblemas.Size = new System.Drawing.Size(905, 295);
            this.dgProblemas.TabIndex = 25;
            // 
            // IdProblema
            // 
            this.IdProblema.HeaderText = "Problema Id";
            this.IdProblema.Name = "IdProblema";
            this.IdProblema.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del problema";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solución";
            this.Solucion.Name = "Solucion";
            this.Solucion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "Id Categoría";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // NivelDificultad
            // 
            this.NivelDificultad.HeaderText = "Nivel de dificultad";
            this.NivelDificultad.Name = "NivelDificultad";
            this.NivelDificultad.ReadOnly = true;
            // 
            // Gestor
            // 
            this.Gestor.HeaderText = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.ReadOnly = true;
            // 
            // BaseDeDatos
            // 
            this.BaseDeDatos.HeaderText = "Base de datos";
            this.BaseDeDatos.Name = "BaseDeDatos";
            this.BaseDeDatos.ReadOnly = true;
            // 
            // Visibilidad
            // 
            this.Visibilidad.HeaderText = "Visibilidad";
            this.Visibilidad.Name = "Visibilidad";
            this.Visibilidad.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // Fuente
            // 
            this.Fuente.HeaderText = "Fuente";
            this.Fuente.Name = "Fuente";
            this.Fuente.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(713, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 35);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnModificar.Location = new System.Drawing.Point(383, 368);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 35);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(71, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 35);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.dgProblemas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmProblemas";
            this.Text = "Problemas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProblemas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgProblemas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProblemas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelDificultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseDeDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuente;
    }
}