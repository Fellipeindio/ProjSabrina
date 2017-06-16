namespace projeto_final_03
{
    partial class Fornecedor
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
            this.tabFornecedor = new System.Windows.Forms.TabControl();
            this.tabProcurarFornecedor = new System.Windows.Forms.TabPage();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.txtUltimaDataDespesas = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblUltimaCompraFornecedor = new System.Windows.Forms.Label();
            this.lblProcurarNome = new System.Windows.Forms.Label();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.tabCadastrarFornecedor = new System.Windows.Forms.TabPage();
            this.lblErroFoneMovel1 = new System.Windows.Forms.Label();
            this.lblErroNumero = new System.Windows.Forms.Label();
            this.lblErroEndereco = new System.Windows.Forms.Label();
            this.lblErroNomeFornecedor = new System.Windows.Forms.Label();
            this.mtbFoneMovel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbFoneMovel1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbFoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDadoEndereco = new System.Windows.Forms.Label();
            this.lblFoneMovel2 = new System.Windows.Forms.Label();
            this.lblFoneFixo = new System.Windows.Forms.Label();
            this.lblFoneMovel1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCadastrarNome = new System.Windows.Forms.Label();
            this.bntSalvarFornecedor = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.tabFornecedor.SuspendLayout();
            this.tabProcurarFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.tabCadastrarFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.tabProcurarFornecedor);
            this.tabFornecedor.Controls.Add(this.tabCadastrarFornecedor);
            this.tabFornecedor.Location = new System.Drawing.Point(12, 70);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.SelectedIndex = 0;
            this.tabFornecedor.Size = new System.Drawing.Size(797, 515);
            this.tabFornecedor.TabIndex = 0;
            // 
            // tabProcurarFornecedor
            // 
            this.tabProcurarFornecedor.Controls.Add(this.dataGridViewFornecedor);
            this.tabProcurarFornecedor.Controls.Add(this.txtUltimaDataDespesas);
            this.tabProcurarFornecedor.Controls.Add(this.txtNomeFornecedor);
            this.tabProcurarFornecedor.Controls.Add(this.lblUltimaCompraFornecedor);
            this.tabProcurarFornecedor.Controls.Add(this.lblProcurarNome);
            this.tabProcurarFornecedor.Controls.Add(this.bntVoltar);
            this.tabProcurarFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarFornecedor.Name = "tabProcurarFornecedor";
            this.tabProcurarFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcurarFornecedor.Size = new System.Drawing.Size(789, 489);
            this.tabProcurarFornecedor.TabIndex = 0;
            this.tabProcurarFornecedor.Text = "Procurar Fornecedor";
            this.tabProcurarFornecedor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AllowUserToAddRows = false;
            this.dataGridViewFornecedor.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(20, 84);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(754, 366);
            this.dataGridViewFornecedor.TabIndex = 5;
            // 
            // txtUltimaDataDespesas
            // 
            this.txtUltimaDataDespesas.Location = new System.Drawing.Point(661, 38);
            this.txtUltimaDataDespesas.Name = "txtUltimaDataDespesas";
            this.txtUltimaDataDespesas.Size = new System.Drawing.Size(113, 20);
            this.txtUltimaDataDespesas.TabIndex = 4;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(189, 38);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(282, 20);
            this.txtNomeFornecedor.TabIndex = 3;
            // 
            // lblUltimaCompraFornecedor
            // 
            this.lblUltimaCompraFornecedor.AutoSize = true;
            this.lblUltimaCompraFornecedor.Location = new System.Drawing.Point(494, 41);
            this.lblUltimaCompraFornecedor.Name = "lblUltimaCompraFornecedor";
            this.lblUltimaCompraFornecedor.Size = new System.Drawing.Size(162, 13);
            this.lblUltimaCompraFornecedor.TabIndex = 2;
            this.lblUltimaCompraFornecedor.Text = "Procurar Data da Última Compra:";
            // 
            // lblProcurarNome
            // 
            this.lblProcurarNome.AutoSize = true;
            this.lblProcurarNome.Location = new System.Drawing.Point(17, 41);
            this.lblProcurarNome.Name = "lblProcurarNome";
            this.lblProcurarNome.Size = new System.Drawing.Size(171, 13);
            this.lblProcurarNome.TabIndex = 1;
            this.lblProcurarNome.Text = "Procurar por Nome do Fornecedor:";
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(355, 460);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntVoltar.TabIndex = 0;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // tabCadastrarFornecedor
            // 
            this.tabCadastrarFornecedor.Controls.Add(this.lblErroFoneMovel1);
            this.tabCadastrarFornecedor.Controls.Add(this.lblErroNumero);
            this.tabCadastrarFornecedor.Controls.Add(this.lblErroEndereco);
            this.tabCadastrarFornecedor.Controls.Add(this.lblErroNomeFornecedor);
            this.tabCadastrarFornecedor.Controls.Add(this.mtbFoneMovel2);
            this.tabCadastrarFornecedor.Controls.Add(this.mtbFoneMovel1);
            this.tabCadastrarFornecedor.Controls.Add(this.mtbFoneFixo);
            this.tabCadastrarFornecedor.Controls.Add(this.txtComplemento);
            this.tabCadastrarFornecedor.Controls.Add(this.txtNumero);
            this.tabCadastrarFornecedor.Controls.Add(this.txtEndereco);
            this.tabCadastrarFornecedor.Controls.Add(this.txtEmail);
            this.tabCadastrarFornecedor.Controls.Add(this.txtNome);
            this.tabCadastrarFornecedor.Controls.Add(this.lblComplemento);
            this.tabCadastrarFornecedor.Controls.Add(this.lblNumero);
            this.tabCadastrarFornecedor.Controls.Add(this.lblEndereco);
            this.tabCadastrarFornecedor.Controls.Add(this.lblDadoEndereco);
            this.tabCadastrarFornecedor.Controls.Add(this.lblFoneMovel2);
            this.tabCadastrarFornecedor.Controls.Add(this.lblFoneFixo);
            this.tabCadastrarFornecedor.Controls.Add(this.lblFoneMovel1);
            this.tabCadastrarFornecedor.Controls.Add(this.lblEmail);
            this.tabCadastrarFornecedor.Controls.Add(this.lblCadastrarNome);
            this.tabCadastrarFornecedor.Controls.Add(this.bntSalvarFornecedor);
            this.tabCadastrarFornecedor.Controls.Add(this.bntCancelar);
            this.tabCadastrarFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarFornecedor.Name = "tabCadastrarFornecedor";
            this.tabCadastrarFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarFornecedor.Size = new System.Drawing.Size(789, 489);
            this.tabCadastrarFornecedor.TabIndex = 1;
            this.tabCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.tabCadastrarFornecedor.UseVisualStyleBackColor = true;
            // 
            // lblErroFoneMovel1
            // 
            this.lblErroFoneMovel1.AutoSize = true;
            this.lblErroFoneMovel1.ForeColor = System.Drawing.Color.Red;
            this.lblErroFoneMovel1.Location = new System.Drawing.Point(232, 194);
            this.lblErroFoneMovel1.Name = "lblErroFoneMovel1";
            this.lblErroFoneMovel1.Size = new System.Drawing.Size(0, 13);
            this.lblErroFoneMovel1.TabIndex = 27;
            // 
            // lblErroNumero
            // 
            this.lblErroNumero.AutoSize = true;
            this.lblErroNumero.ForeColor = System.Drawing.Color.Red;
            this.lblErroNumero.Location = new System.Drawing.Point(507, 211);
            this.lblErroNumero.Name = "lblErroNumero";
            this.lblErroNumero.Size = new System.Drawing.Size(0, 13);
            this.lblErroNumero.TabIndex = 26;
            // 
            // lblErroEndereco
            // 
            this.lblErroEndereco.AutoSize = true;
            this.lblErroEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblErroEndereco.Location = new System.Drawing.Point(431, 177);
            this.lblErroEndereco.Name = "lblErroEndereco";
            this.lblErroEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblErroEndereco.TabIndex = 25;
            // 
            // lblErroNomeFornecedor
            // 
            this.lblErroNomeFornecedor.AutoSize = true;
            this.lblErroNomeFornecedor.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeFornecedor.Location = new System.Drawing.Point(582, 62);
            this.lblErroNomeFornecedor.Name = "lblErroNomeFornecedor";
            this.lblErroNomeFornecedor.Size = new System.Drawing.Size(0, 13);
            this.lblErroNomeFornecedor.TabIndex = 24;
            // 
            // mtbFoneMovel2
            // 
            this.mtbFoneMovel2.Location = new System.Drawing.Point(126, 260);
            this.mtbFoneMovel2.Mask = "(00) 00000-0000";
            this.mtbFoneMovel2.Name = "mtbFoneMovel2";
            this.mtbFoneMovel2.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneMovel2.TabIndex = 23;
            // 
            // mtbFoneMovel1
            // 
            this.mtbFoneMovel1.Location = new System.Drawing.Point(126, 189);
            this.mtbFoneMovel1.Mask = "(00) 00000-0000";
            this.mtbFoneMovel1.Name = "mtbFoneMovel1";
            this.mtbFoneMovel1.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneMovel1.TabIndex = 22;
            // 
            // mtbFoneFixo
            // 
            this.mtbFoneFixo.Location = new System.Drawing.Point(126, 121);
            this.mtbFoneFixo.Mask = "(00) 00000-0000";
            this.mtbFoneFixo.Name = "mtbFoneFixo";
            this.mtbFoneFixo.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneFixo.TabIndex = 21;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(425, 274);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(334, 20);
            this.txtComplemento.TabIndex = 19;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(425, 208);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 18;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(425, 149);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(334, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 20);
            this.txtNome.TabIndex = 12;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(345, 276);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 10;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(372, 211);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(363, 152);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDadoEndereco
            // 
            this.lblDadoEndereco.AutoSize = true;
            this.lblDadoEndereco.Location = new System.Drawing.Point(539, 101);
            this.lblDadoEndereco.Name = "lblDadoEndereco";
            this.lblDadoEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblDadoEndereco.TabIndex = 7;
            this.lblDadoEndereco.Text = "Endereço";
            // 
            // lblFoneMovel2
            // 
            this.lblFoneMovel2.AutoSize = true;
            this.lblFoneMovel2.Location = new System.Drawing.Point(21, 263);
            this.lblFoneMovel2.Name = "lblFoneMovel2";
            this.lblFoneMovel2.Size = new System.Drawing.Size(99, 13);
            this.lblFoneMovel2.TabIndex = 6;
            this.lblFoneMovel2.Text = "Telefone Móvel (2):";
            // 
            // lblFoneFixo
            // 
            this.lblFoneFixo.AutoSize = true;
            this.lblFoneFixo.Location = new System.Drawing.Point(46, 124);
            this.lblFoneFixo.Name = "lblFoneFixo";
            this.lblFoneFixo.Size = new System.Drawing.Size(74, 13);
            this.lblFoneFixo.TabIndex = 5;
            this.lblFoneFixo.Text = "Telefone Fixo:";
            // 
            // lblFoneMovel1
            // 
            this.lblFoneMovel1.AutoSize = true;
            this.lblFoneMovel1.Location = new System.Drawing.Point(21, 192);
            this.lblFoneMovel1.Name = "lblFoneMovel1";
            this.lblFoneMovel1.Size = new System.Drawing.Size(99, 13);
            this.lblFoneMovel1.TabIndex = 4;
            this.lblFoneMovel1.Text = "Telefone Móvel (1):";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 339);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail do Fornecedor:";
            // 
            // lblCadastrarNome
            // 
            this.lblCadastrarNome.AutoSize = true;
            this.lblCadastrarNome.Location = new System.Drawing.Point(28, 63);
            this.lblCadastrarNome.Name = "lblCadastrarNome";
            this.lblCadastrarNome.Size = new System.Drawing.Size(157, 13);
            this.lblCadastrarNome.TabIndex = 2;
            this.lblCadastrarNome.Text = "Nome Completo do Fornecedor:";
            // 
            // bntSalvarFornecedor
            // 
            this.bntSalvarFornecedor.Location = new System.Drawing.Point(495, 437);
            this.bntSalvarFornecedor.Name = "bntSalvarFornecedor";
            this.bntSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarFornecedor.TabIndex = 1;
            this.bntSalvarFornecedor.Text = "Salvar";
            this.bntSalvarFornecedor.UseVisualStyleBackColor = true;
            this.bntSalvarFornecedor.Click += new System.EventHandler(this.bntSalvarFornecedor_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(183, 435);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 0;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 597);
            this.Controls.Add(this.tabFornecedor);
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.tabFornecedor.ResumeLayout(false);
            this.tabProcurarFornecedor.ResumeLayout(false);
            this.tabProcurarFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.tabCadastrarFornecedor.ResumeLayout(false);
            this.tabCadastrarFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFornecedor;
        private System.Windows.Forms.TabPage tabProcurarFornecedor;
        private System.Windows.Forms.TabPage tabCadastrarFornecedor;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.TextBox txtUltimaDataDespesas;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblUltimaCompraFornecedor;
        private System.Windows.Forms.Label lblProcurarNome;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDadoEndereco;
        private System.Windows.Forms.Label lblFoneMovel2;
        private System.Windows.Forms.Label lblFoneFixo;
        private System.Windows.Forms.Label lblFoneMovel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCadastrarNome;
        private System.Windows.Forms.Button bntSalvarFornecedor;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbFoneMovel2;
        private System.Windows.Forms.MaskedTextBox mtbFoneMovel1;
        private System.Windows.Forms.MaskedTextBox mtbFoneFixo;
        private System.Windows.Forms.Label lblErroFoneMovel1;
        private System.Windows.Forms.Label lblErroNumero;
        private System.Windows.Forms.Label lblErroEndereco;
        private System.Windows.Forms.Label lblErroNomeFornecedor;
    }
}