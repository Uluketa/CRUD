using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Vendas_ETEC.br.com.projetos.connections;
using Projeto_Vendas_ETEC.br.com.projetos.model;
using System.Windows.Forms;
namespace Projeto_Vendas_ETEC.br.com.projetos.dao
{
    public class FornecedorDAO
    {
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        private MySqlConnection conexao;

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {

            try
            {
                string sql = @"insert into TB_FORNECEDORES(
                                            TB_FORNECEDORES_NOME,
                                            TB_FORNECEDORES_CNPJ,
                                            TB_FORNECEDORES_EMAIL,
                                            TB_FORNECEDORES_TELEFONE,
                                            TB_FORNECEDORES_CELULAR,
                                            TB_FORNECEDORES_CEP,
                                            TB_FORNECEDORES_ENDERECO,
                                            TB_FORNECEDORES_NUMERO,
                                            TB_FORNECEDORES_COMPLEMENTO,
                                            TB_FORNECEDORES_BAIRRO,
                                            TB_FORNECEDORES_CIDADE,
                                            TB_FORNECEDORES_ESTADO)
                                                       
                               values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedor.uf);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void AlterarFornecedor(model.Fornecedor fornecedor)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update TB_FORNECEDORES set 
                                            TB_FORNECEDORES_NOME = @nome,
                                            TB_FORNECEDORES_CNPJ = @cnpj,
                                            TB_FORNECEDORES_EMAIL = @email,
                                            TB_FORNECEDORES_TELEFONE = @telefone,
                                            TB_FORNECEDORES_CELULAR = @celular,
                                            TB_FORNECEDORES_CEP = @cep,
                                            TB_FORNECEDORES_ENDERECO = @endereco,
                                            TB_FORNECEDORES_NUMERO = @numero,
                                            TB_FORNECEDORES_COMPLEMENTO = @complemento,
                                            TB_FORNECEDORES_BAIRRO = @bairro,
                                            TB_FORNECEDORES_CIDADE = @cidade,
                                            TB_FORNECEDORES_ESTADO = @uf 
                                where TB_FORNECEDORES_ID = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@uf", fornecedor.uf);

                executasql.Parameters.AddWithValue("@id", fornecedor.id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterados com Sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void ExcluirFornecedor(int fornecedor_id)
        {
            try
            {
                string sql = @"delete from TB_FORNECEDORES where TB_FORNECEDORES_ID = @id";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", fornecedor_id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com Sucesso!");
           
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        public DataTable ListarTodosFornecedores()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_FORNECEDORES";
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o seguinte erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_FORNECEDORES where TB_FORNECEDORES_NOME = @nome";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarFornecedorPorCNPJ(string cnpj)
        {
            try
            {
                //1 passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_FORNECEDORES where TB_FORNECEDORES_CNPJ = @cnpj";

                //2 passo - Organizare executar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cnpj", cnpj);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
    }
}
