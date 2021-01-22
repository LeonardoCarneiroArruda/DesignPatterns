using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.Factory
{
    public class DesignPatternsFactory : IDesignPatterns
    {

        public void MainExemplo()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
