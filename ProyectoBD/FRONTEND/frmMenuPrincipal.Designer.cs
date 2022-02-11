
namespace ProyectoBD
{
    partial class Problemas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProblemas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProblemas
            // 
            this.btnProblemas.Location = new System.Drawing.Point(287, 65);
            this.btnProblemas.Name = "btnProblemas";
            this.btnProblemas.Size = new System.Drawing.Size(75, 23);
            this.btnProblemas.TabIndex = 0;
            this.btnProblemas.Text = "Problemas";
            this.btnProblemas.UseVisualStyleBackColor = true;
            this.btnProblemas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(440, 65);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(75, 23);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // Problemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnProblemas);
            this.Name = "Problemas";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProblemas;
        private System.Windows.Forms.Button btnCategorias;
    }
}

