namespace projeto_final_03
{
    partial class Principal
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
            this.bntCliente = new System.Windows.Forms.Button();
            this.bntCarro = new System.Windows.Forms.Button();
            this.bntFuncionario = new System.Windows.Forms.Button();
            this.bntVendas = new System.Windows.Forms.Button();
            this.bntFornecedor = new System.Windows.Forms.Button();
            this.bntDespesas = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.btnAgendarVisita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCliente
            // 
            this.bntCliente.Location = new System.Drawing.Point(34, 124);
            this.bntCliente.Name = "bntCliente";
            this.bntCliente.Size = new System.Drawing.Size(75, 23);
            this.bntCliente.TabIndex = 0;
            this.bntCliente.Text = "Cliente";
            this.bntCliente.UseVisualStyleBackColor = true;
            this.bntCliente.Click += new System.EventHandler(this.bntCliente_Click);
            // 
            // bntCarro
            // 
            this.bntCarro.Location = new System.Drawing.Point(245, 124);
            this.bntCarro.Name = "bntCarro";
            this.bntCarro.Size = new System.Drawing.Size(75, 23);
            this.bntCarro.TabIndex = 1;
            this.bntCarro.Text = "Carro";
            this.bntCarro.UseVisualStyleBackColor = true;
            this.bntCarro.Click += new System.EventHandler(this.bntCarro_Click);
            // 
            // bntFuncionario
            // 
            this.bntFuncionario.Location = new System.Drawing.Point(479, 124);
            this.bntFuncionario.Name = "bntFuncionario";
            this.bntFuncionario.Size = new System.Drawing.Size(75, 23);
            this.bntFuncionario.TabIndex = 2;
            this.bntFuncionario.Text = "Funcionário";
            this.bntFuncionario.UseVisualStyleBackColor = true;
            this.bntFuncionario.Click += new System.EventHandler(this.bntFuncionario_Click);
            // 
            // bntVendas
            // 
            this.bntVendas.Location = new System.Drawing.Point(138, 284);
            this.bntVendas.Name = "bntVendas";
            this.bntVendas.Size = new System.Drawing.Size(75, 23);
            this.bntVendas.TabIndex = 3;
            this.bntVendas.Text = "Vendas";
            this.bntVendas.UseVisualStyleBackColor = true;
            this.bntVendas.Click += new System.EventHandler(this.bntVendas_Click);
            // 
            // bntFornecedor
            // 
            this.bntFornecedor.Location = new System.Drawing.Point(371, 284);
            this.bntFornecedor.Name = "bntFornecedor";
            this.bntFornecedor.Size = new System.Drawing.Size(75, 23);
            this.bntFornecedor.TabIndex = 4;
            this.bntFornecedor.Text = "Fornecedor";
            this.bntFornecedor.UseVisualStyleBackColor = true;
            this.bntFornecedor.Click += new System.EventHandler(this.bntFornecedor_Click);
            // 
            // bntDespesas
            // 
            this.bntDespesas.Location = new System.Drawing.Point(603, 284);
            this.bntDespesas.Name = "bntDespesas";
            this.bntDespesas.Size = new System.Drawing.Size(75, 23);
            this.bntDespesas.TabIndex = 5;
            this.bntDespesas.Text = "Despesas";
            this.bntDespesas.UseVisualStyleBackColor = true;
            this.bntDespesas.Click += new System.EventHandler(this.bntDespesas_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(394, 458);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // btnAgendarVisita
            // 
            this.btnAgendarVisita.Location = new System.Drawing.Point(684, 124);
            this.btnAgendarVisita.Name = "btnAgendarVisita";
            this.btnAgendarVisita.Size = new System.Drawing.Size(87, 23);
            this.btnAgendarVisita.TabIndex = 7;
            this.btnAgendarVisita.Text = "Agendar Visita";
            this.btnAgendarVisita.UseVisualStyleBackColor = true;
            this.btnAgendarVisita.Click += new System.EventHandler(this.btnAgendarVisita_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 493);
            this.Controls.Add(this.btnAgendarVisita);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntDespesas);
            this.Controls.Add(this.bntFornecedor);
            this.Controls.Add(this.bntVendas);
            this.Controls.Add(this.bntFuncionario);
            this.Controls.Add(this.bntCarro);
            this.Controls.Add(this.bntCliente);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCliente;
        private System.Windows.Forms.Button bntCarro;
        private System.Windows.Forms.Button bntFuncionario;
        private System.Windows.Forms.Button bntVendas;
        private System.Windows.Forms.Button bntFornecedor;
        private System.Windows.Forms.Button bntDespesas;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button btnAgendarVisita;
    }
}