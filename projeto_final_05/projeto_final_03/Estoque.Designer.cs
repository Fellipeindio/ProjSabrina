namespace projeto_final_03
{
    partial class Estoque
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
            this.lblProcurarNomeProduto = new System.Windows.Forms.Label();
            this.lblProcurarCodigoProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.bntVoltarEstoque = new System.Windows.Forms.Button();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcurarNomeProduto
            // 
            this.lblProcurarNomeProduto.AutoSize = true;
            this.lblProcurarNomeProduto.Location = new System.Drawing.Point(12, 64);
            this.lblProcurarNomeProduto.Name = "lblProcurarNomeProduto";
            this.lblProcurarNomeProduto.Size = new System.Drawing.Size(155, 13);
            this.lblProcurarNomeProduto.TabIndex = 0;
            this.lblProcurarNomeProduto.Text = "Procurar Por Nome do Produto:";
            // 
            // lblProcurarCodigoProduto
            // 
            this.lblProcurarCodigoProduto.AutoSize = true;
            this.lblProcurarCodigoProduto.Location = new System.Drawing.Point(578, 64);
            this.lblProcurarCodigoProduto.Name = "lblProcurarCodigoProduto";
            this.lblProcurarCodigoProduto.Size = new System.Drawing.Size(105, 13);
            this.lblProcurarCodigoProduto.TabIndex = 1;
            this.lblProcurarCodigoProduto.Text = "Procurar Por Código:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(173, 61);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(384, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(689, 61);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 3;
            // 
            // bntVoltarEstoque
            // 
            this.bntVoltarEstoque.Location = new System.Drawing.Point(368, 589);
            this.bntVoltarEstoque.Name = "bntVoltarEstoque";
            this.bntVoltarEstoque.Size = new System.Drawing.Size(75, 23);
            this.bntVoltarEstoque.TabIndex = 4;
            this.bntVoltarEstoque.Text = "Voltar";
            this.bntVoltarEstoque.UseVisualStyleBackColor = true;
            this.bntVoltarEstoque.Click += new System.EventHandler(this.bntVoltarEstoque_Click);
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(797, 476);
            this.dataGridViewEstoque.TabIndex = 5;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 624);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.bntVoltarEstoque);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblProcurarCodigoProduto);
            this.Controls.Add(this.lblProcurarNomeProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcurarNomeProduto;
        private System.Windows.Forms.Label lblProcurarCodigoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button bntVoltarEstoque;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;

    }
}