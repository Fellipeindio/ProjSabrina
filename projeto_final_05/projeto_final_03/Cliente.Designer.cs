namespace projeto_final_03
{
    partial class Cliente
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
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabProcurarCliente = new System.Windows.Forms.TabPage();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.txtProcurarCodigo = new System.Windows.Forms.TextBox();
            this.txtProcurarNome = new System.Windows.Forms.TextBox();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.lblProcurarCodigo = new System.Windows.Forms.Label();
            this.lblProcurarNome = new System.Windows.Forms.Label();
            this.tabCadastrarCliente = new System.Windows.Forms.TabPage();
            this.lblErroNumero = new System.Windows.Forms.Label();
            this.lblErroEndereco = new System.Windows.Forms.Label();
            this.lblErroFoneMovel1 = new System.Windows.Forms.Label();
            this.lblErroNomeCompleto = new System.Windows.Forms.Label();
            this.mtbFoneMovel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbFoneMovel1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbFoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.lblFoneMovel2 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDadoEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFoneMovel1 = new System.Windows.Forms.Label();
            this.lblFoneFixo = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.tabCliente.SuspendLayout();
            this.tabProcurarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.tabCadastrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabProcurarCliente);
            this.tabCliente.Controls.Add(this.tabCadastrarCliente);
            this.tabCliente.Location = new System.Drawing.Point(12, 75);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(797, 527);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Tag = "";
            // 
            // tabProcurarCliente
            // 
            this.tabProcurarCliente.Controls.Add(this.bntVoltar);
            this.tabProcurarCliente.Controls.Add(this.txtProcurarCodigo);
            this.tabProcurarCliente.Controls.Add(this.txtProcurarNome);
            this.tabProcurarCliente.Controls.Add(this.dataGridViewCliente);
            this.tabProcurarCliente.Controls.Add(this.lblProcurarCodigo);
            this.tabProcurarCliente.Controls.Add(this.lblProcurarNome);
            this.tabProcurarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarCliente.Name = "tabProcurarCliente";
            this.tabProcurarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcurarCliente.Size = new System.Drawing.Size(789, 501);
            this.tabProcurarCliente.TabIndex = 0;
            this.tabProcurarCliente.Text = "Procurar Cliente";
            this.tabProcurarCliente.UseVisualStyleBackColor = true;
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(345, 463);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntVoltar.TabIndex = 2;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // txtProcurarCodigo
            // 
            this.txtProcurarCodigo.Location = new System.Drawing.Point(637, 37);
            this.txtProcurarCodigo.Name = "txtProcurarCodigo";
            this.txtProcurarCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarCodigo.TabIndex = 6;
            // 
            // txtProcurarNome
            // 
            this.txtProcurarNome.Location = new System.Drawing.Point(106, 37);
            this.txtProcurarNome.Name = "txtProcurarNome";
            this.txtProcurarNome.Size = new System.Drawing.Size(397, 20);
            this.txtProcurarNome.TabIndex = 5;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 92);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.Size = new System.Drawing.Size(777, 348);
            this.dataGridViewCliente.TabIndex = 4;
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            // 
            // lblProcurarCodigo
            // 
            this.lblProcurarCodigo.AutoSize = true;
            this.lblProcurarCodigo.Location = new System.Drawing.Point(527, 37);
            this.lblProcurarCodigo.Name = "lblProcurarCodigo";
            this.lblProcurarCodigo.Size = new System.Drawing.Size(104, 13);
            this.lblProcurarCodigo.TabIndex = 3;
            this.lblProcurarCodigo.Text = "Procurar por Código:";
            // 
            // lblProcurarNome
            // 
            this.lblProcurarNome.AutoSize = true;
            this.lblProcurarNome.Location = new System.Drawing.Point(6, 40);
            this.lblProcurarNome.Name = "lblProcurarNome";
            this.lblProcurarNome.Size = new System.Drawing.Size(99, 13);
            this.lblProcurarNome.TabIndex = 2;
            this.lblProcurarNome.Text = "Procurar por Nome:";
            // 
            // tabCadastrarCliente
            // 
            this.tabCadastrarCliente.Controls.Add(this.lblErroNumero);
            this.tabCadastrarCliente.Controls.Add(this.lblErroEndereco);
            this.tabCadastrarCliente.Controls.Add(this.lblErroFoneMovel1);
            this.tabCadastrarCliente.Controls.Add(this.lblErroNomeCompleto);
            this.tabCadastrarCliente.Controls.Add(this.mtbFoneMovel2);
            this.tabCadastrarCliente.Controls.Add(this.mtbFoneMovel1);
            this.tabCadastrarCliente.Controls.Add(this.mtbFoneFixo);
            this.tabCadastrarCliente.Controls.Add(this.lblFoneMovel2);
            this.tabCadastrarCliente.Controls.Add(this.txtComplemento);
            this.tabCadastrarCliente.Controls.Add(this.txtNumero);
            this.tabCadastrarCliente.Controls.Add(this.txtEndereco);
            this.tabCadastrarCliente.Controls.Add(this.txtEmail);
            this.tabCadastrarCliente.Controls.Add(this.txtNomeCompleto);
            this.tabCadastrarCliente.Controls.Add(this.lblComplemento);
            this.tabCadastrarCliente.Controls.Add(this.lblNumero);
            this.tabCadastrarCliente.Controls.Add(this.lblEndereco);
            this.tabCadastrarCliente.Controls.Add(this.lblDadoEndereco);
            this.tabCadastrarCliente.Controls.Add(this.lblEmail);
            this.tabCadastrarCliente.Controls.Add(this.lblFoneMovel1);
            this.tabCadastrarCliente.Controls.Add(this.lblFoneFixo);
            this.tabCadastrarCliente.Controls.Add(this.lblNomeCompleto);
            this.tabCadastrarCliente.Controls.Add(this.bntSalvar);
            this.tabCadastrarCliente.Controls.Add(this.bntCancelar);
            this.tabCadastrarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarCliente.Name = "tabCadastrarCliente";
            this.tabCadastrarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarCliente.Size = new System.Drawing.Size(789, 501);
            this.tabCadastrarCliente.TabIndex = 1;
            this.tabCadastrarCliente.Text = "Cadastrar Cliente";
            this.tabCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // lblErroNumero
            // 
            this.lblErroNumero.AutoSize = true;
            this.lblErroNumero.ForeColor = System.Drawing.Color.Red;
            this.lblErroNumero.Location = new System.Drawing.Point(527, 224);
            this.lblErroNumero.Name = "lblErroNumero";
            this.lblErroNumero.Size = new System.Drawing.Size(0, 13);
            this.lblErroNumero.TabIndex = 24;
            // 
            // lblErroEndereco
            // 
            this.lblErroEndereco.AutoSize = true;
            this.lblErroEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblErroEndereco.Location = new System.Drawing.Point(665, 152);
            this.lblErroEndereco.Name = "lblErroEndereco";
            this.lblErroEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblErroEndereco.TabIndex = 23;
            // 
            // lblErroFoneMovel1
            // 
            this.lblErroFoneMovel1.AutoSize = true;
            this.lblErroFoneMovel1.ForeColor = System.Drawing.Color.Red;
            this.lblErroFoneMovel1.Location = new System.Drawing.Point(242, 207);
            this.lblErroFoneMovel1.Name = "lblErroFoneMovel1";
            this.lblErroFoneMovel1.Size = new System.Drawing.Size(0, 13);
            this.lblErroFoneMovel1.TabIndex = 22;
            // 
            // lblErroNomeCompleto
            // 
            this.lblErroNomeCompleto.AutoSize = true;
            this.lblErroNomeCompleto.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeCompleto.Location = new System.Drawing.Point(451, 60);
            this.lblErroNomeCompleto.Name = "lblErroNomeCompleto";
            this.lblErroNomeCompleto.Size = new System.Drawing.Size(0, 13);
            this.lblErroNomeCompleto.TabIndex = 21;
            // 
            // mtbFoneMovel2
            // 
            this.mtbFoneMovel2.Location = new System.Drawing.Point(136, 283);
            this.mtbFoneMovel2.Mask = "(00) 00000-0000";
            this.mtbFoneMovel2.Name = "mtbFoneMovel2";
            this.mtbFoneMovel2.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneMovel2.TabIndex = 20;
            // 
            // mtbFoneMovel1
            // 
            this.mtbFoneMovel1.Location = new System.Drawing.Point(136, 204);
            this.mtbFoneMovel1.Mask = "(00) 00000-0000";
            this.mtbFoneMovel1.Name = "mtbFoneMovel1";
            this.mtbFoneMovel1.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneMovel1.TabIndex = 19;
            // 
            // mtbFoneFixo
            // 
            this.mtbFoneFixo.Location = new System.Drawing.Point(136, 123);
            this.mtbFoneFixo.Mask = "(00) 00000-0000";
            this.mtbFoneFixo.Name = "mtbFoneFixo";
            this.mtbFoneFixo.Size = new System.Drawing.Size(100, 20);
            this.mtbFoneFixo.TabIndex = 18;
            // 
            // lblFoneMovel2
            // 
            this.lblFoneMovel2.AutoSize = true;
            this.lblFoneMovel2.Location = new System.Drawing.Point(31, 286);
            this.lblFoneMovel2.Name = "lblFoneMovel2";
            this.lblFoneMovel2.Size = new System.Drawing.Size(99, 13);
            this.lblFoneMovel2.TabIndex = 17;
            this.lblFoneMovel2.Text = "Telefone Móvel (2):";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(421, 296);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(263, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(421, 221);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(421, 149);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(238, 20);
            this.txtEndereco.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 369);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(136, 57);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(309, 20);
            this.txtNomeCompleto.TabIndex = 10;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(341, 296);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 9;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(368, 224);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Número:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(359, 149);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDadoEndereco
            // 
            this.lblDadoEndereco.AutoSize = true;
            this.lblDadoEndereco.Location = new System.Drawing.Point(467, 111);
            this.lblDadoEndereco.Name = "lblDadoEndereco";
            this.lblDadoEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblDadoEndereco.TabIndex = 6;
            this.lblDadoEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(92, 372);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblFoneMovel1
            // 
            this.lblFoneMovel1.AutoSize = true;
            this.lblFoneMovel1.Location = new System.Drawing.Point(31, 211);
            this.lblFoneMovel1.Name = "lblFoneMovel1";
            this.lblFoneMovel1.Size = new System.Drawing.Size(99, 13);
            this.lblFoneMovel1.TabIndex = 4;
            this.lblFoneMovel1.Text = "Telefone Móvel (1):";
            // 
            // lblFoneFixo
            // 
            this.lblFoneFixo.AutoSize = true;
            this.lblFoneFixo.Location = new System.Drawing.Point(56, 126);
            this.lblFoneFixo.Name = "lblFoneFixo";
            this.lblFoneFixo.Size = new System.Drawing.Size(74, 13);
            this.lblFoneFixo.TabIndex = 3;
            this.lblFoneFixo.Text = "Telefone Fixo:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(45, 60);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompleto.TabIndex = 2;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(470, 468);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 1;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(191, 468);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 0;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 614);
            this.Controls.Add(this.tabCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.tabCliente.ResumeLayout(false);
            this.tabProcurarCliente.ResumeLayout(false);
            this.tabProcurarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.tabCadastrarCliente.ResumeLayout(false);
            this.tabCadastrarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabProcurarCliente;
        private System.Windows.Forms.TabPage tabCadastrarCliente;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.TextBox txtProcurarCodigo;
        private System.Windows.Forms.TextBox txtProcurarNome;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label lblProcurarCodigo;
        private System.Windows.Forms.Label lblProcurarNome;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDadoEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFoneMovel1;
        private System.Windows.Forms.Label lblFoneFixo;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label lblFoneMovel2;
        private System.Windows.Forms.MaskedTextBox mtbFoneMovel2;
        private System.Windows.Forms.MaskedTextBox mtbFoneMovel1;
        private System.Windows.Forms.MaskedTextBox mtbFoneFixo;
        private System.Windows.Forms.Label lblErroNumero;
        private System.Windows.Forms.Label lblErroEndereco;
        private System.Windows.Forms.Label lblErroFoneMovel1;
        private System.Windows.Forms.Label lblErroNomeCompleto;
    }
}