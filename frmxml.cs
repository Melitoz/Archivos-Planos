using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Lectura_de_Archivos_Planos
{
    

    public partial class frmxml : Form
    {
        String ruta;
        string ruta2;
        public frmxml()
        {
            InitializeComponent();
        }
        
        private void frmxml_Load(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
            p1.Add(new person() { id = 1, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 2, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 3, nombre = "Ingrese Usuario" , codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 4, nombre = "Ingrese Usuario" , codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 5, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 6, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 7, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });
            p1.Add(new person() { id = 8, nombre = "Ingrese Usuario", codigo = "Ingrese el codigo de usuario" });


            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "RTF XML| .xml";
                save.ShowDialog();
                using (System.IO.FileStream fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write))
                {
                    serial.Serialize(fs, p1);
                }


                {
                    MessageBox.Show("Creado");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            dtgrid.ReadOnly = true;
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.DefaultExt = "*.xml";
            opnFile.Filter = "RTF XML|*.xml";
            opnFile.ShowDialog();
            ruta = opnFile.FileName;
            ruta = Path.GetFileName(ruta);
            txtnombre.Text = ruta;


            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
            using (System.IO.FileStream fs = new FileStream(opnFile.FileName, FileMode.Open, FileAccess.Read))
            {
                p1 = serial.Deserialize(fs) as List<person>;
            }
            dtgrid.DataSource = p1;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            dtgrid.ReadOnly = false;
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.DefaultExt = "*.xml";
            opnFile.Filter = "RTF XML|*.xml";
            opnFile.ShowDialog();
            ruta = opnFile.FileName;
            ruta = Path.GetFileName(ruta);
            txtnombre.Text = ruta;


            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
            using (System.IO.FileStream fs = new FileStream(opnFile.FileName, FileMode.Open, FileAccess.Read))
            {
                p1 = serial.Deserialize(fs) as List<person>;
            }
            dtgrid.DataSource = p1;
            ruta = opnFile.FileName;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                List<person> p1 = new List<person>();
                XmlSerializer serial = new XmlSerializer(typeof(List<person>));
                for (int i = 0; i < dtgrid.Rows.Count - 1; i++)
                {
                    p1.Add(new person()
                    {
                        id = Convert.ToInt32(dtgrid.Rows[i].Cells[0].Value),
                        nombre = "" + dtgrid.Rows[i].Cells[0].Value,
                        codigo = "" + dtgrid.Rows[i].Cells[0].Value
                    });


                }
                using (System.IO.FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.Write))
                {
                    serial.Serialize(fs, p1);
                    MessageBox.Show("Guardado");
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            
                
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(ruta);
                if (File.Exists(ruta))
                {
                    MessageBox.Show("El archivo sigue existiendo.");
                }
                else
                {
                    MessageBox.Show("El archivo ya no existe.");
                }
            }
            catch 
            {
                MessageBox.Show("Error al borrar archivo: {0}", e.ToString());
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
