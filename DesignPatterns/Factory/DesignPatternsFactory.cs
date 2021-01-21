using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.Factory
{
    public class DesignPatternsFactory
    {

        public void MainExemploDesignPatternsFactory()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
