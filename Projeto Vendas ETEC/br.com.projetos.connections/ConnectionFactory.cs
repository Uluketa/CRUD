

//Não esqueça dos usings abaixo
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Projeto_Vendas_Etec.br.com.projetos.connections
{
    public class ConnectionFactory
    {
        //metodo que conecta o banco de dados

        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }


    }
}
