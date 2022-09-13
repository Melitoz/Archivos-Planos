using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectura_de_Archivos_Planos
{
    public partial class frmselect : Form
    {
        public frmselect()
        {
            InitializeComponent();
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtxt arhivotxt = new frmtxt();
            arhivotxt.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcsv arhivotxt = new frmcsv();
            arhivotxt.Show();
        }

        private void btnrft_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmrtf arhivotxt = new frmrtf();
            arhivotxt.Show();
        }

        private void btnxml_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmxml arhivotxt = new frmxml();
            arhivotxt.Show();
        }
    }
}
