using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using com.ucb.DataTransferObject;
using com.ucb.Business;

namespace projeto_final_03{


    public partial class Cliente : Form{

        /* Criei para o endereco tudo oq foi necessário
         * EnderecoDAL
         * EnderecoDTO
         * EnderecoBusiness
         * Criei dois métodos de buscar cliente, pois um deles utilizei para verificar apenas os clientes
         * E outro com o JOIN que você fez
         */
        public Cliente(){
            InitializeComponent();
            preencherGridView();
        }

        private void preencherGridView() {
            ClienteBusiness _cliente = new ClienteBusiness();
            dataGridViewCliente.DataSource = _cliente.buscarTodosClientesEndereco();
        }

        private void bntSalvar_Click(object sender, EventArgs e){

            bool verificar = false;

            if (String.IsNullOrEmpty(txtNomeCompleto.Text)){
                lblErroNomeCompleto.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (!mtbFoneMovel1.MaskCompleted){
                lblErroFoneMovel1.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtEndereco.Text)){
                lblErroEndereco.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (String.IsNullOrEmpty(txtNumero.Text)){
                lblErroNumero.Text = "* Campo Obrigatório";
                verificar = true;
            }

            if (verificar == false){
                ClienteDTO _clienteDto = new ClienteDTO();
                EnderecoDTO _enderecoDto = new EnderecoDTO();

                // Setando cliente
                _clienteDto.nome = txtNomeCompleto.Text;
                _clienteDto.foneFixo = mtbFoneFixo.Text;
                _clienteDto.foneMovel1 = mtbFoneMovel1.Text;
                _clienteDto.foneMovel2 = mtbFoneMovel2.Text;
                _clienteDto.email = txtEmail.Text;                


                ClienteBusiness _clienteBusiness = new ClienteBusiness();
                EnderecoBusiness _enderecoBusiness = new EnderecoBusiness();

                if (_clienteBusiness.insertCliente(_clienteDto)){
                    // Após inserir o cliente busquei todos os clientes "SEM FAZER O JOIN"
                    // Para conseguir buscar o ID do cliente
                    DataTable clientes =  _clienteBusiness.buscarTodosClientes();
                    // Seu metodo retorna um DATATable
                    // Pegando as linhas da tabela para encontrar o cliente dono do endereço
                    foreach (DataRow dataRow in clientes.Rows)
                    {
                        // Será setado ao achar o cliente 
                        if (_clienteDto.nome.Equals(dataRow["nome"].ToString()))
                        {
                            // Setando endereco
                            _enderecoDto.codUsuario = Convert.ToInt32(dataRow["codigo"]);
                            _enderecoDto.endereco = txtEndereco.Text;
                            _enderecoDto.numero = 0;
                            _enderecoDto.complemento = txtComplemento.Text;

                            if (_enderecoBusiness.insertEndereco(_enderecoDto))
                            {
                                clear();
                                MessageBox.Show("Endereco Inserido Com Sucesso!", "Novo Endereco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    }
                    MessageBox.Show("Cliente Inserido Com Sucesso!", "Novo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else {
                    MessageBox.Show("Não foi Possível Inserir o Novo Cliente!", "Falha no Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            preencherGridView();

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

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e){
            
        }

        private void clear(){

            txtNomeCompleto.Clear();
            mtbFoneFixo.Clear();
            mtbFoneMovel1.Clear();
            mtbFoneMovel2.Clear();
            txtEmail.Clear();

            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();

        }


    }
}
