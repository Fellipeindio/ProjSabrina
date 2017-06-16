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
    public partial class Funcionario : Form{
        public Funcionario(){

            InitializeComponent();
            preencherGridViewFuncionario();
        }
        public void preencherGridViewFuncionario() {

            FuncionarioBusiness _funcionario = new FuncionarioBusiness();
            dataGridViewFuncionario.DataSource = _funcionario.buscarTodosFuncionarios();
        
        }


        /// <summary>
        /// Verificar os Dados digitados em Cadastro do Funcionários e salva no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntSalvarFuncionario_Click(object sender, EventArgs e){

            bool verificar = false;

            if (String.IsNullOrEmpty(txtNomeCompleto.Text)){
                lblErroNomeCompleto.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (!mtbFoneMovel1.MaskCompleted){
                lblErroFoneMovel1.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtSalario.Text)){
                lblErroSalario.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtEndereco.Text)){
                lblErroEndereco.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtNumero.Text)){
                lblErroNumero.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcdAdmissao.Text)){
                lblErroDataAdmissao.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (!verificar){
                FuncionarioDTO _dto = new FuncionarioDTO();

                _dto.nome = txtNomeCompleto.Text;
                _dto.foneFixo = mtbFoneFixo.Text;
                _dto.foneMovel1 = mtbFoneMovel1.Text;
                _dto.foneMovel2 = mtbFoneMovel2.Text;
                _dto.email = txtEmail.Text;
                _dto.salario = float.Parse(txtSalario.Text);
                _dto.dataAdmissao = Convert.ToString(mcdAdmissao);

                FuncionarioBusiness _business = new FuncionarioBusiness();

                if (_business.insertFuncionario(_dto)){
                    clearFuncionario();
                    MessageBox.Show("Funcionario Inserido Com Sucesso!", "Novo Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridViewFuncionario();
                }else{
                    MessageBox.Show("Não foi Possível Inserir o Novo Funcionario!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


/******************************************************************************************************************/


        /// <summary>
        /// Verificar os Dados digitados em Advetência ou Faltas do Funcionários e salva no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntSalvarAdvetenciaFalta_Click(object sender, EventArgs e){

            bool verificar = false;

            if (String.IsNullOrEmpty(rbAdvetencia.Text) || String.IsNullOrEmpty(rbFalta.Text)){
                lblErroAdFalta.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtFuncionarioPunido.Text)){
                lblErroCodigoPunido.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtFuncionarioPunidor.Text)){
                lblErroCodigoPunidor.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcdOcorrencia.Text)){
                lblErroDataOcorerncia.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (String.IsNullOrEmpty(mcdOcorrido.Text)){
                lblErroDataOcorrido.Text = "* Campo Obrigatório.";
                verificar = true;
            }

            if (!verificar){
                FuncionarioDTO _dto = new FuncionarioDTO();

                if (String.IsNullOrEmpty(rbAdvetencia.Text))
                    _dto.tipoAdvertencia = rbFalta.Text;
                _dto.tipoAdvertencia = rbAdvetencia.Text;

                _dto.codFuncPunido = int.Parse(txtFuncionarioPunido.Text);
                _dto.codFuncPunidor = int.Parse(txtFuncionarioPunidor.Text);
                _dto.dataOcorrencia = Convert.ToString(mcdOcorrencia);
                _dto.dataOcorrido = Convert.ToString(mcdOcorrido);
                _dto.descricao = txtDescricao.Text;


                FuncionarioBusiness _business = new FuncionarioBusiness();

                if (_business.insertAdvertencia(_dto)){

                    clearAdvertencia();
                    MessageBox.Show("Advetência Inserido Com Sucesso!", "Novo Advertência", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherGridViewFuncionario();
                }else{

                    MessageBox.Show("Não foi Possível Inserir a Nova Advertência!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
        private void bntVoltarAdvertenciaFalta_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntCancelarAdvetenciaFalta_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void clearFuncionario(){
            txtNomeCompleto.Clear();
            mtbFoneFixo.Clear();
            mtbFoneMovel1.Clear();
            mtbFoneMovel2.Clear();
            txtEmail.Clear();
            txtSalario.Clear();         
        
        }

        /// <summary>
        /// 
        /// </summary>
        private void clearAdvertencia() {
            txtFuncionarioPunido.Clear();
            txtFuncionarioPunidor.Clear();
            txtDescricao.Clear();
        }

    }
}
