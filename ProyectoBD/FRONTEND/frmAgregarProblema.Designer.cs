
namespace ProyectoBD.FRONTEND
{
    partial class frmAgregarProblema
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGestor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbVisibilidad = new System.Windows.Forms.GroupBox();
            this.rbPrivada = new System.Windows.Forms.RadioButton();
            this.rbPublico = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.gbVisibilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(688, 531);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(152, 130);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(643, 86);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(152, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 28);
            this.txtNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(152, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 28);
            this.txtId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Problemas:";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.Location = new System.Drawing.Point(152, 237);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(643, 86);
            this.txtSolucion.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Solución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gategoría:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Muy buena"});
            this.cbCategoria.Location = new System.Drawing.Point(152, 354);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(230, 29);
            this.cbCategoria.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(559, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Puntaje:";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntaje.Location = new System.Drawing.Point(637, 355);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(158, 28);
            this.txtPuntaje.TabIndex = 19;
            // 
            // cbDificultad
            // 
            this.cbDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificultad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Basico",
            "Medio",
            "Dificil",
            "Muy dificil"});
            this.cbDificultad.Location = new System.Drawing.Point(152, 406);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(230, 29);
            this.cbDificultad.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dificultad:";
            // 
            // cbGestor
            // 
            this.cbGestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGestor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.cbGestor.FormattingEnabled = true;
            this.cbGestor.Items.AddRange(new object[] {
            "MySQL",
            "SQL Server",
            "PostgreSQL"});
            this.cbGestor.Location = new System.Drawing.Point(565, 406);
            this.cbGestor.Name = "cbGestor";
            this.cbGestor.Size = new System.Drawing.Size(230, 29);
            this.cbGestor.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Gestor:";
            // 
            // gbVisibilidad
            // 
            this.gbVisibilidad.Controls.Add(this.rbPrivada);
            this.gbVisibilidad.Controls.Add(this.rbPublico);
            this.gbVisibilidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.gbVisibilidad.Location = new System.Drawing.Point(48, 502);
            this.gbVisibilidad.Name = "gbVisibilidad";
            this.gbVisibilidad.Size = new System.Drawing.Size(248, 44);
            this.gbVisibilidad.TabIndex = 25;
            this.gbVisibilidad.TabStop = false;
            this.gbVisibilidad.Text = "Visibilidad:";
            // 
            // rbPrivada
            // 
            this.rbPrivada.AutoSize = true;
            this.rbPrivada.Location = new System.Drawing.Point(158, 19);
            this.rbPrivada.Name = "rbPrivada";
            this.rbPrivada.Size = new System.Drawing.Size(84, 25);
            this.rbPrivada.TabIndex = 27;
            this.rbPrivada.TabStop = true;
            this.rbPrivada.Text = "Privada";
            this.rbPrivada.UseVisualStyleBackColor = true;
            // 
            // rbPublico
            // 
            this.rbPublico.AutoSize = true;
            this.rbPublico.Location = new System.Drawing.Point(6, 19);
            this.rbPublico.Name = "rbPublico";
            this.rbPublico.Size = new System.Drawing.Size(84, 25);
            this.rbPublico.TabIndex = 26;
            this.rbPublico.TabStop = true;
            this.rbPublico.Text = "Público";
            this.rbPublico.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fecha de creación:";
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.dtFecha.Location = new System.Drawing.Point(565, 460);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(230, 28);
            this.dtFecha.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Base de datos:";
            // 
            // txtFuente
            // 
            this.txtFuente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuente.Location = new System.Drawing.Point(434, 520);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(158, 28);
            this.txtFuente.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Fuente:";
            // 
            // txtBD
            // 
            this.txtBD.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBD.Location = new System.Drawing.Point(152, 460);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(230, 28);
            this.txtBD.TabIndex = 32;
            // 
            // frmAgregarProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 578);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtFuente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbVisibilidad);
            this.Controls.Add(this.cbGestor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDificultad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarProblema";
            this.Text = "Agregar problema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarProblema_FormClosing);
            this.gbVisibilidad.ResumeLayout(false);
            this.gbVisibilidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGestor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbVisibilidad;
        private System.Windows.Forms.RadioButton rbPrivada;
        private System.Windows.Forms.RadioButton rbPublico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBD;
    }
}