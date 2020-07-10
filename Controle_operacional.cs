using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace controle_operacional
{
    public partial class Controle_operacional : Form
    {
        public Controle_operacional()
        {
            InitializeComponent();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Controle_operacional_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString(); //Verificar data e hora para não acompanhar da maquina
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Clientes();
            myForm.Show();
        }

        private void MoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Moedas();
            myForm.Show();
        }

        private void PaísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Paises();
            myForm.Show();
        }
        private void Spreads_TarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Spreads_Tarifas();
            myForm.Show();
        }

        private void SpreadTarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Spreads_Tarifas();
            myForm.Show();
        }
    }
}