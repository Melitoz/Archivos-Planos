using System;
using System.IO;
using System.Windows.Forms;

namespace Lectura_de_Archivos_Planos
{

    public partial class frmtxt : Form
        
    {
        String ruta;

        public frmtxt()
        {
            InitializeComponent();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            try
            {
                openfile.Title = "Busque el archivo";
                openfile.ShowDialog();
                string Text = openfile.FileName;

                if (File.Exists(openfile.FileName))
                {
                    TextReader leer = new StreamReader(Text);
                    rtxt1.Text = leer.ReadToEnd();
                    leer.Close();
                }
                txtruta.Text = Text;

                rtxt1.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir");
            }


        }

        private void btncrear_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "")
            {
                MessageBox.Show("Ponga un nombre al archivo");

            }
            else
            {
                TextWriter Escribe = new StreamWriter(txtnombre.Text + ".txt");
                Escribe.WriteLine("");
                Escribe.Close();
                MessageBox.Show("Listo");
            }

        }

        private void btnsave_click(object sender, EventArgs e)
        {
            try
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(savefile.FileName))
                    {
                        string txt = savefile.FileName;
                        StreamWriter Textoguardado = File.CreateText(txt);
                        Textoguardado.Write(rtxt1.Text);
                        Textoguardado.Flush();
                        Textoguardado.Close();
                    }
                    else
                    {
                        string txt = savefile.FileName;
                        StreamWriter Textoguardado = File.CreateText(txt);
                        Textoguardado.Write(rtxt1.Text);
                        Textoguardado.Flush();
                        Textoguardado.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            try
            {

                openfile.Title = "Busque el archivo";
                openfile.ShowDialog();
                string Text = openfile.FileName;

                if (File.Exists(openfile.FileName))
                {
                    TextReader leer = new StreamReader(Text);
                    rtxt1.Text = leer.ReadToEnd();
                    leer.Close();
                }
                txtruta.Text = Text;

                rtxt1.ReadOnly = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir");
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            bool result = File.Exists(ruta);
            ruta = txtruta.Text;
            if (result == true)
            {
                File.Delete(ruta);
                MessageBox.Show("Completado");
            }
            else
            {
                MessageBox.Show("No encontrado");
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
