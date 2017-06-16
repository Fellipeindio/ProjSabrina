namespace projeto_final_03
{
    partial class Despesas
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
            this.tabDespesas = new System.Windows.Forms.TabControl();
            this.tabProcurarDespesas = new System.Windows.Forms.TabPage();
            this.bntDespesasVoltar = new System.Windows.Forms.Button();
            this.dataGridViewDespesas = new System.Windows.Forms.DataGridView();
            this.txtDespesasCodigo = new System.Windows.Forms.TextBox();
            this.txtDespesasNome = new System.Windows.Forms.TextBox();
            this.lblCodigoDespesas = new System.Windows.Forms.Label();
            this.lblDespesasNome = new System.Windows.Forms.Label();
            this.tabCadastrarDespesas = new System.Windows.Forms.TabPage();
            this.lblErroDataPagamentoGasto = new System.Windows.Forms.Label();
            this.lblErroPrecoGasto = new System.Windows.Forms.Label();
            this.lblErroNomeGasto = new System.Windows.Forms.Label();
            this.txtDescricaoGasto = new System.Windows.Forms.TextBox();
            this.txtPrecoGasto = new System.Windows.Forms.TextBox();
            this.txtNomeGasto = new System.Windows.Forms.TextBox();
            this.mcdDespesas = new System.Windows.Forms.MonthCalendar();
            this.lblDataPagamentoGasto = new System.Windows.Forms.Label();
            this.lblNomeGasto = new System.Windows.Forms.Label();
            this.lblDescricaoGasto = new System.Windows.Forms.Label();
            this.lblPrecoGasto = new System.Windows.Forms.Label();
            this.bntSalvarDespesas = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.tabProcurarCompra = new System.Windows.Forms.TabPage();
            this.bntCompraVoltar = new System.Windows.Forms.Button();
            this.dataGridViewCompraPeca = new System.Windows.Forms.DataGridView();
            this.txtCompraCodigo = new System.Windows.Forms.TextBox();
            this.txtCompraNome = new System.Windows.Forms.TextBox();
            this.lblCompraCodigo = new System.Windows.Forms.Label();
            this.lblCompraNome = new System.Windows.Forms.Label();
            this.tabCadastrarCompra = new System.Windows.Forms.TabPage();
            this.lblErroNomeProduto = new System.Windows.Forms.Label();
            this.lblErroPrecoVendaProduto = new System.Windows.Forms.Label();
            this.lblErroPrecoTotalCompra = new System.Windows.Forms.Label();
            this.lblErroPrecoPorPeca = new System.Windows.Forms.Label();
            this.lblErroQtdeComprada = new System.Windows.Forms.Label();
            this.lblErroCodigoFornecedor = new System.Windows.Forms.Label();
            this.lblErroCodigoProduto = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.txtPrecoVendaProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoTotalCompra = new System.Windows.Forms.TextBox();
            this.txtPrecoPorPeca = new System.Windows.Forms.TextBox();
            this.txtQtdeComprada = new System.Windows.Forms.TextBox();
            this.txtProcurarFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtProcurarProduto = new System.Windows.Forms.TextBox();
            this.lblPrecoTotalCompra = new System.Windows.Forms.Label();
            this.lblPrecoVendaProduto = new System.Windows.Forms.Label();
            this.lblPrecoPorPeca = new System.Windows.Forms.Label();
            this.bntProcurarFornecedor = new System.Windows.Forms.Button();
            this.lblQtdeComprada = new System.Windows.Forms.Label();
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblNovoProduto = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.bntProcuraProduto = new System.Windows.Forms.Button();
            this.bntSalvarCompra = new System.Windows.Forms.Button();
            this.bntCancelarCompra = new System.Windows.Forms.Button();
            this.tabDespesas.SuspendLayout();
            this.tabProcurarDespesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDespesas)).BeginInit();
            this.tabCadastrarDespesas.SuspendLayout();
            this.tabProcurarCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraPeca)).BeginInit();
            this.tabCadastrarCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDespesas
            // 
            this.tabDespesas.Controls.Add(this.tabProcurarDespesas);
            this.tabDespesas.Controls.Add(this.tabCadastrarDespesas);
            this.tabDespesas.Controls.Add(this.tabProcurarCompra);
            this.tabDespesas.Controls.Add(this.tabCadastrarCompra);
            this.tabDespesas.Location = new System.Drawing.Point(12, 73);
            this.tabDespesas.Name = "tabDespesas";
            this.tabDespesas.SelectedIndex = 0;
            this.tabDespesas.Size = new System.Drawing.Size(798, 512);
            this.tabDespesas.TabIndex = 0;
            // 
            // tabProcurarDespesas
            // 
            this.tabProcurarDespesas.Controls.Add(this.bntDespesasVoltar);
            this.tabProcurarDespesas.Controls.Add(this.dataGridViewDespesas);
            this.tabProcurarDespesas.Controls.Add(this.txtDespesasCodigo);
            this.tabProcurarDespesas.Controls.Add(this.txtDespesasNome);
            this.tabProcurarDespesas.Controls.Add(this.lblCodigoDespesas);
            this.tabProcurarDespesas.Controls.Add(this.lblDespesasNome);
            this.tabProcurarDespesas.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarDespesas.Name = "tabProcurarDespesas";
            this.tabProcurarDespesas.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcurarDespesas.Size = new System.Drawing.Size(790, 486);
            this.tabProcurarDespesas.TabIndex = 0;
            this.tabProcurarDespesas.Text = "Procurar Despesas";
            this.tabProcurarDespesas.UseVisualStyleBackColor = true;
            // 
            // bntDespesasVoltar
            // 
            this.bntDespesasVoltar.Location = new System.Drawing.Point(354, 457);
            this.bntDespesasVoltar.Name = "bntDespesasVoltar";
            this.bntDespesasVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntDespesasVoltar.TabIndex = 5;
            this.bntDespesasVoltar.Text = "Voltar";
            this.bntDespesasVoltar.UseVisualStyleBackColor = true;
            this.bntDespesasVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // dataGridViewDespesas
            // 
            this.dataGridViewDespesas.AllowUserToAddRows = false;
            this.dataGridViewDespesas.AllowUserToDeleteRows = false;
            this.dataGridViewDespesas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDespesas.Location = new System.Drawing.Point(28, 87);
            this.dataGridViewDespesas.Name = "dataGridViewDespesas";
            this.dataGridViewDespesas.ReadOnly = true;
            this.dataGridViewDespesas.Size = new System.Drawing.Size(737, 352);
            this.dataGridViewDespesas.TabIndex = 4;
            // 
            // txtDespesasCodigo
            // 
            this.txtDespesasCodigo.Location = new System.Drawing.Point(637, 42);
            this.txtDespesasCodigo.Name = "txtDespesasCodigo";
            this.txtDespesasCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtDespesasCodigo.TabIndex = 3;
            // 
            // txtDespesasNome
            // 
            this.txtDespesasNome.Location = new System.Drawing.Point(126, 42);
            this.txtDespesasNome.Name = "txtDespesasNome";
            this.txtDespesasNome.Size = new System.Drawing.Size(348, 20);
            this.txtDespesasNome.TabIndex = 2;
            // 
            // lblCodigoDespesas
            // 
            this.lblCodigoDespesas.AutoSize = true;
            this.lblCodigoDespesas.Location = new System.Drawing.Point(527, 45);
            this.lblCodigoDespesas.Name = "lblCodigoDespesas";
            this.lblCodigoDespesas.Size = new System.Drawing.Size(104, 13);
            this.lblCodigoDespesas.TabIndex = 1;
            this.lblCodigoDespesas.Text = "Procurar por Código:";
            // 
            // lblDespesasNome
            // 
            this.lblDespesasNome.AutoSize = true;
            this.lblDespesasNome.Location = new System.Drawing.Point(21, 45);
            this.lblDespesasNome.Name = "lblDespesasNome";
            this.lblDespesasNome.Size = new System.Drawing.Size(99, 13);
            this.lblDespesasNome.TabIndex = 0;
            this.lblDespesasNome.Text = "Procurar por Nome:";
            // 
            // tabCadastrarDespesas
            // 
            this.tabCadastrarDespesas.Controls.Add(this.lblErroDataPagamentoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.lblErroPrecoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.lblErroNomeGasto);
            this.tabCadastrarDespesas.Controls.Add(this.txtDescricaoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.txtPrecoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.txtNomeGasto);
            this.tabCadastrarDespesas.Controls.Add(this.mcdDespesas);
            this.tabCadastrarDespesas.Controls.Add(this.lblDataPagamentoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.lblNomeGasto);
            this.tabCadastrarDespesas.Controls.Add(this.lblDescricaoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.lblPrecoGasto);
            this.tabCadastrarDespesas.Controls.Add(this.bntSalvarDespesas);
            this.tabCadastrarDespesas.Controls.Add(this.bntCancelar);
            this.tabCadastrarDespesas.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarDespesas.Name = "tabCadastrarDespesas";
            this.tabCadastrarDespesas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarDespesas.Size = new System.Drawing.Size(790, 486);
            this.tabCadastrarDespesas.TabIndex = 1;
            this.tabCadastrarDespesas.Text = "Cadastrar Despesas";
            this.tabCadastrarDespesas.UseVisualStyleBackColor = true;
            // 
            // lblErroDataPagamentoGasto
            // 
            this.lblErroDataPagamentoGasto.AutoSize = true;
            this.lblErroDataPagamentoGasto.ForeColor = System.Drawing.Color.Red;
            this.lblErroDataPagamentoGasto.Location = new System.Drawing.Point(652, 101);
            this.lblErroDataPagamentoGasto.Name = "lblErroDataPagamentoGasto";
            this.lblErroDataPagamentoGasto.Size = new System.Drawing.Size(0, 13);
            this.lblErroDataPagamentoGasto.TabIndex = 12;
            // 
            // lblErroPrecoGasto
            // 
            this.lblErroPrecoGasto.AutoSize = true;
            this.lblErroPrecoGasto.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoGasto.Location = new System.Drawing.Point(113, 247);
            this.lblErroPrecoGasto.Name = "lblErroPrecoGasto";
            this.lblErroPrecoGasto.Size = new System.Drawing.Size(0, 13);
            this.lblErroPrecoGasto.TabIndex = 11;
            // 
            // lblErroNomeGasto
            // 
            this.lblErroNomeGasto.AutoSize = true;
            this.lblErroNomeGasto.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeGasto.Location = new System.Drawing.Point(113, 117);
            this.lblErroNomeGasto.Name = "lblErroNomeGasto";
            this.lblErroNomeGasto.Size = new System.Drawing.Size(0, 13);
            this.lblErroNomeGasto.TabIndex = 10;
            // 
            // txtDescricaoGasto
            // 
            this.txtDescricaoGasto.Location = new System.Drawing.Point(116, 362);
            this.txtDescricaoGasto.Name = "txtDescricaoGasto";
            this.txtDescricaoGasto.Size = new System.Drawing.Size(444, 20);
            this.txtDescricaoGasto.TabIndex = 9;
            // 
            // txtPrecoGasto
            // 
            this.txtPrecoGasto.Location = new System.Drawing.Point(116, 224);
            this.txtPrecoGasto.Name = "txtPrecoGasto";
            this.txtPrecoGasto.Size = new System.Drawing.Size(113, 20);
            this.txtPrecoGasto.TabIndex = 8;
            // 
            // txtNomeGasto
            // 
            this.txtNomeGasto.Location = new System.Drawing.Point(116, 94);
            this.txtNomeGasto.Name = "txtNomeGasto";
            this.txtNomeGasto.Size = new System.Drawing.Size(295, 20);
            this.txtNomeGasto.TabIndex = 7;
            // 
            // mcdDespesas
            // 
            this.mcdDespesas.Location = new System.Drawing.Point(459, 135);
            this.mcdDespesas.Name = "mcdDespesas";
            this.mcdDespesas.TabIndex = 6;
            // 
            // lblDataPagamentoGasto
            // 
            this.lblDataPagamentoGasto.AutoSize = true;
            this.lblDataPagamentoGasto.Location = new System.Drawing.Point(489, 101);
            this.lblDataPagamentoGasto.Name = "lblDataPagamentoGasto";
            this.lblDataPagamentoGasto.Size = new System.Drawing.Size(148, 13);
            this.lblDataPagamentoGasto.TabIndex = 5;
            this.lblDataPagamentoGasto.Text = "Data do Pagamento do Gasto";
            // 
            // lblNomeGasto
            // 
            this.lblNomeGasto.AutoSize = true;
            this.lblNomeGasto.Location = new System.Drawing.Point(26, 101);
            this.lblNomeGasto.Name = "lblNomeGasto";
            this.lblNomeGasto.Size = new System.Drawing.Size(84, 13);
            this.lblNomeGasto.TabIndex = 4;
            this.lblNomeGasto.Text = "Nome do Gasto:";
            // 
            // lblDescricaoGasto
            // 
            this.lblDescricaoGasto.AutoSize = true;
            this.lblDescricaoGasto.Location = new System.Drawing.Point(6, 367);
            this.lblDescricaoGasto.Name = "lblDescricaoGasto";
            this.lblDescricaoGasto.Size = new System.Drawing.Size(104, 13);
            this.lblDescricaoGasto.TabIndex = 3;
            this.lblDescricaoGasto.Text = "Descrição do Gasto:";
            // 
            // lblPrecoGasto
            // 
            this.lblPrecoGasto.AutoSize = true;
            this.lblPrecoGasto.Location = new System.Drawing.Point(26, 227);
            this.lblPrecoGasto.Name = "lblPrecoGasto";
            this.lblPrecoGasto.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoGasto.TabIndex = 2;
            this.lblPrecoGasto.Text = "Preço do Gasto:";
            // 
            // bntSalvarDespesas
            // 
            this.bntSalvarDespesas.Location = new System.Drawing.Point(480, 449);
            this.bntSalvarDespesas.Name = "bntSalvarDespesas";
            this.bntSalvarDespesas.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarDespesas.TabIndex = 1;
            this.bntSalvarDespesas.Text = "Salvar";
            this.bntSalvarDespesas.UseVisualStyleBackColor = true;
            this.bntSalvarDespesas.Click += new System.EventHandler(this.bntSalvarDespesas_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(191, 448);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 0;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // tabProcurarCompra
            // 
            this.tabProcurarCompra.Controls.Add(this.bntCompraVoltar);
            this.tabProcurarCompra.Controls.Add(this.dataGridViewCompraPeca);
            this.tabProcurarCompra.Controls.Add(this.txtCompraCodigo);
            this.tabProcurarCompra.Controls.Add(this.txtCompraNome);
            this.tabProcurarCompra.Controls.Add(this.lblCompraCodigo);
            this.tabProcurarCompra.Controls.Add(this.lblCompraNome);
            this.tabProcurarCompra.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarCompra.Name = "tabProcurarCompra";
            this.tabProcurarCompra.Size = new System.Drawing.Size(790, 486);
            this.tabProcurarCompra.TabIndex = 2;
            this.tabProcurarCompra.Text = "Procurar Compra de Peça";
            this.tabProcurarCompra.UseVisualStyleBackColor = true;
            // 
            // bntCompraVoltar
            // 
            this.bntCompraVoltar.Location = new System.Drawing.Point(350, 460);
            this.bntCompraVoltar.Name = "bntCompraVoltar";
            this.bntCompraVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntCompraVoltar.TabIndex = 5;
            this.bntCompraVoltar.Text = "Voltar";
            this.bntCompraVoltar.UseVisualStyleBackColor = true;
            this.bntCompraVoltar.Click += new System.EventHandler(this.bntCompraVoltar_Click);
            // 
            // dataGridViewCompraPeca
            // 
            this.dataGridViewCompraPeca.AllowUserToAddRows = false;
            this.dataGridViewCompraPeca.AllowUserToDeleteRows = false;
            this.dataGridViewCompraPeca.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCompraPeca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCompraPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompraPeca.Location = new System.Drawing.Point(19, 81);
            this.dataGridViewCompraPeca.Name = "dataGridViewCompraPeca";
            this.dataGridViewCompraPeca.ReadOnly = true;
            this.dataGridViewCompraPeca.Size = new System.Drawing.Size(753, 359);
            this.dataGridViewCompraPeca.TabIndex = 4;
            // 
            // txtCompraCodigo
            // 
            this.txtCompraCodigo.Location = new System.Drawing.Point(626, 34);
            this.txtCompraCodigo.Name = "txtCompraCodigo";
            this.txtCompraCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCompraCodigo.TabIndex = 3;
            // 
            // txtCompraNome
            // 
            this.txtCompraNome.Location = new System.Drawing.Point(121, 31);
            this.txtCompraNome.Name = "txtCompraNome";
            this.txtCompraNome.Size = new System.Drawing.Size(349, 20);
            this.txtCompraNome.TabIndex = 2;
            // 
            // lblCompraCodigo
            // 
            this.lblCompraCodigo.AutoSize = true;
            this.lblCompraCodigo.Location = new System.Drawing.Point(516, 37);
            this.lblCompraCodigo.Name = "lblCompraCodigo";
            this.lblCompraCodigo.Size = new System.Drawing.Size(104, 13);
            this.lblCompraCodigo.TabIndex = 1;
            this.lblCompraCodigo.Text = "Procurar por Código:";
            // 
            // lblCompraNome
            // 
            this.lblCompraNome.AutoSize = true;
            this.lblCompraNome.Location = new System.Drawing.Point(16, 34);
            this.lblCompraNome.Name = "lblCompraNome";
            this.lblCompraNome.Size = new System.Drawing.Size(99, 13);
            this.lblCompraNome.TabIndex = 0;
            this.lblCompraNome.Text = "Procurar por Nome:";
            // 
            // tabCadastrarCompra
            // 
            this.tabCadastrarCompra.Controls.Add(this.lblErroNomeProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblErroPrecoVendaProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblErroPrecoTotalCompra);
            this.tabCadastrarCompra.Controls.Add(this.lblErroPrecoPorPeca);
            this.tabCadastrarCompra.Controls.Add(this.lblErroQtdeComprada);
            this.tabCadastrarCompra.Controls.Add(this.lblErroCodigoFornecedor);
            this.tabCadastrarCompra.Controls.Add(this.lblErroCodigoProduto);
            this.tabCadastrarCompra.Controls.Add(this.cbProduto);
            this.tabCadastrarCompra.Controls.Add(this.txtPrecoVendaProduto);
            this.tabCadastrarCompra.Controls.Add(this.txtPrecoTotalCompra);
            this.tabCadastrarCompra.Controls.Add(this.txtPrecoPorPeca);
            this.tabCadastrarCompra.Controls.Add(this.txtQtdeComprada);
            this.tabCadastrarCompra.Controls.Add(this.txtProcurarFornecedor);
            this.tabCadastrarCompra.Controls.Add(this.txtNomeProduto);
            this.tabCadastrarCompra.Controls.Add(this.txtProcurarProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblPrecoTotalCompra);
            this.tabCadastrarCompra.Controls.Add(this.lblPrecoVendaProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblPrecoPorPeca);
            this.tabCadastrarCompra.Controls.Add(this.bntProcurarFornecedor);
            this.tabCadastrarCompra.Controls.Add(this.lblQtdeComprada);
            this.tabCadastrarCompra.Controls.Add(this.lblCodigoFornecedor);
            this.tabCadastrarCompra.Controls.Add(this.lblNomeProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblNovoProduto);
            this.tabCadastrarCompra.Controls.Add(this.lblCodigoProduto);
            this.tabCadastrarCompra.Controls.Add(this.bntProcuraProduto);
            this.tabCadastrarCompra.Controls.Add(this.bntSalvarCompra);
            this.tabCadastrarCompra.Controls.Add(this.bntCancelarCompra);
            this.tabCadastrarCompra.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarCompra.Name = "tabCadastrarCompra";
            this.tabCadastrarCompra.Size = new System.Drawing.Size(790, 486);
            this.tabCadastrarCompra.TabIndex = 3;
            this.tabCadastrarCompra.Text = "Cadastrar Compra de Peça";
            this.tabCadastrarCompra.UseVisualStyleBackColor = true;
            // 
            // lblErroNomeProduto
            // 
            this.lblErroNomeProduto.AutoSize = true;
            this.lblErroNomeProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeProduto.Location = new System.Drawing.Point(101, 148);
            this.lblErroNomeProduto.Name = "lblErroNomeProduto";
            this.lblErroNomeProduto.Size = new System.Drawing.Size(0, 13);
            this.lblErroNomeProduto.TabIndex = 28;
            // 
            // lblErroPrecoVendaProduto
            // 
            this.lblErroPrecoVendaProduto.AutoSize = true;
            this.lblErroPrecoVendaProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoVendaProduto.Location = new System.Drawing.Point(531, 330);
            this.lblErroPrecoVendaProduto.Name = "lblErroPrecoVendaProduto";
            this.lblErroPrecoVendaProduto.Size = new System.Drawing.Size(0, 13);
            this.lblErroPrecoVendaProduto.TabIndex = 27;
            // 
            // lblErroPrecoTotalCompra
            // 
            this.lblErroPrecoTotalCompra.AutoSize = true;
            this.lblErroPrecoTotalCompra.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoTotalCompra.Location = new System.Drawing.Point(193, 330);
            this.lblErroPrecoTotalCompra.Name = "lblErroPrecoTotalCompra";
            this.lblErroPrecoTotalCompra.Size = new System.Drawing.Size(0, 13);
            this.lblErroPrecoTotalCompra.TabIndex = 26;
            // 
            // lblErroPrecoPorPeca
            // 
            this.lblErroPrecoPorPeca.AutoSize = true;
            this.lblErroPrecoPorPeca.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoPorPeca.Location = new System.Drawing.Point(531, 227);
            this.lblErroPrecoPorPeca.Name = "lblErroPrecoPorPeca";
            this.lblErroPrecoPorPeca.Size = new System.Drawing.Size(0, 13);
            this.lblErroPrecoPorPeca.TabIndex = 25;
            // 
            // lblErroQtdeComprada
            // 
            this.lblErroQtdeComprada.AutoSize = true;
            this.lblErroQtdeComprada.ForeColor = System.Drawing.Color.Red;
            this.lblErroQtdeComprada.Location = new System.Drawing.Point(193, 227);
            this.lblErroQtdeComprada.Name = "lblErroQtdeComprada";
            this.lblErroQtdeComprada.Size = new System.Drawing.Size(0, 13);
            this.lblErroQtdeComprada.TabIndex = 24;
            // 
            // lblErroCodigoFornecedor
            // 
            this.lblErroCodigoFornecedor.AutoSize = true;
            this.lblErroCodigoFornecedor.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoFornecedor.Location = new System.Drawing.Point(544, 105);
            this.lblErroCodigoFornecedor.Name = "lblErroCodigoFornecedor";
            this.lblErroCodigoFornecedor.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoFornecedor.TabIndex = 23;
            // 
            // lblErroCodigoProduto
            // 
            this.lblErroCodigoProduto.AutoSize = true;
            this.lblErroCodigoProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoProduto.Location = new System.Drawing.Point(398, 63);
            this.lblErroCodigoProduto.Name = "lblErroCodigoProduto";
            this.lblErroCodigoProduto.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoProduto.TabIndex = 22;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(149, 43);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(15, 14);
            this.cbProduto.TabIndex = 20;
            this.cbProduto.UseVisualStyleBackColor = true;
            this.cbProduto.CheckedChanged += new System.EventHandler(this.cbProduto_CheckedChanged);
            // 
            // txtPrecoVendaProduto
            // 
            this.txtPrecoVendaProduto.Location = new System.Drawing.Point(534, 301);
            this.txtPrecoVendaProduto.Name = "txtPrecoVendaProduto";
            this.txtPrecoVendaProduto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVendaProduto.TabIndex = 19;
            // 
            // txtPrecoTotalCompra
            // 
            this.txtPrecoTotalCompra.Location = new System.Drawing.Point(196, 301);
            this.txtPrecoTotalCompra.Name = "txtPrecoTotalCompra";
            this.txtPrecoTotalCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoTotalCompra.TabIndex = 18;
            // 
            // txtPrecoPorPeca
            // 
            this.txtPrecoPorPeca.Location = new System.Drawing.Point(534, 202);
            this.txtPrecoPorPeca.Name = "txtPrecoPorPeca";
            this.txtPrecoPorPeca.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoPorPeca.TabIndex = 17;
            // 
            // txtQtdeComprada
            // 
            this.txtQtdeComprada.Location = new System.Drawing.Point(196, 199);
            this.txtQtdeComprada.Name = "txtQtdeComprada";
            this.txtQtdeComprada.Size = new System.Drawing.Size(100, 20);
            this.txtQtdeComprada.TabIndex = 16;
            // 
            // txtProcurarFornecedor
            // 
            this.txtProcurarFornecedor.Location = new System.Drawing.Point(541, 125);
            this.txtProcurarFornecedor.Name = "txtProcurarFornecedor";
            this.txtProcurarFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarFornecedor.TabIndex = 15;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(104, 125);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(294, 20);
            this.txtNomeProduto.TabIndex = 14;
            // 
            // txtProcurarProduto
            // 
            this.txtProcurarProduto.Location = new System.Drawing.Point(400, 40);
            this.txtProcurarProduto.Name = "txtProcurarProduto";
            this.txtProcurarProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarProduto.TabIndex = 13;
            // 
            // lblPrecoTotalCompra
            // 
            this.lblPrecoTotalCompra.AutoSize = true;
            this.lblPrecoTotalCompra.Location = new System.Drawing.Point(71, 304);
            this.lblPrecoTotalCompra.Name = "lblPrecoTotalCompra";
            this.lblPrecoTotalCompra.Size = new System.Drawing.Size(119, 13);
            this.lblPrecoTotalCompra.TabIndex = 12;
            this.lblPrecoTotalCompra.Text = "Preço Total da Compra:";
            // 
            // lblPrecoVendaProduto
            // 
            this.lblPrecoVendaProduto.AutoSize = true;
            this.lblPrecoVendaProduto.Location = new System.Drawing.Point(386, 304);
            this.lblPrecoVendaProduto.Name = "lblPrecoVendaProduto";
            this.lblPrecoVendaProduto.Size = new System.Drawing.Size(142, 13);
            this.lblPrecoVendaProduto.TabIndex = 11;
            this.lblPrecoVendaProduto.Text = "Preço de Venda do Produto:";
            // 
            // lblPrecoPorPeca
            // 
            this.lblPrecoPorPeca.AutoSize = true;
            this.lblPrecoPorPeca.Location = new System.Drawing.Point(444, 205);
            this.lblPrecoPorPeca.Name = "lblPrecoPorPeca";
            this.lblPrecoPorPeca.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoPorPeca.TabIndex = 10;
            this.lblPrecoPorPeca.Text = "Preço por Peça:";
            // 
            // bntProcurarFornecedor
            // 
            this.bntProcurarFornecedor.Location = new System.Drawing.Point(649, 124);
            this.bntProcurarFornecedor.Name = "bntProcurarFornecedor";
            this.bntProcurarFornecedor.Size = new System.Drawing.Size(96, 23);
            this.bntProcurarFornecedor.TabIndex = 9;
            this.bntProcurarFornecedor.Text = "Procurar Código";
            this.bntProcurarFornecedor.UseVisualStyleBackColor = true;
            // 
            // lblQtdeComprada
            // 
            this.lblQtdeComprada.AutoSize = true;
            this.lblQtdeComprada.Location = new System.Drawing.Point(74, 202);
            this.lblQtdeComprada.Name = "lblQtdeComprada";
            this.lblQtdeComprada.Size = new System.Drawing.Size(116, 13);
            this.lblQtdeComprada.TabIndex = 8;
            this.lblQtdeComprada.Text = "Quantidade Comprada:";
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(420, 125);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(115, 13);
            this.lblCodigoFornecedor.TabIndex = 6;
            this.lblCodigoFornecedor.Text = "Código do Fornecedor:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(20, 125);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(78, 13);
            this.lblNomeProduto.TabIndex = 5;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // lblNovoProduto
            // 
            this.lblNovoProduto.AutoSize = true;
            this.lblNovoProduto.Location = new System.Drawing.Point(70, 43);
            this.lblNovoProduto.Name = "lblNovoProduto";
            this.lblNovoProduto.Size = new System.Drawing.Size(73, 13);
            this.lblNovoProduto.TabIndex = 4;
            this.lblNovoProduto.Text = "Novo Produto";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(296, 40);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(98, 13);
            this.lblCodigoProduto.TabIndex = 3;
            this.lblCodigoProduto.Text = "Código do Produto:";
            // 
            // bntProcuraProduto
            // 
            this.bntProcuraProduto.Location = new System.Drawing.Point(509, 40);
            this.bntProcuraProduto.Name = "bntProcuraProduto";
            this.bntProcuraProduto.Size = new System.Drawing.Size(96, 23);
            this.bntProcuraProduto.TabIndex = 2;
            this.bntProcuraProduto.Text = "Procurar Código";
            this.bntProcuraProduto.UseVisualStyleBackColor = true;
            // 
            // bntSalvarCompra
            // 
            this.bntSalvarCompra.Location = new System.Drawing.Point(511, 432);
            this.bntSalvarCompra.Name = "bntSalvarCompra";
            this.bntSalvarCompra.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarCompra.TabIndex = 1;
            this.bntSalvarCompra.Text = "Salvar";
            this.bntSalvarCompra.UseVisualStyleBackColor = true;
            this.bntSalvarCompra.Click += new System.EventHandler(this.bntSalvarCompra_Click);
            // 
            // bntCancelarCompra
            // 
            this.bntCancelarCompra.Location = new System.Drawing.Point(196, 435);
            this.bntCancelarCompra.Name = "bntCancelarCompra";
            this.bntCancelarCompra.Size = new System.Drawing.Size(75, 23);
            this.bntCancelarCompra.TabIndex = 0;
            this.bntCancelarCompra.Text = "Cancelar";
            this.bntCancelarCompra.UseVisualStyleBackColor = true;
            this.bntCancelarCompra.Click += new System.EventHandler(this.bntCancelarCompra_Click);
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 597);
            this.Controls.Add(this.tabDespesas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Despesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.tabDespesas.ResumeLayout(false);
            this.tabProcurarDespesas.ResumeLayout(false);
            this.tabProcurarDespesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDespesas)).EndInit();
            this.tabCadastrarDespesas.ResumeLayout(false);
            this.tabCadastrarDespesas.PerformLayout();
            this.tabProcurarCompra.ResumeLayout(false);
            this.tabProcurarCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraPeca)).EndInit();
            this.tabCadastrarCompra.ResumeLayout(false);
            this.tabCadastrarCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDespesas;
        private System.Windows.Forms.TabPage tabProcurarDespesas;
        private System.Windows.Forms.TabPage tabCadastrarDespesas;
        private System.Windows.Forms.Button bntDespesasVoltar;
        private System.Windows.Forms.DataGridView dataGridViewDespesas;
        private System.Windows.Forms.TextBox txtDespesasCodigo;
        private System.Windows.Forms.TextBox txtDespesasNome;
        private System.Windows.Forms.Label lblCodigoDespesas;
        private System.Windows.Forms.Label lblDespesasNome;
        private System.Windows.Forms.Label lblDataPagamentoGasto;
        private System.Windows.Forms.Label lblNomeGasto;
        private System.Windows.Forms.Label lblDescricaoGasto;
        private System.Windows.Forms.Label lblPrecoGasto;
        private System.Windows.Forms.Button bntSalvarDespesas;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.MonthCalendar mcdDespesas;
        private System.Windows.Forms.TextBox txtDescricaoGasto;
        private System.Windows.Forms.TextBox txtPrecoGasto;
        private System.Windows.Forms.TextBox txtNomeGasto;
        private System.Windows.Forms.TabPage tabProcurarCompra;
        private System.Windows.Forms.TabPage tabCadastrarCompra;
        private System.Windows.Forms.Button bntCompraVoltar;
        private System.Windows.Forms.DataGridView dataGridViewCompraPeca;
        private System.Windows.Forms.TextBox txtCompraCodigo;
        private System.Windows.Forms.TextBox txtCompraNome;
        private System.Windows.Forms.Label lblCompraCodigo;
        private System.Windows.Forms.Label lblCompraNome;
        private System.Windows.Forms.Label lblPrecoTotalCompra;
        private System.Windows.Forms.Label lblPrecoVendaProduto;
        private System.Windows.Forms.Label lblPrecoPorPeca;
        private System.Windows.Forms.Button bntProcurarFornecedor;
        private System.Windows.Forms.Label lblQtdeComprada;
        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblNovoProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Button bntProcuraProduto;
        private System.Windows.Forms.Button bntSalvarCompra;
        private System.Windows.Forms.Button bntCancelarCompra;
        private System.Windows.Forms.TextBox txtPrecoVendaProduto;
        private System.Windows.Forms.TextBox txtPrecoTotalCompra;
        private System.Windows.Forms.TextBox txtPrecoPorPeca;
        private System.Windows.Forms.TextBox txtQtdeComprada;
        private System.Windows.Forms.TextBox txtProcurarFornecedor;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtProcurarProduto;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.Label lblErroDataPagamentoGasto;
        private System.Windows.Forms.Label lblErroPrecoGasto;
        private System.Windows.Forms.Label lblErroNomeGasto;
        private System.Windows.Forms.Label lblErroPrecoVendaProduto;
        private System.Windows.Forms.Label lblErroPrecoTotalCompra;
        private System.Windows.Forms.Label lblErroPrecoPorPeca;
        private System.Windows.Forms.Label lblErroQtdeComprada;
        private System.Windows.Forms.Label lblErroCodigoFornecedor;
        private System.Windows.Forms.Label lblErroCodigoProduto;
        private System.Windows.Forms.Label lblErroNomeProduto;
    }
}