using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = new LeitorDeConfiguracao().LeConnectionString();
            conexao.Open();

            return conexao;
        }

    }
}
