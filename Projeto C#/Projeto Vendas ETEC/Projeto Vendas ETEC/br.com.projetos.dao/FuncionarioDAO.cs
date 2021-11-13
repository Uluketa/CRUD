using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_Vendas_ETEC.br.com.projetos.connections;
using Projeto_Vendas_ETEC.br.com.projetos.model;
using System.Data;

namespace Projeto_Vendas_ETEC.br.com.projetos.dao
{
    public class FuncionarioDAO
    {
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        private MySqlConnection conexao;

        public void CadastrarFuncionario(Funcionario funcionario)
        {

            try
            {
                string sql = @"insert into TB_FUNCIONARIOS (TB_FUNCIONARIOS_NOME,
                                           TB_FUNCIONARIOS_RG,
                                           TB_FUNCIONARIOS_CPF,
                                           TB_FUNCIONARIOS_EMAIL,
                                           TB_FUNCIONARIOS_SENHA,
                                           TB_FUNCIONARIOS_CARGO,
                                           TB_FUNCIONARIOS_NIVEL_ACESSO,
                                           TB_FUNCIONARIOS_TELEFONE,
                                           TB_FUNCIONARIOS_CELULAR,
                                           TB_FUNCIONARIOS_CEP,
                                           TB_FUNCIONARIOS_ENDERECO,
                                           TB_FUNCIONARIOS_NUMERO,
                                           TB_FUNCIONARIOS_COMPLEMENTO,
                                           TB_FUNCIONARIOS_BAIRRO,
                                           TB_FUNCIONARIOS_CIDADE,
                                           TB_FUNCIONARIOS_ESTADO)
                                                       
                               values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivelacess, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivelacess", funcionario.nivel_acesso);
                executasql.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionario.numero);
                executasql.Parameters.AddWithValue("@complemento", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionario.uf);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");


                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void AlterarFuncionario(model.Funcionario funcionario)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update TB_FUNCIONARIOS set 
                                           TB_FUNCIONARIOS_NOME = @nome,
                                           TB_FUNCIONARIOS_RG = @rg,
                                           TB_FUNCIONARIOS_CPF = @cpf,
                                           TB_FUNCIONARIOS_EMAIL = @email,
                                           TB_FUNCIONARIOS_SENHA = @senha,
                                           TB_FUNCIONARIOS_CARGO = @cargo,
                                           TB_FUNCIONARIOS_NIVEL_ACESSO = @nivelacess,
                                           TB_FUNCIONARIOS_TELEFONE = @tel,
                                           TB_FUNCIONARIOS_CELULAR = @celular,
                                           TB_FUNCIONARIOS_CEP = @cep,
                                           TB_FUNCIONARIOS_ENDERECO = @endereco,
                                           TB_FUNCIONARIOS_NUMERO = @num,
                                           TB_FUNCIONARIOS_COMPLEMENTO = @complemento,
                                           TB_FUNCIONARIOS_BAIRRO = @bairro,
                                           TB_FUNCIONARIOS_CIDADE = @cidade,
                                           TB_FUNCIONARIOS_ESTADO = @uf
                            where TB_FUNCIONARIOS_ID = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivelacess", funcionario.nivel_acesso);
                executasql.Parameters.AddWithValue("@tel", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@num", funcionario.numero);
                executasql.Parameters.AddWithValue("@complemento", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@uf", funcionario.uf);

                executasql.Parameters.AddWithValue("@id", funcionario.id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário alterados com Sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void ExcluirFuncionario(int funcionario_id)
        {
            try
            {
                string sql = @"delete from TB_FUNCIONARIOS where TB_FUNCIONARIOS_ID = @id";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", funcionario_id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com Sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        public DataTable ListarTodosFuncionarios()
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from TB_FUNCIONARIOS";
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o seguinte erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from TB_FUNCIONARIOS where TB_FUNCIONARIOS_NOME = @nome";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        public DataTable ConsultarFuncionarioPorCPF(string cpf)
        {
            try
            {
                //1 passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from TB_FUNCIONARIOS where TB_FUNCIONARIOS_CPF = @cpf";

                //2 passo - Organizare executar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
    }
}
