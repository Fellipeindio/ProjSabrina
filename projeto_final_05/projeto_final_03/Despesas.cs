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
    public partial class Despesas : Form{
        public Despesas(){
            InitializeComponent();
            preencherGridViewDespesas();
            preencherGridViewCompra();
        }

        public void preencherGridViewDespesas() {
            DespesasBusiness _despesas = new DespesasBusiness();
            dataGridViewDespesas.DataSource = _despesas.buscarTodasDespesas();
        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntSalvarDespesas_Click(object sender, EventArgs e){

            bool verificar = false;

            if(String.IsNullOrEmpty(txtNomeGasto.Text)){
                lblErroNomeGasto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(txtPrecoGasto.Text)){
                lblErroPrecoGasto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(mcdDespesas.Text)){
                lblErroDataPagamentoGasto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(!verificar){
                DespesasDTO _dto = new DespesasDTO();

                //_dto.codigo = 
                _dto.nome = txtNomeGasto.Text;
                _dto.preco = float.Parse(txtPrecoGasto.Text);
                _dto.descricao = txtDescricaoGasto.Text;
                _dto.dataPagamento = mcdDespesas.Text;

                DespesasBusiness _business = new DespesasBusiness();

                if (_business.insertDespesa(_dto)) {
                    clear();
                    MessageBox.Show("Agendamento Inserido Com Sucesso!", "Novo Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridViewDespesas();
                }else {
                    MessageBox.Show("Não foi Possível Inserir o Novo Agendamento!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void clear() {
            txtNomeGasto.Clear();
            txtPrecoGasto.Clear();
            txtDescricaoGasto.Clear();
        }

        
//****************************************************************************************************************

        public void preencherGridViewCompra(){
            DespesasBusiness _compra = new DespesasBusiness();
            dataGridViewCompraPeca.DataSource = _compra.buscarTodasCompras();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntSalvarCompra_Click(object sender, EventArgs e){

            bool verificar = false;

            // Validação para não digitar nada em 'Procurar Código Produto'
            if(!cbProduto.Checked && String.IsNullOrEmpty(txtProcurarProduto.Text)){ 
                lblErroCodigoProduto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(txtProcurarFornecedor.Text)){
                lblErroCodigoFornecedor.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtNomeProduto.Text)){
                lblErroNomeProduto.Text = "* Campo Obrigatório.";
                verificar = true;
            }
        
            if(String.IsNullOrEmpty(txtQtdeComprada.Text)){
                lblErroQtdeComprada.Text = "* Campo Obrigatório.";
                verificar = true;
            }
        
            if(String.IsNullOrEmpty(txtPrecoPorPeca.Text)){
                lblErroPrecoPorPeca.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if(String.IsNullOrEmpty(txtPrecoTotalCompra.Text)){
                lblErroPrecoTotalCompra.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtPrecoVendaProduto.Text)){
                lblErroPrecoVendaProduto.Text = "* Campo Obrigatório.";
                verificar = true; 
            }

            if(!verificar){
                DespesasDTO _dto = new DespesasDTO();

                //_dto.codigo = 
                _dto.nomeProduto = txtNomeProduto.Text;
                _dto.qtdeComprada = int.Parse(txtQtdeComprada.Text);
                _dto.precoPorPeca = int.Parse(txtPrecoPorPeca.Text);
                _dto.precoTotalCompra = float.Parse(txtPrecoTotalCompra.Text);
                _dto.precoDeVenda = float.Parse(txtPrecoVendaProduto.Text);

                DespesasBusiness _business = new DespesasBusiness();

                if (_business.insertDespesa(_dto)){
                    clear();
                    MessageBox.Show("Agendamento Inserido Com Sucesso!", "Novo Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridViewDespesas();
                }else{
                    MessageBox.Show("Não foi Possível Inserir o Novo Agendamento!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProduto_CheckedChanged(object sender, EventArgs e){ // Gambiarra

            if (cbProduto.Checked){
                txtProcurarProduto.ForeColor = Color.Gray;
                txtProcurarProduto.BackColor = Color.Gray;
                bntProcuraProduto.Hide();
            }else{
                txtProcurarProduto.BackColor = Color.White;
                txtProcurarProduto.ForeColor = Color.Black;
                txtProcurarProduto.Clear();
                bntProcuraProduto.Show();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntVoltar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntCancelar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntCompraVoltar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntCancelarCompra_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }
    }
}
