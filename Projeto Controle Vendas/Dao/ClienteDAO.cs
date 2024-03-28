﻿using Projeto_Controle_Vendas.Conexao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Collections.Generic;
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
    }
}