using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lectura_de_Archivos_Planos
{
    public partial class frmrtf : Form
    {
        String ruta;
        public frmrtf()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {

                rtxt.Text = "";
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "RTF Files| .rtf";
                save.ShowDialog();
                txtruta.Text = save.FileName;
                ruta = save.FileName;
                rtxt.SaveFile(ruta, RichTextBoxStreamType.RichText);
            ruta = Path.GetFileName(ruta);
            txtnombre.Text = ruta;
        }

        private void btnleer_Click(object sender, EventArgs e)
        {

            rtxt.ReadOnly = true;
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.DefaultExt = "*.rtf";
                opnFile.Filter = "RTF Files|*.rtf";
            if (opnFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && opnFile.FileName.Length > 0) ;
            {
                try
                {
                    rtxt.LoadFile(opnFile.FileName);
                    ruta = opnfile.FileName;
                }
                catch
                {
                    MessageBox.Show("Error de subida");
                }
               
            }
            txtruta.Text = opnFile.FileName;



        }

        private void font1_Click(object sender, EventArgs e)
        {
            if (font.ShowDialog()==DialogResult.OK)
            {
                rtxt.Font = font.Font;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            bool result = File.Exists(ruta);
            ruta = txtruta.Text;
            if (result == true)
            {
                MessageBox.Show("File Found");
                File.Delete(ruta);
                MessageBox.Show("File Deleted Successfully");

            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxt.SaveFile(ruta, RichTextBoxStreamType.RichText);
                MessageBox.Show("Listo");
            }
            catch
            {
                MessageBox.Show("Error de guardado");
            }
            
       
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            rtxt.ReadOnly = false;
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.DefaultExt = "*.rtf";
            opnFile.Filter = "RTF Files|*.rtf";
            if (opnFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && opnFile.FileName.Length > 0) ;
            {
                try
                {
                    rtxt.LoadFile(opnFile.FileName);
                    ruta = opnfile.FileName;
                }
                catch
                {
                    MessageBox.Show("error");
                }
                
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmselect arhivotxt = new frmselect();
            arhivotxt.Show();
        }
    }
}
