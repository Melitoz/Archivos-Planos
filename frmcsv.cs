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
    public partial class frmcsv : Form
    {
        private Stream stream;
        string limite = ",";
        string ruta = "";
        string linea = ""; 

        public frmcsv()
        {
            InitializeComponent();
        }

        
        private void btncrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog crear = new SaveFileDialog();


            if (crear.ShowDialog() == DialogResult.OK)
            {
                ruta = crear.FileName + ".csv";


                StringBuilder construir = new StringBuilder();

                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < Convert.ToInt32(7); k++)
                    {
                        if (k == Convert.ToInt32(7) - 1)
                        {
                            construir.Append(String.Format(" "));
                        }
                        else
                        {
                            construir.Append(String.Format(" " + limite));
                        }
                    }
                    construir.AppendLine();
                }

                try
                {
                    System.IO.StreamWriter escribir = new System.IO.StreamWriter((ruta), false, System.Text.Encoding.Default);
                    escribir.Write(construir.ToString(), Encoding.Default);
                    escribir.Close();
                }
                catch (Exception) { }

                leer();
                dtgrid.ReadOnly = false;

            }
        }
        private void datoscsv(string archivodirec)
        {

        }
        public void leer()
        {
            dtgrid.DataSource = null;
            dtgrid.Refresh();
            dtgrid.Rows.Clear();
            dtgrid.Columns.Clear();

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "1";
            columna1.Width = 200;

            dtgrid.Columns.Add(columna1);

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "2";
            columna2.Width = 200;

            dtgrid.Columns.Add(columna2);

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "3";
            columna3.Width = 200;

            dtgrid.Columns.Add(columna3);

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "4";
            columna4.Width = 200;

            dtgrid.Columns.Add(columna4);

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "5";
            columna5.Width = 200;

            dtgrid.Columns.Add(columna5);

            DataGridViewTextBoxColumn columna6 = new DataGridViewTextBoxColumn();
            columna6.HeaderText = "6";
            columna6.Width = 200;

            dtgrid.Columns.Add(columna6);


            DataGridViewTextBoxColumn columna7 = new DataGridViewTextBoxColumn();
            columna7.HeaderText = "7";
            columna7.Width = 200;

            dtgrid.Columns.Add(columna7);

            string[] valores;

            using (stream)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ruta);
                while ((linea = file.ReadLine()) != null)
                {
                    char limit = char.Parse(limite);

                    valores = linea.Split(limit);
                    dtgrid.Rows.Add(valores.ToArray());
                }

                file.Close();
            }



        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            File.Delete(ruta);
            dtgrid.Refresh();
            dtgrid.Rows.Clear();
            dtgrid.Columns.Clear();
            MessageBox.Show("Borrado");
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            dtgrid.ReadOnly = false;

        }

        private void btnleer_Click_1(object sender, EventArgs e)
        {
            dtgrid.ReadOnly = true;

            OpenFileDialog openfilecsv = new OpenFileDialog();
            openfilecsv.InitialDirectory = Application.StartupPath;
            openfilecsv.Filter = "CSV ||*.csv";
            if (openfilecsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openfilecsv.OpenFile()) != null)
                    {
                        ruta = openfilecsv.FileName;
                        leer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar abrir el archivo " + ex.Message);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            StringBuilder construir = new StringBuilder();

            for (int j = 0; j < dtgrid.Rows.Count - 1; j++)
            {
                for (int k = 0; k < Convert.ToInt32(7); k++)
                {
                    if (k == Convert.ToInt32(7) - 1)
                    {
                        construir.Append(String.Format(" " + Convert.ToString(dtgrid.Rows[j].Cells[k].Value)));
                    }
                    else
                    {
                        construir.Append(String.Format(" " + Convert.ToString(dtgrid.Rows[j].Cells[k].Value) + limite));
                    }
                }
                construir.AppendLine();
            }

            try
            {
                System.IO.StreamWriter escribir = new System.IO.StreamWriter((ruta), false, System.Text.Encoding.Default);
                escribir.Write(construir.ToString(), Encoding.Default);
                escribir.Close();
            }
            catch (Exception) { }
            MessageBox.Show("Guardado");
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmselect arhivotxt = new frmselect();
            arhivotxt.Show();
        }
    }
}
