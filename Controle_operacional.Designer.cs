using System.Windows.Forms;

namespace controle_operacional
{
    partial class Controle_operacional
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spreadTarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negociadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negociaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaToolStripMenuItem,
            this.negociaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabelaToolStripMenuItem
            // 
            this.tabelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.moedasToolStripMenuItem,
            this.paísesToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.taxasToolStripMenuItem,
            this.spreadTarifasToolStripMenuItem,
            this.negociadorToolStripMenuItem,
            this.usúariosToolStripMenuItem});
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tabelaToolStripMenuItem.Text = "Tabelas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem1.Text = "Clientes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // moedasToolStripMenuItem
            // 
            this.moedasToolStripMenuItem.Name = "moedasToolStripMenuItem";
            this.moedasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.moedasToolStripMenuItem.Text = "Moedas";
            this.moedasToolStripMenuItem.Click += new System.EventHandler(this.MoedasToolStripMenuItem_Click);
            // 
            // paísesToolStripMenuItem
            // 
            this.paísesToolStripMenuItem.Name = "paísesToolStripMenuItem";
            this.paísesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.paísesToolStripMenuItem.Text = "Países";
            this.paísesToolStripMenuItem.Click += new System.EventHandler(this.PaísesToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // taxasToolStripMenuItem
            // 
            this.taxasToolStripMenuItem.Name = "taxasToolStripMenuItem";
            this.taxasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.taxasToolStripMenuItem.Text = "Taxas";
            // 
            // spreadTarifasToolStripMenuItem
            // 
            this.spreadTarifasToolStripMenuItem.Name = "spreadTarifasToolStripMenuItem";
            this.spreadTarifasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.spreadTarifasToolStripMenuItem.Text = "Spread / Tarifas";
            this.spreadTarifasToolStripMenuItem.Click += new System.EventHandler(this.SpreadTarifasToolStripMenuItem_Click);
            // 
            // negociadorToolStripMenuItem
            // 
            this.negociadorToolStripMenuItem.Name = "negociadorToolStripMenuItem";
            this.negociadorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.negociadorToolStripMenuItem.Text = "Captação / Operadores";
            // 
            // usúariosToolStripMenuItem
            // 
            this.usúariosToolStripMenuItem.Name = "usúariosToolStripMenuItem";
            this.usúariosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.usúariosToolStripMenuItem.Text = "Usúarios";
            // 
            // negociaçãoToolStripMenuItem
            // 
            this.negociaçãoToolStripMenuItem.Name = "negociaçãoToolStripMenuItem";
            this.negociaçãoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.negociaçãoToolStripMenuItem.Text = "Negociações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Controle_operacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Controle_operacional";
            this.ShowIcon = false;
            this.Text = "Controle Operacional";
            this.Load += new System.EventHandler(this.Controle_operacional_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negociaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spreadTarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negociadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usúariosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;

        public StatusBarPanelClickEventHandler statusBar1_PanelClick { get; private set; }
    }
}

