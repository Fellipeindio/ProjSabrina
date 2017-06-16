using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        private void checkBoxNao_CheckedChanged(object sender, EventArgs e){
            if (checkBoxNao.Checked){
                //*************************************************************************
                bntIR.Hide();
                //*************************************************************************
                lblSempreMostrar.Text = "Foi";
                lblMostrar.Text = Convert.ToString(checkBoxNao.Checked);
                txtNome.ForeColor = Color.Gray;// Mudar a cor da letra dentro da TextBox
                txtNome.BackColor = Color.Gray;  // Mudar o funco do TextBox
                //txtNome.Cursor = Cursors.Hand; // Mudar para a mãozinha do mouse
                txtNome.Invalidate();
            }else{
                //*************************************************************************
                bntIR.Show();
                //*************************************************************************
                lblSempreMostrar.Text = "Não";
                lblMostrar.Text = Convert.ToString(checkBoxNao.Checked);
                txtNome.BackColor = Color.White;
                txtNome.ForeColor = Color.Black;
                txtNome.Clear();
            }
        }
//***********************************************************************************************************
        private void bntIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 _form2 = new Form2();
            _form2.Show();
            
        }
        
    }
}
