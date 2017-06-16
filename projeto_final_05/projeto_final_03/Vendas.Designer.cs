namespace projeto_final_03
{
    partial class Vendas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrarVenda = new System.Windows.Forms.TabPage();
            this.lblErroDataVenda = new System.Windows.Forms.Label();
            this.lblErroQtdeVendida = new System.Windows.Forms.Label();
            this.lblErroFormaPagar = new System.Windows.Forms.Label();
            this.lblErroPrecoTotal = new System.Windows.Forms.Label();
            this.lblErroCodigoProduto = new System.Windows.Forms.Label();
            this.lblErroCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblErroServProd = new System.Windows.Forms.Label();
            this.bntCodigo = new System.Windows.Forms.Button();
            this.mcdVenda = new System.Windows.Forms.MonthCalendar();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntCodigoFuncionario = new System.Windows.Forms.Button();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.txtQtdeVendida = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rdServico = new System.Windows.Forms.RadioButton();
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblFormaPagar = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.lblQtdeVendida = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tabProcurarVenda = new System.Windows.Forms.TabPage();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.dataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.txtProcurarCodigo = new System.Windows.Forms.TextBox();
            this.lblProcurarCodigo = new System.Windows.Forms.Label();
            this.lblProcurarNome = new System.Windows.Forms.Label();
            this.cbFormaPaga = new System.Windows.Forms.ComboBox();
            this.cbProcurarFormaPaga = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabCadastrarVenda.SuspendLayout();
            this.tabProcurarVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrarVenda);
            this.tabControl1.Controls.Add(this.tabProcurarVenda);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastrarVenda
            // 
            this.tabCadastrarVenda.Controls.Add(this.cbFormaPaga);
            this.tabCadastrarVenda.Controls.Add(this.lblErroDataVenda);
            this.tabCadastrarVenda.Controls.Add(this.lblErroQtdeVendida);
            this.tabCadastrarVenda.Controls.Add(this.lblErroFormaPagar);
            this.tabCadastrarVenda.Controls.Add(this.lblErroPrecoTotal);
            this.tabCadastrarVenda.Controls.Add(this.lblErroCodigoProduto);
            this.tabCadastrarVenda.Controls.Add(this.lblErroCodigoFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.lblErroServProd);
            this.tabCadastrarVenda.Controls.Add(this.bntCodigo);
            this.tabCadastrarVenda.Controls.Add(this.mcdVenda);
            this.tabCadastrarVenda.Controls.Add(this.bntSalvar);
            this.tabCadastrarVenda.Controls.Add(this.bntCancelar);
            this.tabCadastrarVenda.Controls.Add(this.bntCodigoFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.txtCodigoFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.txtObservacao);
            this.tabCadastrarVenda.Controls.Add(this.txtPrecoTotal);
            this.tabCadastrarVenda.Controls.Add(this.txtQtdeVendida);
            this.tabCadastrarVenda.Controls.Add(this.txtCodigo);
            this.tabCadastrarVenda.Controls.Add(this.rdServico);
            this.tabCadastrarVenda.Controls.Add(this.rdProduto);
            this.tabCadastrarVenda.Controls.Add(this.lblCodigoFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.lblObservacao);
            this.tabCadastrarVenda.Controls.Add(this.lblFormaPagar);
            this.tabCadastrarVenda.Controls.Add(this.lblDataVenda);
            this.tabCadastrarVenda.Controls.Add(this.lblQtdeVendida);
            this.tabCadastrarVenda.Controls.Add(this.lblPrecoTotal);
            this.tabCadastrarVenda.Controls.Add(this.lblCodigo);
            this.tabCadastrarVenda.Controls.Add(this.lblServico);
            this.tabCadastrarVenda.Controls.Add(this.lblProduto);
            this.tabCadastrarVenda.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarVenda.Name = "tabCadastrarVenda";
            this.tabCadastrarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarVenda.Size = new System.Drawing.Size(791, 509);
            this.tabCadastrarVenda.TabIndex = 0;
            this.tabCadastrarVenda.Text = "Cadastrar Venda";
            this.tabCadastrarVenda.UseVisualStyleBackColor = true;
            // 
            // lblErroDataVenda
            // 
            this.lblErroDataVenda.AutoSize = true;
            this.lblErroDataVenda.ForeColor = System.Drawing.Color.Red;
            this.lblErroDataVenda.Location = new System.Drawing.Point(664, 119);
            this.lblErroDataVenda.Name = "lblErroDataVenda";
            this.lblErroDataVenda.Size = new System.Drawing.Size(0, 13);
            this.lblErroDataVenda.TabIndex = 28;
            // 
            // lblErroQtdeVendida
            // 
            this.lblErroQtdeVendida.AutoSize = true;
            this.lblErroQtdeVendida.ForeColor = System.Drawing.Color.Red;
            this.lblErroQtdeVendida.Location = new System.Drawing.Point(244, 183);
            this.lblErroQtdeVendida.Name = "lblErroQtdeVendida";
            this.lblErroQtdeVendida.Size = new System.Drawing.Size(0, 13);
            this.lblErroQtdeVendida.TabIndex = 27;
            // 
            // lblErroFormaPagar
            // 
            this.lblErroFormaPagar.AutoSize = true;
            this.lblErroFormaPagar.ForeColor = System.Drawing.Color.Red;
            this.lblErroFormaPagar.Location = new System.Drawing.Point(298, 307);
            this.lblErroFormaPagar.Name = "lblErroFormaPagar";
            this.lblErroFormaPagar.Size = new System.Drawing.Size(0, 13);
            this.lblErroFormaPagar.TabIndex = 26;
            // 
            // lblErroPrecoTotal
            // 
            this.lblErroPrecoTotal.AutoSize = true;
            this.lblErroPrecoTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoTotal.Location = new System.Drawing.Point(244, 243);
            this.lblErroPrecoTotal.Name = "lblErroPrecoTotal";
            this.lblErroPrecoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblErroPrecoTotal.TabIndex = 25;
            // 
            // lblErroCodigoProduto
            // 
            this.lblErroCodigoProduto.AutoSize = true;
            this.lblErroCodigoProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoProduto.Location = new System.Drawing.Point(352, 122);
            this.lblErroCodigoProduto.Name = "lblErroCodigoProduto";
            this.lblErroCodigoProduto.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoProduto.TabIndex = 24;
            // 
            // lblErroCodigoFuncionario
            // 
            this.lblErroCodigoFuncionario.AutoSize = true;
            this.lblErroCodigoFuncionario.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoFuncionario.Location = new System.Drawing.Point(464, 70);
            this.lblErroCodigoFuncionario.Name = "lblErroCodigoFuncionario";
            this.lblErroCodigoFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoFuncionario.TabIndex = 23;
            // 
            // lblErroServProd
            // 
            this.lblErroServProd.AutoSize = true;
            this.lblErroServProd.ForeColor = System.Drawing.Color.Red;
            this.lblErroServProd.Location = new System.Drawing.Point(162, 58);
            this.lblErroServProd.Name = "lblErroServProd";
            this.lblErroServProd.Size = new System.Drawing.Size(0, 13);
            this.lblErroServProd.TabIndex = 22;
            // 
            // bntCodigo
            // 
            this.bntCodigo.Location = new System.Drawing.Point(246, 117);
            this.bntCodigo.Name = "bntCodigo";
            this.bntCodigo.Size = new System.Drawing.Size(100, 23);
            this.bntCodigo.TabIndex = 21;
            this.bntCodigo.Text = "Procurar Código";
            this.bntCodigo.UseVisualStyleBackColor = true;
            // 
            // mcdVenda
            // 
            this.mcdVenda.Location = new System.Drawing.Point(532, 160);
            this.mcdVenda.Name = "mcdVenda";
            this.mcdVenda.TabIndex = 20;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(509, 467);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 19;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(224, 467);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 18;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // bntCodigoFuncionario
            // 
            this.bntCodigoFuncionario.Location = new System.Drawing.Point(597, 34);
            this.bntCodigoFuncionario.Name = "bntCodigoFuncionario";
            this.bntCodigoFuncionario.Size = new System.Drawing.Size(94, 24);
            this.bntCodigoFuncionario.TabIndex = 17;
            this.bntCodigoFuncionario.Text = "Procurar Código";
            this.bntCodigoFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(467, 33);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFuncionario.TabIndex = 16;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(129, 364);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(360, 20);
            this.txtObservacao.TabIndex = 15;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(129, 240);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(109, 20);
            this.txtPrecoTotal.TabIndex = 13;
            // 
            // txtQtdeVendida
            // 
            this.txtQtdeVendida.Location = new System.Drawing.Point(129, 180);
            this.txtQtdeVendida.Name = "txtQtdeVendida";
            this.txtQtdeVendida.Size = new System.Drawing.Size(109, 20);
            this.txtQtdeVendida.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 119);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // rdServico
            // 
            this.rdServico.AutoSize = true;
            this.rdServico.Location = new System.Drawing.Point(129, 72);
            this.rdServico.Name = "rdServico";
            this.rdServico.Size = new System.Drawing.Size(14, 13);
            this.rdServico.TabIndex = 10;
            this.rdServico.TabStop = true;
            this.rdServico.UseVisualStyleBackColor = true;
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Location = new System.Drawing.Point(129, 33);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(14, 13);
            this.rdProduto.TabIndex = 9;
            this.rdProduto.TabStop = true;
            this.rdProduto.UseVisualStyleBackColor = true;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(264, 36);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(197, 13);
            this.lblCodigoFuncionario.TabIndex = 8;
            this.lblCodigoFuncionario.Text = "Código do Funcionário que fez a Venda:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(58, 367);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observação:";
            // 
            // lblFormaPagar
            // 
            this.lblFormaPagar.AutoSize = true;
            this.lblFormaPagar.Location = new System.Drawing.Point(10, 307);
            this.lblFormaPagar.Name = "lblFormaPagar";
            this.lblFormaPagar.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagar.TabIndex = 6;
            this.lblFormaPagar.Text = "Forma de Pagamento:";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(579, 117);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(79, 13);
            this.lblDataVenda.TabIndex = 5;
            this.lblDataVenda.Text = "Data da Venda";
            // 
            // lblQtdeVendida
            // 
            this.lblQtdeVendida.AutoSize = true;
            this.lblQtdeVendida.Location = new System.Drawing.Point(19, 183);
            this.lblQtdeVendida.Name = "lblQtdeVendida";
            this.lblQtdeVendida.Size = new System.Drawing.Size(107, 13);
            this.lblQtdeVendida.TabIndex = 4;
            this.lblQtdeVendida.Text = "Quantidade Vendida:";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Location = new System.Drawing.Point(58, 243);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(65, 13);
            this.lblPrecoTotal.TabIndex = 3;
            this.lblPrecoTotal.Text = "Preço Total:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(80, 122);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(80, 76);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 1;
            this.lblServico.Text = "Serviço";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(79, 33);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // tabProcurarVenda
            // 
            this.tabProcurarVenda.Controls.Add(this.cbProcurarFormaPaga);
            this.tabProcurarVenda.Controls.Add(this.bntVoltar);
            this.tabProcurarVenda.Controls.Add(this.dataGridViewVenda);
            this.tabProcurarVenda.Controls.Add(this.txtProcurarCodigo);
            this.tabProcurarVenda.Controls.Add(this.lblProcurarCodigo);
            this.tabProcurarVenda.Controls.Add(this.lblProcurarNome);
            this.tabProcurarVenda.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarVenda.Name = "tabProcurarVenda";
            this.tabProcurarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcurarVenda.Size = new System.Drawing.Size(791, 509);
            this.tabProcurarVenda.TabIndex = 1;
            this.tabProcurarVenda.Text = "Procurar Venda";
            this.tabProcurarVenda.UseVisualStyleBackColor = true;
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(359, 480);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntVoltar.TabIndex = 5;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // dataGridViewVenda
            // 
            this.dataGridViewVenda.AllowUserToAddRows = false;
            this.dataGridViewVenda.AllowUserToDeleteRows = false;
            this.dataGridViewVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenda.Location = new System.Drawing.Point(21, 79);
            this.dataGridViewVenda.Name = "dataGridViewVenda";
            this.dataGridViewVenda.ReadOnly = true;
            this.dataGridViewVenda.Size = new System.Drawing.Size(752, 395);
            this.dataGridViewVenda.TabIndex = 4;
            // 
            // txtProcurarCodigo
            // 
            this.txtProcurarCodigo.Location = new System.Drawing.Point(633, 41);
            this.txtProcurarCodigo.Name = "txtProcurarCodigo";
            this.txtProcurarCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarCodigo.TabIndex = 3;
            // 
            // lblProcurarCodigo
            // 
            this.lblProcurarCodigo.AutoSize = true;
            this.lblProcurarCodigo.Location = new System.Drawing.Point(523, 44);
            this.lblProcurarCodigo.Name = "lblProcurarCodigo";
            this.lblProcurarCodigo.Size = new System.Drawing.Size(104, 13);
            this.lblProcurarCodigo.TabIndex = 1;
            this.lblProcurarCodigo.Text = "Procurar por Código:";
            // 
            // lblProcurarNome
            // 
            this.lblProcurarNome.AutoSize = true;
            this.lblProcurarNome.Location = new System.Drawing.Point(18, 41);
            this.lblProcurarNome.Name = "lblProcurarNome";
            this.lblProcurarNome.Size = new System.Drawing.Size(164, 13);
            this.lblProcurarNome.TabIndex = 0;
            this.lblProcurarNome.Text = "Procurar por Tipo de Pagamento:";
            // 
            // cbFormaPaga
            // 
            this.cbFormaPaga.FormattingEnabled = true;
            this.cbFormaPaga.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Cheque",
            "Boleto",
            "Outros"});
            this.cbFormaPaga.Location = new System.Drawing.Point(129, 307);
            this.cbFormaPaga.Name = "cbFormaPaga";
            this.cbFormaPaga.Size = new System.Drawing.Size(150, 21);
            this.cbFormaPaga.TabIndex = 29;
            // 
            // cbProcurarFormaPaga
            // 
            this.cbProcurarFormaPaga.FormattingEnabled = true;
            this.cbProcurarFormaPaga.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Cheque",
            "Boleto",
            "Outros"});
            this.cbProcurarFormaPaga.Location = new System.Drawing.Point(188, 36);
            this.cbProcurarFormaPaga.Name = "cbProcurarFormaPaga";
            this.cbProcurarFormaPaga.Size = new System.Drawing.Size(195, 21);
            this.cbProcurarFormaPaga.TabIndex = 6;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrarVenda.ResumeLayout(false);
            this.tabCadastrarVenda.PerformLayout();
            this.tabProcurarVenda.ResumeLayout(false);
            this.tabProcurarVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrarVenda;
        private System.Windows.Forms.TabPage tabProcurarVenda;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblFormaPagar;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.Label lblQtdeVendida;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button bntCodigo;
        private System.Windows.Forms.MonthCalendar mcdVenda;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntCodigoFuncionario;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.TextBox txtQtdeVendida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rdServico;
        private System.Windows.Forms.RadioButton rdProduto;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.DataGridView dataGridViewVenda;
        private System.Windows.Forms.TextBox txtProcurarCodigo;
        private System.Windows.Forms.Label lblProcurarCodigo;
        private System.Windows.Forms.Label lblProcurarNome;
        private System.Windows.Forms.Label lblErroDataVenda;
        private System.Windows.Forms.Label lblErroQtdeVendida;
        private System.Windows.Forms.Label lblErroFormaPagar;
        private System.Windows.Forms.Label lblErroPrecoTotal;
        private System.Windows.Forms.Label lblErroCodigoProduto;
        private System.Windows.Forms.Label lblErroCodigoFuncionario;
        private System.Windows.Forms.Label lblErroServProd;
        private System.Windows.Forms.ComboBox cbFormaPaga;
        private System.Windows.Forms.ComboBox cbProcurarFormaPaga;
    }
}