namespace SpriteApp
{
    partial class Sprite
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
            this.spritePane1 = new LibPanes.SpritePane();
            this.SuspendLayout();
            // 
            // spritePane1
            // 
            this.spritePane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spritePane1.Location = new System.Drawing.Point(0, 0);
            this.spritePane1.Name = "spritePane1";
            this.spritePane1.SetImageGif = null;
            this.spritePane1.Size = new System.Drawing.Size(358, 228);
            this.spritePane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spritePane1.TabIndex = 0;
            this.spritePane1.Time = 800;
            this.spritePane1.Click += new System.EventHandler(this.spritePane1_Click);
            // 
            // Sprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 228);
            this.Controls.Add(this.spritePane1);
            this.Name = "Sprite";
            this.Text = "SpriteApp";
            this.ResumeLayout(false);

        }

        #endregion

        private LibPanes.SpritePane spritePane1;
    }
}

