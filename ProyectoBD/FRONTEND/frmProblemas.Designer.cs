
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
            this.dgProblemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProblemas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProblemas.Location = new System.Drawing.Point(12, 45);
            this.dgProblemas.MultiSelect = false;
            this.dgProblemas.Name = "dgProblemas";
            this.dgProblemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProblemas.Size = new System.Drawing.Size(905, 295);
            this.dgProblemas.TabIndex = 25;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}