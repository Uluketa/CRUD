using MySql.Data.MySqlClient;
using Projeto_Vendas_Etec.br.com.projetos.connections;
using System;
using System.Windows.Forms;

namespace Projeto_Vendas_Etec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnteste_Click(object sender, EventArgs e)
        {
            try
            {
                //Testando a conexao
                MySqlConnection conexao = new ConnectionFactory().getconnection();
                conexao.Open();

                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Conectar: " + erro);
             
            }
        }
    }
}
