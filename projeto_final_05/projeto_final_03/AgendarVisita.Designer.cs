namespace projeto_final_03
{
    partial class AgendarVisita
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
            this.tabPesquisarAgendarVisita = new System.Windows.Forms.TabPage();
            this.txtProcurarDataAgendada = new System.Windows.Forms.TextBox();
            this.txtProcurarNomeCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewAgendarVisita = new System.Windows.Forms.DataGridView();
            this.bntVoltarProcura = new System.Windows.Forms.Button();
            this.lblProcurarDataAgendada = new System.Windows.Forms.Label();
            this.lblProcurarNomeCliente = new System.Windows.Forms.Label();
            this.tabCadastrarAgendarPesquisa = new System.Windows.Forms.TabPage();
            this.lblErroDiaAgendado = new System.Windows.Forms.Label();
            this.lblErroDiaAgendamento = new System.Windows.Forms.Label();
            this.lblErroCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblErroCodigoCliente = new System.Windows.Forms.Label();
            this.mcDiaAgendado = new System.Windows.Forms.MonthCalendar();
            this.mcDiaAgendamento = new System.Windows.Forms.MonthCalendar();
            this.bntSalvarVisita = new System.Windows.Forms.Button();
            this.bntCancelarVisita = new System.Windows.Forms.Button();
            this.bntCodigoFuncionario = new System.Windows.Forms.Button();
            this.bntCodigoCliente = new System.Windows.Forms.Button();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblDiaAgendado = new System.Windows.Forms.Label();
            this.lblDiaAgendamento = new System.Windows.Forms.Label();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblErroTipoServico = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPesquisarAgendarVisita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendarVisita)).BeginInit();
            this.tabCadastrarAgendarPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisarAgendarVisita);
            this.tabControl1.Controls.Add(this.tabCadastrarAgendarPesquisa);
            this.tabControl1.Location = new System.Drawing.Point(22, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPesquisarAgendarVisita
            // 
            this.tabPesquisarAgendarVisita.Controls.Add(this.txtProcurarDataAgendada);
            this.tabPesquisarAgendarVisita.Controls.Add(this.txtProcurarNomeCliente);
            this.tabPesquisarAgendarVisita.Controls.Add(this.dataGridViewAgendarVisita);
            this.tabPesquisarAgendarVisita.Controls.Add(this.bntVoltarProcura);
            this.tabPesquisarAgendarVisita.Controls.Add(this.lblProcurarDataAgendada);
            this.tabPesquisarAgendarVisita.Controls.Add(this.lblProcurarNomeCliente);
            this.tabPesquisarAgendarVisita.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisarAgendarVisita.Name = "tabPesquisarAgendarVisita";
            this.tabPesquisarAgendarVisita.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisarAgendarVisita.Size = new System.Drawing.Size(781, 506);
            this.tabPesquisarAgendarVisita.TabIndex = 0;
            this.tabPesquisarAgendarVisita.Text = "Pesquisar Agendar de Visita";
            this.tabPesquisarAgendarVisita.UseVisualStyleBackColor = true;
            // 
            // txtProcurarDataAgendada
            // 
            this.txtProcurarDataAgendada.Location = new System.Drawing.Point(671, 48);
            this.txtProcurarDataAgendada.Name = "txtProcurarDataAgendada";
            this.txtProcurarDataAgendada.Size = new System.Drawing.Size(107, 20);
            this.txtProcurarDataAgendada.TabIndex = 5;
            // 
            // txtProcurarNomeCliente
            // 
            this.txtProcurarNomeCliente.Location = new System.Drawing.Point(167, 45);
            this.txtProcurarNomeCliente.Name = "txtProcurarNomeCliente";
            this.txtProcurarNomeCliente.Size = new System.Drawing.Size(328, 20);
            this.txtProcurarNomeCliente.TabIndex = 4;
            // 
            // dataGridViewAgendarVisita
            // 
            this.dataGridViewAgendarVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendarVisita.Location = new System.Drawing.Point(9, 90);
            this.dataGridViewAgendarVisita.Name = "dataGridViewAgendarVisita";
            this.dataGridViewAgendarVisita.Size = new System.Drawing.Size(757, 382);
            this.dataGridViewAgendarVisita.TabIndex = 3;
            // 
            // bntVoltarProcura
            // 
            this.bntVoltarProcura.Location = new System.Drawing.Point(351, 478);
            this.bntVoltarProcura.Name = "bntVoltarProcura";
            this.bntVoltarProcura.Size = new System.Drawing.Size(75, 23);
            this.bntVoltarProcura.TabIndex = 2;
            this.bntVoltarProcura.Text = "Voltar";
            this.bntVoltarProcura.UseVisualStyleBackColor = true;
            this.bntVoltarProcura.Click += new System.EventHandler(this.bntVoltarProcura_Click);
            // 
            // lblProcurarDataAgendada
            // 
            this.lblProcurarDataAgendada.AutoSize = true;
            this.lblProcurarDataAgendada.Location = new System.Drawing.Point(513, 48);
            this.lblProcurarDataAgendada.Name = "lblProcurarDataAgendada";
            this.lblProcurarDataAgendada.Size = new System.Drawing.Size(152, 13);
            this.lblProcurarDataAgendada.TabIndex = 1;
            this.lblProcurarDataAgendada.Text = "Procurar Pela Data Agendada:";
            // 
            // lblProcurarNomeCliente
            // 
            this.lblProcurarNomeCliente.AutoSize = true;
            this.lblProcurarNomeCliente.Location = new System.Drawing.Point(6, 48);
            this.lblProcurarNomeCliente.Name = "lblProcurarNomeCliente";
            this.lblProcurarNomeCliente.Size = new System.Drawing.Size(155, 13);
            this.lblProcurarNomeCliente.TabIndex = 0;
            this.lblProcurarNomeCliente.Text = "Procurar Pelo Nome do Cliente:";
            // 
            // tabCadastrarAgendarPesquisa
            // 
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblErroTipoServico);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblErroDiaAgendado);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblErroDiaAgendamento);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblErroCodigoFuncionario);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblErroCodigoCliente);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.mcDiaAgendado);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.mcDiaAgendamento);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.bntSalvarVisita);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.bntCancelarVisita);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.bntCodigoFuncionario);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.bntCodigoCliente);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.txtTipoServico);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.txtCodigoFuncionario);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.txtCodigoCliente);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblDiaAgendado);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblDiaAgendamento);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblTipoServico);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblCodigoFuncionario);
            this.tabCadastrarAgendarPesquisa.Controls.Add(this.lblCodigoCliente);
            this.tabCadastrarAgendarPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarAgendarPesquisa.Name = "tabCadastrarAgendarPesquisa";
            this.tabCadastrarAgendarPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarAgendarPesquisa.Size = new System.Drawing.Size(781, 506);
            this.tabCadastrarAgendarPesquisa.TabIndex = 1;
            this.tabCadastrarAgendarPesquisa.Text = "Agendar Visita";
            this.tabCadastrarAgendarPesquisa.UseVisualStyleBackColor = true;
            // 
            // lblErroDiaAgendado
            // 
            this.lblErroDiaAgendado.AutoSize = true;
            this.lblErroDiaAgendado.ForeColor = System.Drawing.Color.Red;
            this.lblErroDiaAgendado.Location = new System.Drawing.Point(580, 195);
            this.lblErroDiaAgendado.Name = "lblErroDiaAgendado";
            this.lblErroDiaAgendado.Size = new System.Drawing.Size(0, 13);
            this.lblErroDiaAgendado.TabIndex = 19;
            // 
            // lblErroDiaAgendamento
            // 
            this.lblErroDiaAgendamento.AutoSize = true;
            this.lblErroDiaAgendamento.ForeColor = System.Drawing.Color.Red;
            this.lblErroDiaAgendamento.Location = new System.Drawing.Point(198, 198);
            this.lblErroDiaAgendamento.Name = "lblErroDiaAgendamento";
            this.lblErroDiaAgendamento.Size = new System.Drawing.Size(0, 13);
            this.lblErroDiaAgendamento.TabIndex = 18;
            // 
            // lblErroCodigoFuncionario
            // 
            this.lblErroCodigoFuncionario.AutoSize = true;
            this.lblErroCodigoFuncionario.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoFuncionario.Location = new System.Drawing.Point(542, 75);
            this.lblErroCodigoFuncionario.Name = "lblErroCodigoFuncionario";
            this.lblErroCodigoFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoFuncionario.TabIndex = 17;
            // 
            // lblErroCodigoCliente
            // 
            this.lblErroCodigoCliente.AutoSize = true;
            this.lblErroCodigoCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErroCodigoCliente.Location = new System.Drawing.Point(98, 73);
            this.lblErroCodigoCliente.Name = "lblErroCodigoCliente";
            this.lblErroCodigoCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErroCodigoCliente.TabIndex = 16;
            // 
            // mcDiaAgendado
            // 
            this.mcDiaAgendado.Location = new System.Drawing.Point(422, 238);
            this.mcDiaAgendado.Name = "mcDiaAgendado";
            this.mcDiaAgendado.TabIndex = 15;
            // 
            // mcDiaAgendamento
            // 
            this.mcDiaAgendamento.Location = new System.Drawing.Point(20, 238);
            this.mcDiaAgendamento.Name = "mcDiaAgendamento";
            this.mcDiaAgendamento.TabIndex = 14;
            // 
            // bntSalvarVisita
            // 
            this.bntSalvarVisita.Location = new System.Drawing.Point(452, 465);
            this.bntSalvarVisita.Name = "bntSalvarVisita";
            this.bntSalvarVisita.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarVisita.TabIndex = 13;
            this.bntSalvarVisita.Text = "Salvar";
            this.bntSalvarVisita.UseVisualStyleBackColor = true;
            this.bntSalvarVisita.Click += new System.EventHandler(this.bntSalvarVisita_Click);
            // 
            // bntCancelarVisita
            // 
            this.bntCancelarVisita.Location = new System.Drawing.Point(223, 465);
            this.bntCancelarVisita.Name = "bntCancelarVisita";
            this.bntCancelarVisita.Size = new System.Drawing.Size(75, 23);
            this.bntCancelarVisita.TabIndex = 12;
            this.bntCancelarVisita.Text = "Cancelar";
            this.bntCancelarVisita.UseVisualStyleBackColor = true;
            this.bntCancelarVisita.Click += new System.EventHandler(this.bntCancelarVisita_Click);
            // 
            // bntCodigoFuncionario
            // 
            this.bntCodigoFuncionario.Location = new System.Drawing.Point(664, 50);
            this.bntCodigoFuncionario.Name = "bntCodigoFuncionario";
            this.bntCodigoFuncionario.Size = new System.Drawing.Size(93, 23);
            this.bntCodigoFuncionario.TabIndex = 11;
            this.bntCodigoFuncionario.Text = "Procurar Código";
            this.bntCodigoFuncionario.UseVisualStyleBackColor = true;
            // 
            // bntCodigoCliente
            // 
            this.bntCodigoCliente.Location = new System.Drawing.Point(223, 50);
            this.bntCodigoCliente.Name = "bntCodigoCliente";
            this.bntCodigoCliente.Size = new System.Drawing.Size(98, 23);
            this.bntCodigoCliente.TabIndex = 10;
            this.bntCodigoCliente.Text = "Procurar Código";
            this.bntCodigoCliente.UseVisualStyleBackColor = true;
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.Location = new System.Drawing.Point(156, 115);
            this.txtTipoServico.Multiline = true;
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(601, 62);
            this.txtTipoServico.TabIndex = 8;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(545, 52);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFuncionario.TabIndex = 7;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(101, 50);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 6;
            // 
            // lblDiaAgendado
            // 
            this.lblDiaAgendado.AutoSize = true;
            this.lblDiaAgendado.Location = new System.Drawing.Point(485, 195);
            this.lblDiaAgendado.Name = "lblDiaAgendado";
            this.lblDiaAgendado.Size = new System.Drawing.Size(89, 13);
            this.lblDiaAgendado.TabIndex = 5;
            this.lblDiaAgendado.Text = "DIA AGENDADO";
            // 
            // lblDiaAgendamento
            // 
            this.lblDiaAgendamento.AutoSize = true;
            this.lblDiaAgendamento.Location = new System.Drawing.Point(61, 195);
            this.lblDiaAgendamento.Name = "lblDiaAgendamento";
            this.lblDiaAgendamento.Size = new System.Drawing.Size(131, 13);
            this.lblDiaAgendamento.TabIndex = 4;
            this.lblDiaAgendamento.Text = "DIA DO AGENDAMENTO";
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(17, 118);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(137, 13);
            this.lblTipoServico.TabIndex = 2;
            this.lblTipoServico.Text = "Tipo de Serviço Agendado:";
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(353, 55);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(181, 13);
            this.lblCodigoFuncionario.TabIndex = 1;
            this.lblCodigoFuncionario.Text = "Código Funcionário (Agendou Visita):";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(17, 53);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Código Cliente:";
            // 
            // lblErroTipoServico
            // 
            this.lblErroTipoServico.AutoSize = true;
            this.lblErroTipoServico.ForeColor = System.Drawing.Color.Red;
            this.lblErroTipoServico.Location = new System.Drawing.Point(27, 143);
            this.lblErroTipoServico.Name = "lblErroTipoServico";
            this.lblErroTipoServico.Size = new System.Drawing.Size(0, 13);
            this.lblErroTipoServico.TabIndex = 20;
            // 
            // AgendarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 625);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendarVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendarVisita";
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisarAgendarVisita.ResumeLayout(false);
            this.tabPesquisarAgendarVisita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendarVisita)).EndInit();
            this.tabCadastrarAgendarPesquisa.ResumeLayout(false);
            this.tabCadastrarAgendarPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisarAgendarVisita;
        private System.Windows.Forms.TabPage tabCadastrarAgendarPesquisa;
        private System.Windows.Forms.TextBox txtProcurarDataAgendada;
        private System.Windows.Forms.TextBox txtProcurarNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewAgendarVisita;
        private System.Windows.Forms.Button bntVoltarProcura;
        private System.Windows.Forms.Label lblProcurarDataAgendada;
        private System.Windows.Forms.Label lblProcurarNomeCliente;
        private System.Windows.Forms.MonthCalendar mcDiaAgendado;
        private System.Windows.Forms.MonthCalendar mcDiaAgendamento;
        private System.Windows.Forms.Button bntSalvarVisita;
        private System.Windows.Forms.Button bntCancelarVisita;
        private System.Windows.Forms.Button bntCodigoFuncionario;
        private System.Windows.Forms.Button bntCodigoCliente;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblDiaAgendado;
        private System.Windows.Forms.Label lblDiaAgendamento;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblErroDiaAgendado;
        private System.Windows.Forms.Label lblErroDiaAgendamento;
        private System.Windows.Forms.Label lblErroCodigoFuncionario;
        private System.Windows.Forms.Label lblErroCodigoCliente;
        private System.Windows.Forms.Label lblErroTipoServico;
    }
}