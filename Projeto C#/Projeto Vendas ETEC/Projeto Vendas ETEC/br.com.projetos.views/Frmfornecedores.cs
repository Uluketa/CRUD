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
    public partial class Frmfornecedores : Form
    {
        bool mover = false;
        Point posicao_inicial;

        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void dgfornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cod.Text = dgfornecedores.CurrentRow.Cells[0].Value.ToString();
            nome.Text = dgfornecedores.CurrentRow.Cells[1].Value.ToString();
            cnpj.Text = dgfornecedores.CurrentRow.Cells[2].Value.ToString();
            email.Text = dgfornecedores.CurrentRow.Cells[3].Value.ToString();
            tel.Text = dgfornecedores.CurrentRow.Cells[4].Value.ToString();
            celular.Text = dgfornecedores.CurrentRow.Cells[5].Value.ToString();
            cep.Text = dgfornecedores.CurrentRow.Cells[6].Value.ToString();
            endereco.Text = dgfornecedores.CurrentRow.Cells[7].Value.ToString();
            numero.Text = dgfornecedores.CurrentRow.Cells[8].Value.ToString();
            comp.Text = dgfornecedores.CurrentRow.Cells[9].Value.ToString();
            bairro.Text = dgfornecedores.CurrentRow.Cells[10].Value.ToString();
            cidade.Text = dgfornecedores.CurrentRow.Cells[11].Value.ToString();
            uf.Text = dgfornecedores.CurrentRow.Cells[12].Value.ToString();
        }

        private void dgfornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dados = txtcunsulta.Text;
            dao.FornecedorDAO dao = new FornecedorDAO();

            //Verificar qual é a opção escolhida no combobox filtro
            //Se for nome
            if (cbfiltro.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por Nome");
                dgfornecedores.DataSource = dao.ConsultarFornecedorPorNome(dados);
            }
            //Se for CPF
            else if (cbfiltro.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CNPJ");
                dgfornecedores.DataSource = dao.ConsultarFornecedorPorCNPJ(dados);
            }

            if (dgfornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado");
                dgfornecedores.DataSource = dao.ListarTodosFornecedores();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.nome = nome.Text;
            fornecedor.numero = int.Parse(numero.Text);
            fornecedor.cnpj = cnpj.Text;
            fornecedor.telefone = tel.Text;
            fornecedor.uf = uf.Text;
            fornecedor.endereco = endereco.Text;
            fornecedor.email = email.Text;
            fornecedor.complemento = comp.Text;
            fornecedor.cidade = cidade.Text;
            fornecedor.cep = cep.Text;
            fornecedor.celular = celular.Text;
            fornecedor.bairro = bairro.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(fornecedor);
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            AdicionarEventosControlos(this);
            dao.FornecedorDAO dao = new dao.FornecedorDAO();
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }

        private void LimparCampos()
        {
            cod.Clear();
            nome.Clear();
            cnpj.Clear();
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
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Botao excluir
            dao.FornecedorDAO dao = new dao.FornecedorDAO();
            dao.ExcluirFornecedor(int.Parse(cod.Text));

            //Recarregar o datagridview
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Fornecedor fornecedor = new model.Fornecedor();

            fornecedor.nome = nome.Text;
            fornecedor.cnpj = cnpj.Text;
            fornecedor.email = email.Text;
            fornecedor.telefone = tel.Text;
            fornecedor.celular = celular.Text;
            fornecedor.cep = cep.Text;
            fornecedor.endereco = endereco.Text;
            fornecedor.numero = int.Parse(numero.Text);
            fornecedor.complemento = comp.Text;
            fornecedor.bairro = bairro.Text;
            fornecedor.cidade = cidade.Text;
            fornecedor.uf = uf.Text;

            //Receber o id do cliente
            fornecedor.id = int.Parse(cod.Text);

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastarCliente
            dao.FornecedorDAO dao = new dao.FornecedorDAO();
            dao.AlterarFornecedor(fornecedor);

            //Recarregar o datagridview
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();

            //Limpar Todos os Campos
            LimparCampos();
        }


    }
}
