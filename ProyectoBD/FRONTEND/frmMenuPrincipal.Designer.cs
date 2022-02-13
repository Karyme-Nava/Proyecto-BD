
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Problemas));
            this.pbxProblemas = new System.Windows.Forms.PictureBox();
            this.pbxCategorias = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblProblemas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProblemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProblemas
            // 
            this.pbxProblemas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProblemas.BackgroundImage")));
            this.pbxProblemas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProblemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProblemas.Location = new System.Drawing.Point(390, 35);
            this.pbxProblemas.Name = "pbxProblemas";
            this.pbxProblemas.Size = new System.Drawing.Size(300, 300);
            this.pbxProblemas.TabIndex = 2;
            this.pbxProblemas.TabStop = false;
            this.pbxProblemas.Click += new System.EventHandler(this.pbxProblemas_Click);
            // 
            // pbxCategorias
            // 
            this.pbxCategorias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCategorias.BackgroundImage")));
            this.pbxCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategorias.Location = new System.Drawing.Point(42, 35);
            this.pbxCategorias.Name = "pbxCategorias";
            this.pbxCategorias.Size = new System.Drawing.Size(300, 300);
            this.pbxCategorias.TabIndex = 3;
            this.pbxCategorias.TabStop = false;
            this.pbxCategorias.Click += new System.EventHandler(this.pbxCategorias_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblCategorias.Location = new System.Drawing.Point(147, 344);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(91, 21);
            this.lblCategorias.TabIndex = 4;
            this.lblCategorias.Text = "Categorías";
            // 
            // lblProblemas
            // 
            this.lblProblemas.AutoSize = true;
            this.lblProblemas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblProblemas.Location = new System.Drawing.Point(495, 344);
            this.lblProblemas.Name = "lblProblemas";
            this.lblProblemas.Size = new System.Drawing.Size(90, 21);
            this.lblProblemas.TabIndex = 5;
            this.lblProblemas.Text = "Problemas";
            // 
            // Problemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(739, 391);
            this.Controls.Add(this.lblProblemas);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.pbxCategorias);
            this.Controls.Add(this.pbxProblemas);
            this.Name = "Problemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProblemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxProblemas;
        private System.Windows.Forms.PictureBox pbxCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblProblemas;
    }
}

