using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteApp
{
    public partial class Box : Form
    {
        public Box()
        {
            InitializeComponent();
        }

        string filename = string.Empty;
        string name_Only;

        private void ImagenBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Filter = "All files(*.*)|*.*|Gif file(*.gif*)|*.gif",
                Title = @"Open gif to load",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true
                Multiselect = true
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                filename = openfile.FileName;
                name_Only = openfile.SafeFileName;
                foreach (var item in openfile.FileNames)
                {
                    imagenBox1.FromFile(item);
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.G))
            {
                this.Text = ("<CTRL> + G Save Gif");
                SaveFileToDisk();
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                this.Text = ("<CTRL> + S save all imagens to disk");
                SaveAllImagensToDisk();
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                this.Text = ("<CTRL> + C save current image to disk");
                SaveCurrentImageToDisk();
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                this.Text = ("<CTRL> + T active-desactive Automatic");
                imagenBox1.Automatic = !imagenBox1.Automatic;
            }
            if (keyData == (Keys.Control | Keys.I))
            {
                this.Text = ("<CTRL> + I set Imagen-active");
                //definir una caja para dar entrada un valor
                {
                    Form2 testDialog = new Form2();
                    testDialog.TextBox1 = imagenBox1.Count.ToString();
                    string txtResult;
                    // Show testDialog as a modal dialog and determine if DialogResult = OK.
                    if (testDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Read the contents of testDialog's TextBox.
                        txtResult = testDialog.TextBox1;
                        imagenBox1.SetCurrentFrame = Int32.Parse(txtResult);
                    }
                    else
                    {
                        //txtResult = "Cancelled";
                    }
                    testDialog.Dispose();
                }
            }
            if (keyData == (Keys.Control | Keys.H))
            {
                this.Text = ("<CTRL> + H help comands");
                MessageBox.Show(" shotkut:\n" +
                "<CTRL> + G Save Gif\n" +
                "<CTRL> + S save all imagens to disk\n" +
                "<CTRL> + C save current image to disk\n"+
                "<CTRL> + T active-desactive Automatic\n" +
                "<CTRL> + I set Imagen-active\n"
                );
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveFileToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif",
                Title = @"Save gif to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                imagenBox1.SaveGif(savefile.FileName);
            }
        }
        private void SaveAllImagensToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "JPG file(*.jpg*)|*.jpg",
                Title = @"Save jpg to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                imagenBox1.SaveCurrentImagen(savefile.FileName);
            }
        }
        private void SaveCurrentImageToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "JPG file(*.jpg*)|*.jpg",
                Title = @"Save jpg to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {

                imagenBox1.SaveCurrentImagen(savefile.FileName);
            }
        }

        private void Box_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            foreach( var arg in args){
                if (System.IO.File.Exists(arg))
                {
                    //existe un fichero, ¿what extension?
                    var Ext = System.IO.Path.GetExtension(arg).ToUpper();
                    if(Ext == ".GIF" || Ext == ".JPG" || Ext == ".PNG")
                    {
                        //cargamos la imagen.
                        imagenBox1.FromFile(arg);
                    }
                }
            }
        }
    }
}
