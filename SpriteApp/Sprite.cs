﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPanes;
using System.IO;

namespace SpriteApp
{
    public partial class Sprite : Form
    {
        public Sprite()
        {
            InitializeComponent();
        }
        string filename = string.Empty;
        string name_Only;
        private void spritePane1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif|All files(*.*)|*.*",
                Title = @"Open gif to load",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
                Multiselect = true
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                filename = openfile.FileName;
                name_Only = openfile.SafeFileName;
                if (Path.GetExtension(filename).ToUpper().Equals(".GIF"))
                {
                    spritePane1.FilePath = filename;
                    spritePane1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                foreach (var item in openfile.FileNames)
                {
                    if (Path.GetExtension(item).ToUpper().Equals(".JPG") || Path.GetExtension(item).ToUpper().Equals(".PNG"))
                    {
                        if (spritePane1.SetImageGif == null)
                        {
                            spritePane1.SetImageGif = new ImageGif();
                            spritePane1.SetImageGif.AddImage((Image)Image.FromFile(item).Clone());
                            //spritePane1.InitialImage(0);
                        }
                        else
                        {
                            spritePane1.SetImageGif.AddImage((Image)Image.FromFile(item).Clone());
                        }
                    }

                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.G))
            {
                todo = TypeToSave.Gif;
                SaveFileToDisk();
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                todo = TypeToSave.Imagens;
                SaveFileToDisk();
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                todo = TypeToSave.current;
                SaveFileToDisk();
            }
            if (keyData == (Keys.Control | Keys.H))
            {
                this.Text = ("<CTRL> + H help comands");
                MessageBox.Show(" shotkut:\n" +
                    "<CTRL> + G Save Gif\n" +
                    "<CTRL> + S save all imagens to disk\n" +
                    "<CTRL> + C save current image to disk");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public enum TypeToSave
        {
            Gif,
            Imagens,
            current
        }
        TypeToSave todo = TypeToSave.Gif;
        private void SaveFileToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif|Jpg file(*.jpg*)|*.jpg|All files(*.*)|*.*",
                Title = @"Save gif to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                switch (todo)
                {
                    case TypeToSave.Gif:
                        spritePane1.SaveGif(savefile.FileName);
                        break;
                    case TypeToSave.Imagens:
                        spritePane1.SaveAllImagens(savefile.FileName);
                        break;
                    case TypeToSave.current:
                        spritePane1.SaveCurrentImage();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
