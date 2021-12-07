using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Projeto_Vendas_ETEC.br.com.projetos.connections
{
    public class ConnectionFactory
    {
        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
