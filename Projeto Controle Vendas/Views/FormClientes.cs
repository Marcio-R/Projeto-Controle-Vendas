using Projeto_Controle_Vendas.Dao;
using Projeto_Controle_Vendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.Views
{
    public partial class FormClientes : Form
    {
        ClienteDAO dao = new ClienteDAO();
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Rg = txtRg.Text;
            cliente.Cep = txtCep.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Estado = txtUf.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Bairro = txtBairro.Text;
            dao.cadastraCliente(cliente);

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DataSource = dao.ListarClientes(); 
        }
    }
}
