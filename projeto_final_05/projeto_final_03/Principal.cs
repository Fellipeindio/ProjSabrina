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
    public partial class Principal : Form{
        public Principal(){
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e){

            Application.Exit();
        }

        private void bntCliente_Click(object sender, EventArgs e){
            this.Hide();

            Cliente _cliente = new Cliente();
            _cliente.Show();
        }

        private void bntCarro_Click(object sender, EventArgs e){
            this.Hide();

            Carro _carro = new Carro();
            _carro.Show();
        }

        private void bntFuncionario_Click(object sender, EventArgs e){
            this.Hide();

            Funcionario _funcionario = new Funcionario();
            _funcionario.Show();
        }

        private void bntVendas_Click(object sender, EventArgs e){
            this.Hide();

            Vendas _vendas = new Vendas();
            _vendas.Show();
        }

        private void bntFornecedor_Click(object sender, EventArgs e){
            this.Hide();

            Fornecedor _fornecedor = new Fornecedor();
            _fornecedor.Show();
        }

        private void bntDespesas_Click(object sender, EventArgs e){
            this.Hide();

            Despesas _despesas = new Despesas();
            _despesas.Show();
        }

        private void btnAgendarVisita_Click(object sender, EventArgs e){
            this.Hide();

            AgendarVisita _agendar = new AgendarVisita();
            _agendar.Show();
        }
    }
}
