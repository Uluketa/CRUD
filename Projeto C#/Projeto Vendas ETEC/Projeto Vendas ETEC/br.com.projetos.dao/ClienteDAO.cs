using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_Vendas_ETEC.br.com.projetos.connections;
using Projeto_Vendas_ETEC.br.com.projetos.model;

namespace Projeto_Vendas_ETEC.br.com.projetos.dao
{
    public class ClienteDAO
    {
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        private MySqlConnection conexao;

        public void CadastrarCliente(Cliente cliente)
        {

            try
            {
                string sql = @"insert into TB_CLIENTES (TB_CLIENTE_NOME,
                                           TB_CLIENTE_RG,
                                           TB_CLIENTE_CPF,
                                           TB_CLIENTE_EMAIL,
                                           TB_CLIENTE_TELEFONE,
                                           TB_CLIENTE_CELULAR,
                                           TB_CLIENTE_CEP,
                                           TB_CLIENTE_ENDERECO,
                                           TB_CLIENTE_NUMERO,
                                           TB_CLIENTE_COMPLEMENTO,
                                           TB_CLIENTE_BAIRRO,
                                           TB_CLIENTE_CIDADE,
                                           TB_CLIENTE_ESTADO)
                                                       
                               values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@nome", cliente.nome);
                executasql.Parameters.AddWithValue("@rg", cliente.rg);
                executasql.Parameters.AddWithValue("@cpf", cliente.cpf);
                executasql.Parameters.AddWithValue("@email", cliente.email);
                executasql.Parameters.AddWithValue("@telefone", cliente.telefone);
                executasql.Parameters.AddWithValue("@celular", cliente.celular);
                executasql.Parameters.AddWithValue("@cep", cliente.cep);
                executasql.Parameters.AddWithValue("@endereco", cliente.endereco);
                executasql.Parameters.AddWithValue("@numero", cliente.numero);
                executasql.Parameters.AddWithValue("@complemento", cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro", cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade", cliente.cidade);
                executasql.Parameters.AddWithValue("@estado", cliente.uf);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        //Método que altera um cliente
        public void AlterarCliente(model.Cliente cliente)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update TB_CLIENTES set tb_cliente_nome = @nome, tb_cliente_rg = @rg, tb_cliente_cpf = @cpf,
                                                        tb_cliente_email = @email, tb_cliente_telefone = @telefone, tb_cliente_celular = @celular,
                                                        tb_cliente_cep = @cep, tb_cliente_endereco = @endereco, tb_cliente_numero = @numero,
                                                        tb_cliente_complemento = @complemento, tb_cliente_bairro = @bairro, tb_cliente_cidade = @cidade, tb_cliente_estado = @estado
                                                        where tb_cliente_id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", cliente.nome);
                executasql.Parameters.AddWithValue("@rg", cliente.rg);
                executasql.Parameters.AddWithValue("@cpf", cliente.cpf);
                executasql.Parameters.AddWithValue("@email", cliente.email);
                executasql.Parameters.AddWithValue("@telefone", cliente.telefone);
                executasql.Parameters.AddWithValue("@celular", cliente.celular);
                executasql.Parameters.AddWithValue("@cep", cliente.cep);
                executasql.Parameters.AddWithValue("@endereco", cliente.endereco);
                executasql.Parameters.AddWithValue("@numero", cliente.numero);
                executasql.Parameters.AddWithValue("@complemento", cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro", cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade", cliente.cidade);
                executasql.Parameters.AddWithValue("@estado", cliente.uf);

                executasql.Parameters.AddWithValue("@id", cliente.id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente alterados com Sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void ExcluirCliente(int cliente_id)
        {
            try
            {
                string sql = @"delete from tb_clientes where tb_cliente_id = @id";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", cliente_id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com Sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        public DataTable ListarTodosClientes()
        {
            try
            {
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes";
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o seguinte erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where tb_cliente_nome = @nome";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarClientePorCPF(string cpf)
        {
            try
            {
                //1 passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where tb_cliente_cpf = @cpf";

                //2 passo - Organizare executar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
    }
}

