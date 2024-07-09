using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Projeto_Controle_Vendas.Conexao
{
    public class ConnectionFactory
    {

        public SqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["BDVENDAS"].ConnectionString;
            return new SqlConnection(conexao);
        }
        
    }
}
