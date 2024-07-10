using Projeto_Controle_Vendas.Conexao;
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
    class ClienteDAO
    {
        private readonly SqlConnection _connection;

        public ClienteDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void CadastraCliente(Cliente cliente)
        {
            try
            {
                var command = _connection.CreateCommand();
                command.CommandText = @"INSERT INTO tb_clientes (Nome, Rg, Cpf, Email, Telefone, Celular, Cep, Endereco, Numero, Complemento, Bairro, Cidade, Estado) 
                             VALUES (@Nome, @Rg, @Cpf, @Email, @Telefone, @Celular, @Cep, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @Estado)";
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Rg", cliente.Rg);
                command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Celular", cliente.Celular);
                command.Parameters.AddWithValue("@Cep", cliente.Cep);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@Numero", cliente.Numero);
                command.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@Estado", cliente.Estado);
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show("Cliente cadastrado com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastra cliente!");
            }
        }
        #endregion
        #region ListarClientes
        public DataTable listarCliente()
        {
            try
            {
                // Cria um adaptador de dados para executar a consulta SQL e preencher o DataTable com os resultados.
                SqlDataAdapter tabelaCliente = new SqlDataAdapter("select * from tb_clientes", _connection);

                // Cria um objeto DataTable para armazenar os dados recuperados.
                DataTable dados = new DataTable();

                // Abre a conexão com o banco de dados.
                _connection.Open();

                // Preenche o DataTable com os dados recuperados pela consulta SQL.
                tabelaCliente.Fill(dados);

                // Fecha a conexão com o banco de dados.
                _connection.Close();

                // Retorna o DataTable com os dados.
                return dados;
            }
            catch (Exception erro)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna null.
                MessageBox.Show($"Erro ao executar o comando SQL: {erro}");
                return null;
            }
        }
        #endregion
        #region AlterarCliente
        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                var command = _connection.CreateCommand();
                command.CommandText = @"
            UPDATE tb_clientes 
            SET 
                Nome = @Nome, 
                Rg = @Rg, 
                Cpf = @Cpf, 
                Email = @Email, 
                Telefone = @Telefone, 
                Celular = @Celular,  
                Cep = @Cep,  
                Endereco = @Endereco, 
                Numero = @Numero, 
                Complemento = @Complemento,
                Bairro = @Bairro, 
                Cidade = @Cidade, 
                Estado = @Estado 
            WHERE Id = @id";
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Rg", cliente.Rg);
                command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Celular", cliente.Celular);
                command.Parameters.AddWithValue("@Cep", cliente.Cep);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@Numero", cliente.Numero);
                command.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                command.Parameters.AddWithValue("@Estado", cliente.Estado);
                command.Parameters.AddWithValue("@id", cliente.Id);
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show("Cliente alterado com sucesso");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao alterar cliente!");
            }

        }
        #endregion
        #region DeletaCliente
        public void DeletarCliente(Cliente cliente)
        {
            try
            {
                var comand = _connection.CreateCommand();
                comand.CommandText = $" delete from tb_clientes where id = {cliente.Id}";
                _connection.Open();
                comand.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show("Cliente excluido com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao excluir cliente!{erro}");

            }
        }
        #endregion

        #region BuscarClientePorNome

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                SqlDataAdapter tabelaCliente = new SqlDataAdapter("select * from tb_clientes where nome = @nome", _connection);
                tabelaCliente.SelectCommand.Parameters.AddWithValue("@nome", nome);
                DataTable tabela = new DataTable();
                _connection.Open();
                tabelaCliente.Fill(tabela);
                _connection.Close();
                return tabela;
            }
            catch (Exception erro)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna null.
                MessageBox.Show($"Erro ao executar o comando SQL: {erro}");
                return null;
            }
        }
        #endregion
        #region ListaClientePorNome
        public DataTable ListarPorNome(string nome)
        {
            try
            {
                SqlDataAdapter tabelaCliente = new SqlDataAdapter("select * from tb_clientes where nome like @nome ", _connection);
                tabelaCliente.SelectCommand.Parameters.AddWithValue("@nome", nome);
                DataTable dataTable = new DataTable();
                _connection.Open();
                tabelaCliente.Fill(dataTable);
                _connection.Close();
                return dataTable;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {erro}");
                return null;
            }
        }
        #endregion
    }
}