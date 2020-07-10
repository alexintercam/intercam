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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Controle_operacional();
            myForm.Show();
        }

        private void TextBox2_(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = a + b;
            label7.Text = c;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = a + " " + b;
            label7.Text = c;
        }

    }
}
