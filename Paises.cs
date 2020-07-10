using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_operacional
{
    public partial class Paises : Form
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }
    }
}
