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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                ConectaBanco.Conexao().Close();

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");

            }
        }
        #endregion
        #region AlterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                var cmd = ConectaBanco.Conexao().CreateCommand();

                cmd.CommandText = $"UPDATE tb_clientes SET Nome = @Nome, Rg = @Rg, Cpf = @Cpf, Email = @Email,Celular=@Celular, Telefone=@Telefone, Cep=@Cep, Endereco=@Endereco,  Numero =@Numero, Complemento=@Complemento, Bairro=@Bairro, Cidade=@Cidade, Estado=@Estado WHERE id= {obj.Codigo}";

                cmd.Parameters.AddWithValue("@id", obj.Codigo);
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
                ConectaBanco.Conexao().Close();

                MessageBox.Show("Cliente alterado  com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");

            }
        }
        #endregion
        #region ExcluirCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                var cmd = ConectaBanco.Conexao().CreateCommand();

                cmd.CommandText = $"delete from tb_clientes where id={obj.Codigo}";

                cmd.Parameters.AddWithValue("@id", obj.Codigo);
                cmd.ExecuteNonQuery();
                ConectaBanco.Conexao().Close();

                MessageBox.Show("Cliente excluido com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu o erro {erro}");

            }
        }
        #endregion
        #region ListarClientes
        public DataTable ListarClientes()
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
        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                string query = "SELECT * FROM tb_clientes WHERE nome = @Nome";
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConectaBanco.Conexao());
                adapter.SelectCommand.Parameters.AddWithValue("@Nome", nome);
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
