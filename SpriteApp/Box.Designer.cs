namespace SpriteApp
{
    partial class Box
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
            this.imagenBox1 = new LibPanes.ImagenBox();
            this.SuspendLayout();
            // 
            // imagenBox1
            // 
            this.imagenBox1.Automatic = true;
            this.imagenBox1.CausesValidation = false;
            this.imagenBox1.CurrentFrame = -1;
            this.imagenBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenBox1.Imagen = null;
            this.imagenBox1.Location = new System.Drawing.Point(0, 0);
            this.imagenBox1.Name = "imagenBox1";
            this.imagenBox1.NamePathFile = "";
            this.imagenBox1.Reverse = false;
            this.imagenBox1.Size = new System.Drawing.Size(406, 219);
            this.imagenBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenBox1.TabIndex = 0;
            this.imagenBox1.Time = 800;
            this.imagenBox1.Click += new System.EventHandler(this.ImagenBox1_Click);
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 219);
            this.Controls.Add(this.imagenBox1);
            this.Name = "Box";
            this.Text = "Box";
            this.ResumeLayout(false);

        }

        #endregion

        private LibPanes.ImagenBox imagenBox1;
    }
}