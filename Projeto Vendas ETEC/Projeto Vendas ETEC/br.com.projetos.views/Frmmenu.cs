using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
            this.Hide();
        }


        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            Frmprodutos frm = new Frmprodutos();
            frm.Show();
            this.Hide();
        }

        private void cRUDCADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void cONSULTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void cONSULTAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void cONSULTAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frmprodutos frm = new Frmprodutos();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlogin frm = new Frmlogin();
            frm.Show();
        }
    }
}
