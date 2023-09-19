using Projeto_Controle_Vendas.ConexaoBD;
using Projeto_Controle_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Dao
{

    public class ClienteDAO
    {

        ConectaBancoDados ConectaBanco = new ConectaBancoDados();

        public ClienteDAO()
        {
        }

        public ClienteDAO(ConectaBancoDados conectaBanco)
        {
            ConectaBanco = conectaBanco;
        }




        #region CadastraCliente
        public void cadastraCliente(Cliente obj)
        {
            try
            {
                var cmd = ConectaBanco.Conexao().CreateCommand();

                cmd.CommandText = @"Insert into tb_clientes (Nome,Rg,Cpf,Email,Celular,Telefone,Cep,Endereco,Numero,Complemento,Bairro,Cidade,Estado)
                                values(@Nome,@Rg,@Cpf,@Email,@Celular,@Telefone,@Cep,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@Estado)";

                cmd.Parameters.AddWithValue("@Nome", obj.Nome);
                cmd.Parameters.AddWithValue("@Rg", obj.Rg);
                cmd.Parameters.AddWithValue("@Cpf", obj.Cpf);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@Celular", obj.Celular);
                cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@Cep", obj.Cep);
                cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@Numero", obj.Numero);
                cmd.Parameters.AddWithValue("@Complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.ExecuteNonQuery();
                ConectaBanco.Conexao();

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                
            }
        }
        #endregion
        #region ListarClientes
        public  DataTable ListarClientes()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from tb_clientes", ConectaBanco.Conexao());
                DataTable dados = new DataTable();
                adapter.Fill(dados);
                ConectaBanco.Conexao().Close();
                return dados;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");
                return null;

            }
        }
        #endregion
    }
}
