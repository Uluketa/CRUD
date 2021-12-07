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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarProduto(Produtos produto)
        {

            try
            {
                string sql = @"insert into tb_produtos (TB_PRODUTOS_DESCRICAO, TB_PRODUTOS_PRECO, TB_PRODUTOS_QTD_ESTOQUE, TB_PRODUTOS_FOR_ID)
                                values (@descricao, @preco, @qtd, @forid)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco", produto.preco);
                executasql.Parameters.AddWithValue("@qtd", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@forid", produto.for_id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public void AlterarProduto(Produtos produtos)
        {
            try
            {
                string sql = @"update tb_produtos set tb_produtos_descricao = @descricao, TB_PRODUTOS_PRECO = @preco, tb_produtos_qtd_estoque = @qtd, tb_produtos_for_id = @forid where tb_produtos_id = @id";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produtos.descricao);
                executasql.Parameters.AddWithValue("@preco", produtos.preco);
                executasql.Parameters.AddWithValue("@qtd", produtos.qtd_estoque);
                executasql.Parameters.AddWithValue("@forid", produtos.for_id);

                executasql.Parameters.AddWithValue("@id", produtos.id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }

        }

        public void ExcluirProduto(Produtos produto)
        {
            try
            {
                string sql = @"delete from tb_produtos where tb_produtos_id = @id";
                
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", produto.id);

                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");

                conexao.Close();
                
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o erro: " + erro);
            }
        }

        public DataTable ListarTodosProdutos()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.TB_PRODUTOS_ID as 'Codigo', 
p.TB_PRODUTOS_DESCRICAO as 'Descrição', 
p.TB_PRODUTOS_PRECO as 'Preço', 
p.TB_PRODUTOS_QTD_ESTOQUE as 'Qtd', 
f.TB_FORNECEDORES_NOME as 'Fornecedor' 
FROM tb_produtos as p inner join
tb_fornecedores as f on (p.TB_PRODUTOS_FOR_ID = f.TB_FORNECEDORES_ID);";
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                conexao.Open();
                executasql.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops, ocorreu o seguinte erro: " + erro);
                return null;
            }
        }
    }
}
