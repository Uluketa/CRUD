using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Projeto_Vendas_ETEC.br.com.projetos.dao;
using Projeto_Vendas_ETEC.br.com.projetos.model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    public partial class Frmprodutos : Form
    {
        bool mover = false;
        Point posicao_inicial;

        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Frmmenu frm = new Frmmenu();
            frm.Show();
            this.Hide();
        }

        private void Frmprodutos_load(object sender, EventArgs e)
        {
            AdicionarEventosControlos(this);

            dao.FornecedorDAO fdao = new dao.FornecedorDAO();
            forn.DataSource = fdao.ListarTodosFornecedores();
            forn.DisplayMember = "TB_FORNECEDORES_NOME";
            forn.ValueMember = "TB_FORNECEDORES_ID";

            dao.ProdutoDAO pdao = new dao.ProdutoDAO();
            dgprodutos.DataSource = pdao.ListarTodosProdutos();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void AdicionarEventosControlos(Control contentor)
        {
            foreach (Control c in contentor.Controls)
            {
                Type tipo = c.GetType();
                if (tipo == typeof(Panel))
                {
                    c.MouseDown += panel1_MouseDown;
                    c.MouseUp += panel1_MouseUp;
                    c.MouseMove += panel1_MouseMove;
                }

                if (c.Controls.Count != 0)
                {
                    AdicionarEventosControlos(c);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_inicial.X, novo.Y - this.posicao_inicial.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();

            produtos.descricao = desc.Text;
            produtos.preco = int.Parse(preco.Text);
            produtos.qtd_estoque = int.Parse(qtd.Text);
            produtos.for_id = int.Parse(forn.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProduto(produtos);

            dgprodutos.DataSource = dao.ListarTodosProdutos();
        }

        private void button2_Click(int produto_id)
        {
            Produtos produto = new Produtos();

            produto.descricao = desc.Text;
            produto.preco = int.Parse(preco.Text);
            produto.qtd_estoque = int.Parse(qtd.Text);
            produto.for_id = int.Parse(forn.SelectedValue.ToString());

            produto.id = int.Parse(cod.Text);

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastarCliente
            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(produto);

            //Recarregar o datagridview
            dgprodutos.DataSource = dao.ListarTodosProdutos();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void dgprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cod.Text = dgprodutos.CurrentRow.Cells[0].Value.ToString();
            desc.Text = dgprodutos.CurrentRow.Cells[1].Value.ToString();
            preco.Text = dgprodutos.CurrentRow.Cells[2].Value.ToString();
            qtd.Text = dgprodutos.CurrentRow.Cells[3].Value.ToString();
            forn.Text = dgprodutos.CurrentRow.Cells[4].Value.ToString();
        }

        private void LimparCampos()
        {
            cod.Clear();
            preco.Clear();
            desc.Clear();
            qtd.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.id = int.Parse(cod.Text);

            ProdutoDAO dao = new dao.ProdutoDAO();
            dao.ExcluirProduto(produto);

            //Recarregar o datagridview
            dgprodutos.DataSource = dao.ListarTodosProdutos();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Frmprodutos frm = new Frmprodutos();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();

            produtos.id = int.Parse(cod.Text);
            produtos.descricao = desc.Text;
            produtos.preco = int.Parse(preco.Text);
            produtos.qtd_estoque = int.Parse(qtd.Text);
            produtos.for_id = int.Parse(forn.SelectedValue.ToString());
            
            ProdutoDAO produtosDAO = new ProdutoDAO();
            produtosDAO.AlterarProduto(produtos);

            dgprodutos.DataSource = produtosDAO.ListarTodosProdutos();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
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

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void dgprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
