using Projeto_Vendas_ETEC.br.com.projetos.dao;
using Projeto_Vendas_ETEC.br.com.projetos.model;
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
    public partial class Frmclientes : Form
    {

        bool mover = false;
        Point posicao_inicial;

        public Frmclientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.nome = nome.Text;
            cliente.numero = int.Parse(numero.Text);
            cliente.rg = rg.Text;
            cliente.telefone = tel.Text;
            cliente.uf = uf.Text;
            cliente.endereco = endereco.Text;
            cliente.email = email.Text;
            cliente.cpf = cpf.Text;
            cliente.complemento = comp.Text;
            cliente.cidade = cidade.Text;
            cliente.cep = cep.Text;
            cliente.celular = celular.Text;
            cliente.bairro = bairro.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(cliente);
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            AdicionarEventosControlos(this);
            dao.ClienteDAO dao = new dao.ClienteDAO();
            dgclientes.DataSource = dao.ListarTodosClientes();
        }

        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados de uma linha selecionada no DataGridView
            cod.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            nome.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
            rg.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
            cpf.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            email.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
            tel.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
            celular.Text = dgclientes.CurrentRow.Cells[6].Value.ToString();
            cep.Text = dgclientes.CurrentRow.Cells[7].Value.ToString();
            endereco.Text = dgclientes.CurrentRow.Cells[8].Value.ToString();
            numero.Text = dgclientes.CurrentRow.Cells[9].Value.ToString();
            comp.Text = dgclientes.CurrentRow.Cells[10].Value.ToString();
            bairro.Text = dgclientes.CurrentRow.Cells[11].Value.ToString();
            cidade.Text = dgclientes.CurrentRow.Cells[12].Value.ToString();
            uf.Text = dgclientes.CurrentRow.Cells[13].Value.ToString();
        }

        private void LimparCampos()
        {
            cod.Clear();
            nome.Clear();
            rg.Clear();
            cpf.Clear();
            email.Clear();
            tel.Clear();
            celular.Clear();
            cep.Clear();
            endereco.Clear();
            numero.Clear();
            comp.Clear();
            bairro.Clear();
            cidade.Clear();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Frmmenu frm = new Frmmenu();
            frm.Show();
            this.Hide();
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - this.posicao_inicial.X, novo.Y - this.posicao_inicial.Y);
            }
        }

        private void AdicionarEventosControlos(Control contentor)
        {
            foreach(Control c in contentor.Controls)
            {
                Type tipo = c.GetType();
                if(tipo == typeof(Panel))
                {
                    c.MouseDown += panel1_MouseDown;
                    c.MouseUp += panel1_MouseUp;
                    c.MouseMove += panel1_MouseMove;
                }

                if(c.Controls.Count != 0)
                {
                    AdicionarEventosControlos(c);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botao excluir
            dao.ClienteDAO dao = new dao.ClienteDAO();
            dao.ExcluirCliente(int.Parse(cod.Text));

            //Recarregar o datagridview
            dgclientes.DataSource = dao.ListarTodosClientes();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botao editar
            //1 passo - Receber os dados em um objetivo model de cliente
            model.Cliente cliente = new model.Cliente();

            cliente.nome = nome.Text;
            cliente.rg = rg.Text;
            cliente.cpf = cpf.Text;
            cliente.email = email.Text;
            cliente.telefone = tel.Text;
            cliente.celular = celular.Text;
            cliente.cep = cep.Text;
            cliente.endereco = endereco.Text;
            cliente.numero = int.Parse(numero.Text);
            cliente.complemento = comp.Text;
            cliente.bairro = bairro.Text;
            cliente.cidade = cidade.Text;
            cliente.uf = uf.Text;

            //Receber o id do cliente
            cliente.id = int.Parse(cod.Text);

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastarCliente
            dao.ClienteDAO dao = new dao.ClienteDAO();
            dao.AlterarCliente(cliente);

            //Recarregar o datagridview
            dgclientes.DataSource = dao.ListarTodosClientes();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao consultar cliente
            string dados = txtcunsulta.Text;
            dao.ClienteDAO dao = new dao.ClienteDAO();

            //Verificar qual é a opção escolhida no combobox filtro
            //Se for nome
            if (cbfiltro.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por Nome");
                dgclientes.DataSource = dao.ConsultarClientePorNome(dados);
            }
            //Se for CPF
            else if (cbfiltro.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CPF");
                dgclientes.DataSource = dao.ConsultarClientePorCPF(dados);
            }

            if (dgclientes.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado");
                dgclientes.DataSource = dao.ListarTodosClientes();
            }
        }

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void cRUDCADASTROToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void toolStripMenuItem17_Click_1(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frmfornecedores frm = new Frmfornecedores();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void toolStripMenuItem20_Click_1(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Frmfuncionarios frm = new Frmfuncionarios();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }

        private void toolStripMenuItem23_Click_1(object sender, EventArgs e)
        {
            Frmprodutos frm = new Frmprodutos();
            frm.Show();
            this.Hide();
        }

        private void cONSULTAToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Frmprodutos frm = new Frmprodutos();
            frm.Show();
            this.Hide();

            frm.tabControl1.SelectedTab = frm.tabPage2;
        }
    }
}
