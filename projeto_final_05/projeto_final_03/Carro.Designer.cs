namespace projeto_final_03
{
    partial class Carro
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
            this.tabCarro = new System.Windows.Forms.TabControl();
            this.tabProcurarNome = new System.Windows.Forms.TabPage();
            this.dataGridViewCarro = new System.Windows.Forms.DataGridView();
            this.txtProcurarMarca = new System.Windows.Forms.TextBox();
            this.txtProcurarModelo = new System.Windows.Forms.TextBox();
            this.lblMarcaCarro = new System.Windows.Forms.Label();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.tabCadastrarCarro = new System.Windows.Forms.TabPage();
            this.lblErroAnoCarro = new System.Windows.Forms.Label();
            this.lblErroModeloCarro = new System.Windows.Forms.Label();
            this.lblErroMarcaCarro = new System.Windows.Forms.Label();
            this.lblErroCodigoCliente = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.bntProcurarCliente = new System.Windows.Forms.Button();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.tabCarro.SuspendLayout();
            this.tabProcurarNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).BeginInit();
            this.tabCadastrarCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCarro
            // 
            this.tabCarro.Controls.Add(this.tabProcurarNome);
            this.tabCarro.Controls.Add(this.tabCadastrarCarro);
            this.tabCarro.Location = new System.Drawing.Point(12, 75);
            this.tabCarro.Name = "tabCarro";
            this.tabCarro.SelectedIndex = 0;
            this.tabCarro.Size = new System.Drawing.Size(798, 527);
            this.tabCarro.TabIndex = 0;
            // 
            // tabProcurarNome
            // 
            this.tabProcurarNome.Controls.Add(this.dataGridViewCarro);
            this.tabProcurarNome.Controls.Add(this.txtProcurarMarca);
            this.tabProcurarNome.Controls.Add(this.txtProcurarModelo);
            this.tabProcurarNome.Controls.Add(this.lblMarcaCarro);
            this.tabProcurarNome.Controls.Add(this.lblModeloCarro);
            this.tabProcurarNome.Controls.Add(this.bntVoltar);
            this.tabProcurarNome.Location = new System.Drawing.Point(4, 22);
            this.tabProcurarNome.Name = "tabProcurarNome";
            this.tabProcurarNome.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcurarNome.Size = new System.Drawing.Size(790, 501);
            this.tabProcurarNome.TabIndex = 0;
            this.tabProcurarNome.Text = "Procurar Carro";
            this.tabProcurarNome.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCarro
            // 
            this.dataGridViewCarro.AllowUserToAddRows = false;
            this.dataGridViewCarro.AllowUserToDeleteRows = false;
            this.dataGridViewCarro.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarro.Location = new System.Drawing.Point(21, 91);
            this.dataGridViewCarro.Name = "dataGridViewCarro";
            this.dataGridViewCarro.ReadOnly = true;
            this.dataGridViewCarro.Size = new System.Drawing.Size(751, 343);
            this.dataGridViewCarro.TabIndex = 5;
            // 
            // txtProcurarMarca
            // 
            this.txtProcurarMarca.Location = new System.Drawing.Point(510, 36);
            this.txtProcurarMarca.Name = "txtProcurarMarca";
            this.txtProcurarMarca.Size = new System.Drawing.Size(262, 20);
            this.txtProcurarMarca.TabIndex = 4;
            // 
            // txtProcurarModelo
            // 
            this.txtProcurarModelo.Location = new System.Drawing.Point(130, 36);
            this.txtProcurarModelo.Name = "txtProcurarModelo";
            this.txtProcurarModelo.Size = new System.Drawing.Size(246, 20);
            this.txtProcurarModelo.TabIndex = 3;
            // 
            // lblMarcaCarro
            // 
            this.lblMarcaCarro.AutoSize = true;
            this.lblMarcaCarro.Location = new System.Drawing.Point(403, 39);
            this.lblMarcaCarro.Name = "lblMarcaCarro";
            this.lblMarcaCarro.Size = new System.Drawing.Size(101, 13);
            this.lblMarcaCarro.TabIndex = 2;
            this.lblMarcaCarro.Text = "Procurar por Marca:";
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Location = new System.Drawing.Point(18, 36);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(106, 13);
            this.lblModeloCarro.TabIndex = 1;
            this.lblModeloCarro.Text = "Procurar por Modelo:";
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(344, 468);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntVoltar.TabIndex = 0;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // tabCadastrarCarro
            // 
            this.tabCadastrarCarro.Controls.Add(this.lblErroAnoCarro);
            this.tabCadastrarCarro.Controls.Add(this.lblErroModeloCarro);
            this.tabCadastrarCarro.Controls.Add(this.lblErroMarcaCarro);
            this.tabCadastrarCarro.Controls.Add(this.lblErroCodigoCliente);
            this.tabCadastrarCarro.Controls.Add(this.txtAno);
            this.tabCadastrarCarro.Controls.Add(this.txtModelo);
            this.tabCadastrarCarro.Controls.Add(this.txtMarca);
            this.tabCadastrarCarro.Controls.Add(this.txtCodigoCliente);
            this.tabCadastrarCarro.Controls.Add(this.bntProcurarCliente);
            this.tabCadastrarCarro.Controls.Add(this.lblAno);
            this.tabCadastrarCarro.Controls.Add(this.lblModelo);
            this.tabCadastrarCarro.Controls.Add(this.lblMarca);
            this.tabCadastrarCarro.Controls.Add(this.lblCodigoCliente);
            this.tabCadastrarCarro.Controls.Add(this.bntSalvar);
            this.tabCadastrarCarro.Controls.Add(this.bntCancelar);
            this.tabCadastrarCarro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarCarro.Name = "tabCadastrarCarro";
            this.tabCadastrarCarro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarCarro.Size = new System.Drawing.Size(790, 501);
            this.tabCadastrarCarro.TabIndex = 1;
            this.tabCadastrarCarro.Text = "Cadastrar Carro";
            this.tabCadastrarCarro.UseVisualStyleBackColor = true;
            // 
            // lblErroAnoCarro
            // 
            this.lblErroAnoCarro.AutoSize = true;
            this.lblErroAnoCarro.ForeColor = System.Drawing.Color.Red;
            this.lblErroAnoCarro.Location = new System.Drawing.Point(575, 232);
            this.lblErroAnoCarro.Name = "lblErroAnoCarro";
            this.lblErroAnoCarro.Size = new System.Drawing.Size(0, 13);
            this.lblErroAnoCarro.TabIndex = 16;
            // 
            // lblErroModeloCarro
            // 
            this.lblErroModeloCarro.AutoSize = true;
            this.lblErroModeloCarro.ForeColor = System.Drawing.Color.Red;
            this.lblErroModeloCarro.Location = new System.Drawing.Point(182, 347);
            this.lblErroModeloCarro.Name = "lblErroModeloCarro";
            this.lblErroModeloCarro.Size = new System.Drawing.Size(0, 13);
            this.lblErroModeloCarro.TabIndex = 15;
            // 
            // lblErroMarcaCarro
            // 
            this.lblErroMarcaCarro.AutoSize = true;
            this.lblErroMarcaCarro.ForeColor = System.Drawing.Color.Red;
            this.lblErroMarcaCarro.Location = new System.Drawing.Point(182, 228);
            this.lblErroMarcaCarro.Name = "lblErroMarcaCarro";
            this.lblErroMarcaCarro.Size = new System.Drawing.Size(0, 13);
            this.lblErroMarcaCarro.TabIndex = 14;
            // 
            // lblErroCodigoCliente
            // 
            this.lblErroCodigoCliente.AutoSize = true;
            this.lblErroCodigoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoCliente.Location = new System.Drawing.Point(191, 118);
            this.lblErroCodigoCliente.Name = "lblErroCodigoCliente";
            this.lblErroCodigoCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoCliente.TabIndex = 13;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(578, 198);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 12;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(185, 315);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(243, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(185, 201);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(243, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(185, 84);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 9;
            // 
            // bntProcurarCliente
            // 
            this.bntProcurarCliente.Location = new System.Drawing.Point(291, 81);
            this.bntProcurarCliente.Name = "bntProcurarCliente";
            this.bntProcurarCliente.Size = new System.Drawing.Size(99, 23);
            this.bntProcurarCliente.TabIndex = 8;
            this.bntProcurarCliente.Text = "Procurar Código";
            this.bntProcurarCliente.UseVisualStyleBackColor = true;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(500, 201);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(72, 13);
            this.lblAno.TabIndex = 5;
            this.lblAno.Text = "Ano do Carro:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(88, 315);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(88, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo do Carro:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(93, 201);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(83, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca do Carro:";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(83, 87);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoCliente.TabIndex = 2;
            this.lblCodigoCliente.Text = "Código do Cliente:";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(466, 457);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 1;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(210, 457);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 0;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 614);
            this.Controls.Add(this.tabCarro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.tabCarro.ResumeLayout(false);
            this.tabProcurarNome.ResumeLayout(false);
            this.tabProcurarNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarro)).EndInit();
            this.tabCadastrarCarro.ResumeLayout(false);
            this.tabCadastrarCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCarro;
        private System.Windows.Forms.TabPage tabProcurarNome;
        private System.Windows.Forms.DataGridView dataGridViewCarro;
        private System.Windows.Forms.TextBox txtProcurarMarca;
        private System.Windows.Forms.TextBox txtProcurarModelo;
        private System.Windows.Forms.Label lblMarcaCarro;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.Button bntVoltar;
        private System.Windows.Forms.TabPage tabCadastrarCarro;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Button bntProcurarCliente;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label lblErroAnoCarro;
        private System.Windows.Forms.Label lblErroModeloCarro;
        private System.Windows.Forms.Label lblErroMarcaCarro;
        private System.Windows.Forms.Label lblErroCodigoCliente;
    }
}