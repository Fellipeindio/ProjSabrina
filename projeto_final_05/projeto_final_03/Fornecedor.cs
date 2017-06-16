using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using com.ucb.Business;
using com.ucb.DataTransferObject;

namespace projeto_final_03{
    public partial class Fornecedor : Form{
        public Fornecedor(){
            InitializeComponent(); 
            preencherGridView();
        }

        public void preencherGridView() {
            FornecedorBusiness _fornecedor = new FornecedorBusiness();
            dataGridViewFornecedor.DataSource = _fornecedor.buscarTodosFornecedores();
        }

      private void bntSalvarFornecedor_Click(object sender, EventArgs e){

            bool verificar = false;

            if(String.IsNullOrEmpty(txtNome.Text)){
                lblErroNomeFornecedor.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (!mtbFoneMovel1.MaskCompleted){
                lblErroFoneMovel1.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(txtEndereco.Text)){
                lblErroEndereco.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(txtNumero.Text)){
                lblErroNumero.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(!verificar){
                FornecedorDTO _dto = new FornecedorDTO();

                _dto.nome = txtNome.Text;
                _dto.foneFixo = mtbFoneFixo.Text;
                _dto.foneMovel1 = mtbFoneMovel1.Text;
                _dto.foneMovel2 = mtbFoneMovel2.Text;
                _dto.email = txtEmail.Text;

                FornecedorBusiness _business = new FornecedorBusiness();
                if (_business.insertFornecedor(_dto)){
                    clear();
                    MessageBox.Show("Fornecedor Inserido Com Sucesso!", "Novo Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridView();
                }else{
                    MessageBox.Show("Não foi Possível Inserir o Novo Fornecedir!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        private void bntCancelar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void bntVoltar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void clear() {
            txtNome.Clear();
            mtbFoneFixo.Clear();
            mtbFoneMovel1.Clear();
            mtbFoneMovel2.Clear();
            txtEmail.Clear();
        
        }

    }
}
