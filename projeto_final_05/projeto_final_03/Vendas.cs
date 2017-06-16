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
    public partial class Vendas : Form{
        public Vendas(){
            InitializeComponent();
            preencherGridView();
        }

        public void preencherGridView(){
            VendaBusiness _venda = new VendaBusiness();
            dataGridViewVenda.DataSource = _venda.buscarTodasVendas();
        }


/*****************************************************************************************************************/

        private void bntSalvar_Click(object sender, EventArgs e){

            bool verificar = false;

            if (String.IsNullOrEmpty(rdProduto.Text) || String.IsNullOrEmpty(rdServico.Text)){
                lblErroServProd.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtCodigoFuncionario.Text)){
                lblErroCodigoFuncionario.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtCodigo.Text)){
                lblErroCodigoProduto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtQtdeVendida.Text)){
                lblErroQtdeVendida.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtPrecoTotal.Text)){
                lblErroPrecoTotal.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(cbFormaPaga.Text)){
                lblErroFormaPagar.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcdVenda.Text)){
                lblErroDataVenda.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (!verificar){
                VendaDTO _dto = new VendaDTO();

                if (String.IsNullOrEmpty(rdProduto.Text))
                    _dto.tipoVenda = rdServico.Text;
                _dto.tipoVenda = rdProduto.Text;

                _dto.qtdeVendida = int.Parse(txtQtdeVendida.Text);
                _dto.codFuncionario = int.Parse(txtCodigoFuncionario.Text);
                _dto.precoTotal = float.Parse(txtPrecoTotal.Text);
                _dto.formaPagamento = cbFormaPaga.Text;
                _dto.observacao = txtObservacao.Text;
                _dto.dataVenda = Convert.ToString(mcdVenda);

                VendaBusiness _business = new VendaBusiness();

                if (_business.insertVenda(_dto)){

                    clearVenda();
                    MessageBox.Show("Venda Inserida Com Sucesso!", "Nova Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridView();
                }else{

                    MessageBox.Show("Não foi Possível Inserir a Nova Venda!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bntVoltar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void bntCancelar_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void clearVenda() {
        
        
        
        }


    }
}
