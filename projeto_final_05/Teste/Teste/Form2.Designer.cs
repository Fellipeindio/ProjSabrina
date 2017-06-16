namespace Teste
{
    partial class Form2
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
            this.lblFoi = new System.Windows.Forms.Label();
            this.bntVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFoi
            // 
            this.lblFoi.AutoSize = true;
            this.lblFoi.Location = new System.Drawing.Point(167, 156);
            this.lblFoi.Name = "lblFoi";
            this.lblFoi.Size = new System.Drawing.Size(21, 13);
            this.lblFoi.TabIndex = 0;
            this.lblFoi.Text = "Foi";
            // 
            // bntVoltar
            // 
            this.bntVoltar.Location = new System.Drawing.Point(146, 251);
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(75, 23);
            this.bntVoltar.TabIndex = 1;
            this.bntVoltar.Text = "Voltar";
            this.bntVoltar.UseVisualStyleBackColor = true;
            this.bntVoltar.Click += new System.EventHandler(this.bntVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 340);
            this.Controls.Add(this.bntVoltar);
            this.Controls.Add(this.lblFoi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoi;
        private System.Windows.Forms.Button bntVoltar;
    }
}