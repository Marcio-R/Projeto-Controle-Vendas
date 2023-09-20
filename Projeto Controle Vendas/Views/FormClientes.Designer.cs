namespace Projeto_Controle_Vendas.Views
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.txtUf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.tabelaCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPageCadastro);
            this.tabClientes.Controls.Add(this.tabPageConsulta);
            this.tabClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(0, 77);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(958, 455);
            this.tabClientes.TabIndex = 1;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtUf);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.txtBairro);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.txtCidade);
            this.tabPageCadastro.Controls.Add(this.label14);
            this.tabPageCadastro.Controls.Add(this.txtNumero);
            this.tabPageCadastro.Controls.Add(this.label15);
            this.tabPageCadastro.Controls.Add(this.txtComplemento);
            this.tabPageCadastro.Controls.Add(this.label16);
            this.tabPageCadastro.Controls.Add(this.txtEndereco);
            this.tabPageCadastro.Controls.Add(this.label17);
            this.tabPageCadastro.Controls.Add(this.txtCep);
            this.tabPageCadastro.Controls.Add(this.label18);
            this.tabPageCadastro.Controls.Add(this.txtCelular);
            this.tabPageCadastro.Controls.Add(this.label19);
            this.tabPageCadastro.Controls.Add(this.txtTelefone);
            this.tabPageCadastro.Controls.Add(this.label20);
            this.tabPageCadastro.Controls.Add(this.txtCpf);
            this.tabPageCadastro.Controls.Add(this.label21);
            this.tabPageCadastro.Controls.Add(this.txtRg);
            this.tabPageCadastro.Controls.Add(this.label22);
            this.tabPageCadastro.Controls.Add(this.txtEmail);
            this.tabPageCadastro.Controls.Add(this.label23);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.Add(this.label24);
            this.tabPageCadastro.Controls.Add(this.txtCodigo);
            this.tabPageCadastro.Controls.Add(this.label25);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(950, 403);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Dados Pessoais";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtUf
            // 
            this.txtUf.FormattingEnabled = true;
            this.txtUf.Items.AddRange(new object[] {
            "AC - Acre",
            "AL - Alagoas",
            "AM - Amazonas",
            "AP - Amapá",
            "BA - Bahia",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MG - Minas Gerais",
            "MS - Mato Grosso do Sul",
            "MT - Mato Grosso",
            "PA - Pará",
            "PB - Paraíba",
            "PE - Pernambuco",
            "PI - Piauí",
            "PR - Paraná",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RO - Rondônia",
            "RR - Roraima",
            "RS - Rio Grande do Sul",
            "SC - Santa Catarina",
            "SE - Sergipe",
            "SP - São Paulo",
            "TO - Tocantins"});
            this.txtUf.Location = new System.Drawing.Point(632, 267);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(259, 28);
            this.txtUf.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(535, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "UF:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(151, 252);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(250, 26);
            this.txtBairro.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(21, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(632, 225);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(259, 26);
            this.txtCidade.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(535, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(632, 183);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(259, 26);
            this.txtNumero.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(535, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Número:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(151, 213);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(250, 26);
            this.txtComplemento.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(21, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 44;
            this.label16.Text = "Complemento:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(632, 141);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(259, 26);
            this.txtEndereco.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(535, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Endereço:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(632, 99);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(259, 26);
            this.txtCep.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(535, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "CEP:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(151, 174);
            this.txtCelular.Mask = "() 000-0000-00";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(250, 26);
            this.txtCelular.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(21, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(151, 135);
            this.txtTelefone.Mask = "() 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(250, 26);
            this.txtTelefone.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(21, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "Telefone";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(632, 57);
            this.txtCpf.Mask = "###.###.###.##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(259, 26);
            this.txtCpf.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(535, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 34;
            this.label21.Text = "CPF:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(632, 15);
            this.txtRg.Mask = "##.###.###.##";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(259, 26);
            this.txtRg.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(535, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 20);
            this.label22.TabIndex = 32;
            this.label22.Text = "RG:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 26);
            this.txtEmail.TabIndex = 31;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(21, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 26);
            this.txtNome.TabIndex = 29;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(21, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 26);
            this.txtCodigo.TabIndex = 27;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(21, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 20);
            this.label25.TabIndex = 26;
            this.label25.Text = "Codigo:\r\n";
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.tabelaCliente);
            this.tabPageConsulta.Controls.Add(this.btnPesquisar);
            this.tabPageConsulta.Controls.Add(this.txtPesquisa);
            this.tabPageConsulta.Controls.Add(this.label4);
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 29);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(950, 422);
            this.tabPageConsulta.TabIndex = 1;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // tabelaCliente
            // 
            this.tabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCliente.Location = new System.Drawing.Point(0, 82);
            this.tabelaCliente.Name = "tabelaCliente";
            this.tabelaCliente.Size = new System.Drawing.Size(954, 269);
            this.tabelaCliente.TabIndex = 33;
            this.tabelaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCliente_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisar.Location = new System.Drawing.Point(488, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 40);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(87, 33);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(343, 26);
            this.txtPesquisa.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(21, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(218, 475);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 40);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Location = new System.Drawing.Point(343, 475);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(483, 475);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(617, 475);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 40);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabClientes);
            this.Controls.Add(this.panel1);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtUf;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabelaCliente;
    }
}