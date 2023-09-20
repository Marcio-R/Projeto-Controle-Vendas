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
        private void FormClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DataSource = dao.ListarClientes(); 
        }
        private void atualizaGrid()
        {
            tabelaCliente.DataSource = dao.ListarClientes();
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
            atualizaGrid();

        }


        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            txtUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Aterar para a guia Dados Pessoais
            tabClientes.SelectedTab = tabPageCadastro;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(cliente);
            //Recarrega o data grid atualizado
            atualizaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = int.Parse(txtCodigo.Text);
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
            dao.alterarCliente(cliente);
            atualizaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

        }
    }
}
