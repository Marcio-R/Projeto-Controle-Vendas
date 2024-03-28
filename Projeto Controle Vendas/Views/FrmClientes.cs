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
            
        }
    }
}
