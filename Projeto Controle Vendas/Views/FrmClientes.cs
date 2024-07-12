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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Cep = txtCep.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Estado = cbUf.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Rg = txtRg.Text;
            cliente.Telefone = txtTelefone.Text;
            ClienteDAO dao = new ClienteDAO();
            dao.CadastraCliente(cliente);
            TabelaClientes.DataSource = dao.listarCliente();
           // LimparCamposTexto();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO cliente = new ClienteDAO();
            TabelaClientes.DataSource = cliente.listarCliente();
        }

        private void TabelaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = TabelaClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = TabelaClientes.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = TabelaClientes.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = TabelaClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = TabelaClientes.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = TabelaClientes.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = TabelaClientes.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = TabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = TabelaClientes.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = TabelaClientes.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = TabelaClientes.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = TabelaClientes.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = TabelaClientes.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = TabelaClientes.CurrentRow.Cells[13].Value.ToString();
            //Altera para a guia Dados pessoais
            tabClientes.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.Id = int.Parse(txtCodigo.Text);
            ClienteDAO dao = new ClienteDAO();
            dao.DeletarCliente(obj);

            //Recarrega o dataGridView
            TabelaClientes.DataSource = dao.listarCliente();
            //LimparCamposTexto();

        }
        private void LimparCamposTexto(Form tela)
        {
            //txtCodigo.Text = string.Empty;
            //txtNome.Text = string.Empty;
            //txtRg.Text = string.Empty;
            //txtCpf.Text = string.Empty;
            //txtEmail.Text = string.Empty;
            //txtTelefone.Text = string.Empty;
            //txtCelular.Text = string.Empty;
            //txtCep.Text = string.Empty;
            //txtEndereco.Text = string.Empty;
            //txtNumero.Text = string.Empty;
            //txtComplemento.Text = string.Empty;
            //txtBairro.Text = string.Empty;
            //txtCidade.Text = string.Empty;
            //cbUf.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Cep = txtCep.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Estado = cbUf.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Rg = txtRg.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Id = int.Parse(txtCodigo.Text);
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(cliente);
            TabelaClientes.DataSource = dao.listarCliente();
            //LimparCamposTexto();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ClienteDAO dao = new ClienteDAO();
            TabelaClientes.DataSource = dao.BuscarClientePorNome(nome);

            if (TabelaClientes.Rows.Count == 0)
            {
                TabelaClientes.DataSource = dao.listarCliente();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDAO clienteDAO = new ClienteDAO();
            TabelaClientes.DataSource = clienteDAO.ListarPorNome(nome);
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";
                DataSet dados = new DataSet();

                dados.ReadXml(xml);
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimpaTela(this);
        }
    }
}
