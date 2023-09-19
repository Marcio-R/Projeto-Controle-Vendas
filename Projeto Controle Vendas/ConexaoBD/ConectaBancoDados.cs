using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.ConexaoBD
{
    public class ConectaBancoDados
    {
        public SqlConnection conecta;

        public SqlConnection Conexao()
        {
            conecta = new SqlConnection("Data Source=DESKTOP-SVHK57O\\SQLEXPRESS;Initial Catalog=BDVENDAS;Integrated Security=True");
            conecta.Open();
            return conecta;
        }
    }
}
