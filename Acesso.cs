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
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Alex" && textBox2.Text == "1234")
            {
                this.Hide();
                MessageBox.Show("Bem Vindo ao Sistema!");
                var myForm = new Controle_operacional();
                myForm.Show();
             
            }
            else
            {
                MessageBox.Show("Usúario ou Senha inválidos!");
            }
                        
        }

        private void Acesso_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
