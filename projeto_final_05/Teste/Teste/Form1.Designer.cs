namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bntIR = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblSempreMostrar = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.checkBoxNao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // bntIR
            // 
            this.bntIR.Location = new System.Drawing.Point(193, 180);
            this.bntIR.Name = "bntIR";
            this.bntIR.Size = new System.Drawing.Size(75, 23);
            this.bntIR.TabIndex = 2;
            this.bntIR.Text = "IR";
            this.bntIR.UseVisualStyleBackColor = true;
            this.bntIR.Click += new System.EventHandler(this.bntIR_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(126, 48);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(38, 13);
            this.lblMostrar.TabIndex = 3;
            this.lblMostrar.Text = "label 1";
            // 
            // lblSempreMostrar
            // 
            this.lblSempreMostrar.AutoSize = true;
            this.lblSempreMostrar.Location = new System.Drawing.Point(190, 260);
            this.lblSempreMostrar.Name = "lblSempreMostrar";
            this.lblSempreMostrar.Size = new System.Drawing.Size(38, 13);
            this.lblSempreMostrar.TabIndex = 4;
            this.lblSempreMostrar.Text = "label 2";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // checkBoxNao
            // 
            this.checkBoxNao.AutoSize = true;
            this.checkBoxNao.Location = new System.Drawing.Point(238, 48);
            this.checkBoxNao.Name = "checkBoxNao";
            this.checkBoxNao.Size = new System.Drawing.Size(46, 17);
            this.checkBoxNao.TabIndex = 6;
            this.checkBoxNao.Text = "Não";
            this.checkBoxNao.UseVisualStyleBackColor = true;
            this.checkBoxNao.CheckedChanged += new System.EventHandler(this.checkBoxNao_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 309);
            this.Controls.Add(this.checkBoxNao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSempreMostrar);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.bntIR);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntIR;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblSempreMostrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox checkBoxNao;
    }
}

