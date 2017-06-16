using com.ucb.Business;
using com.ucb.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_final_03{
    public partial class AgendarVisita : Form{
        public AgendarVisita(){
            InitializeComponent();
            preencherGridView();
        }

        public void preencherGridView(){
            AgendarVisitaBusiness _carro = new AgendarVisitaBusiness();
            dataGridViewAgendarVisita.DataSource = _carro.buscarTodosAgendarVisita();
        }

        private void bntVoltarProcura_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void bntCancelarVisita_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        private void bntSalvarVisita_Click(object sender, EventArgs e){

            bool verificar = false;

            if (String.IsNullOrEmpty(txtCodigoCliente.Text)){
                lblErroCodigoCliente.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtCodigoFuncionario.Text)){
                lblErroCodigoFuncionario.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcDiaAgendado.Text)){
                lblErroDiaAgendado.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcDiaAgendamento.Text)){
                lblErroDiaAgendamento.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtTipoServico.Text)){
                lblErroTipoServico.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (verificar == false){
                AgendarVisitaDTO _dto = new AgendarVisitaDTO();

                _dto.codCliente = int.Parse(txtCodigoCliente.Text);
                _dto.codFuncionario = int.Parse(txtCodigoFuncionario.Text);
                _dto.tipoServico = txtTipoServico.Text;
                _dto.diAgendado = mcDiaAgendado.Text;
                _dto.diaAgendamento = mcDiaAgendamento.Text;

                AgendarVisitaBusiness _business = new AgendarVisitaBusiness();

                if (_business.insertAgendarVisita(_dto)){
                    clear();
                    MessageBox.Show("Agendamento Inserido Com Sucesso!", "Novo Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridView();
                }else{
                    MessageBox.Show("Não foi Possível Inserir o Novo Agendamento!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clear(){
            txtCodigoCliente.Clear();
            txtCodigoFuncionario.Clear();
            txtTipoServico.Clear();

        }
    }
}
