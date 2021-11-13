using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Projeto_Vendas_ETEC.br.com.projetos.dao;
using Projeto_Vendas_ETEC.br.com.projetos.model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_ETEC.br.com.projetos.views
{
    public partial class Frmfuncionarios : Form
    {
        bool mover = false;
        Point posicao_inicial;

        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            AdicionarEventosControlos(this);
            dao.FuncionarioDAO dao = new dao.FuncionarioDAO();
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.nome = nome.Text;
            funcionario.numero = int.Parse(numero.Text);
            funcionario.rg = rg.Text;
            funcionario.telefone = tel.Text;
            funcionario.uf = uf.Text;
            funcionario.endereco = endereco.Text;
            funcionario.email = email.Text;
            funcionario.nivel_acesso = nivel_acesso.Text;
            funcionario.senha = senha.Text;
            funcionario.cargo = cargo.Text;
            funcionario.cpf = cpf.Text;
            funcionario.complemento = comp.Text;
            funcionario.cidade = cidade.Text;
            funcionario.cep = cep.Text;
            funcionario.celular = celular.Text;
            funcionario.bairro = bairro.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionario);
        }

        private void dgfuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cod.Text = dgfuncionarios.CurrentRow.Cells[0].Value.ToString();
            nome.Text = dgfuncionarios.CurrentRow.Cells[1].Value.ToString();
            rg.Text = dgfuncionarios.CurrentRow.Cells[2].Value.ToString();
            cpf.Text = dgfuncionarios.CurrentRow.Cells[3].Value.ToString();
            email.Text = dgfuncionarios.CurrentRow.Cells[4].Value.ToString();
            senha.Text = dgfuncionarios.CurrentRow.Cells[5].Value.ToString();
            cargo.Text = dgfuncionarios.CurrentRow.Cells[6].Value.ToString();
            nivel_acesso.Text = dgfuncionarios.CurrentRow.Cells[7].Value.ToString();
            tel.Text = dgfuncionarios.CurrentRow.Cells[8].Value.ToString();
            celular.Text = dgfuncionarios.CurrentRow.Cells[9].Value.ToString();
            cep.Text = dgfuncionarios.CurrentRow.Cells[10].Value.ToString();
            endereco.Text = dgfuncionarios.CurrentRow.Cells[11].Value.ToString();
            numero.Text = dgfuncionarios.CurrentRow.Cells[12].Value.ToString();
            comp.Text = dgfuncionarios.CurrentRow.Cells[13].Value.ToString();
            bairro.Text = dgfuncionarios.CurrentRow.Cells[14].Value.ToString();
            cidade.Text = dgfuncionarios.CurrentRow.Cells[15].Value.ToString();
            uf.Text = dgfuncionarios.CurrentRow.Cells[16].Value.ToString();
        }

        private void LimparCampos()
        {
            cod.Clear();
            nome.Clear();
            rg.Clear();
            senha.Clear();
            cargo.Clear();
            nivel_acesso.Clear();
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

        private void dgfuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dao.FuncionarioDAO dao = new dao.FuncionarioDAO();
            dao.ExcluirFuncionario(int.Parse(cod.Text));

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Funcionario funcionario = new model.Funcionario();

            funcionario.nome = nome.Text;
            funcionario.numero = int.Parse(numero.Text);
            funcionario.rg = rg.Text;
            funcionario.telefone = tel.Text;
            funcionario.uf = uf.Text;
            funcionario.endereco = endereco.Text;
            funcionario.email = email.Text;
            funcionario.nivel_acesso = nivel_acesso.Text;
            funcionario.senha = senha.Text;
            funcionario.cargo = cargo.Text;
            funcionario.cpf = cpf.Text;
            funcionario.complemento = comp.Text;
            funcionario.cidade = cidade.Text;
            funcionario.cep = cep.Text;
            funcionario.celular = celular.Text;
            funcionario.bairro = bairro.Text;

            //Receber o id do cliente
            funcionario.id = int.Parse(cod.Text);

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastarCliente
            dao.FuncionarioDAO dao = new dao.FuncionarioDAO();
            dao.AlterarFuncionario(funcionario);

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();

            //Limpar Todos os Campos
            LimparCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dados = txtcunsulta.Text;
            dao.FuncionarioDAO dao = new dao.FuncionarioDAO();

            //Verificar qual é a opção escolhida no combobox filtro
            //Se for nome
            if (cbfiltro.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por Nome");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorNome(dados);
            }
            //Se for CPF
            else if (cbfiltro.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CPF");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorCPF(dados);
            }

            if (dgfuncionarios.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado");
                dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
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
    }
}
