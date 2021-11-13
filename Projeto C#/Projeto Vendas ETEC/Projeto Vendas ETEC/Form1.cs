using MySql.Data.MySqlClient;
using Projeto_Vendas_ETEC.br.com.projetos.connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_ETEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new ConnectionFactory().getconnection();
                conexao.Open();

                MessageBox.Show("Conexão Criada com sucesso!");
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão: "+erro);
            }
        }
    }
}
