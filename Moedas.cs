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
    public partial class Moedas : Form
    {
        public Moedas()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
