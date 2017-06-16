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
    public partial class Carro : Form{
        public Carro(){
            InitializeComponent();
            preencherGridView();
        }

        public void preencherGridView() {
            CarroBusiness _carro = new CarroBusiness();
            dataGridViewCarro.DataSource = _carro.buscarTodosCarros();
        }

        private void bntSalvar_Click(object sender, EventArgs e){
         
            bool verificar = false;

            if (String.IsNullOrEmpty(txtCodigoCliente.Text)){
                lblErroCodigoCliente.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtModelo.Text)){
                lblErroModeloCarro.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtMarca.Text)){
                lblErroMarcaCarro.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtAno.Text)){
                lblErroAnoCarro.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (verificar == false){
                CarroDTO _dto = new CarroDTO();

                _dto.codCliente = int.Parse(txtCodigoCliente.Text);
                _dto.marca = txtMarca.Text;
                _dto.modelo = txtModelo.Text;
                _dto.ano = int.Parse(txtAno.Text);

                CarroBusiness _business = new CarroBusiness();

                if (_business.insertCarro(_dto)){
                    clear();
                    MessageBox.Show("Carro Inserido Com Sucesso!", "Novo Carro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridView();
                }else{
                    MessageBox.Show("Não foi Possível Inserir o Novo Carro!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clear(){
            txtCodigoCliente.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();

        }
    }
}
