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
    public partial class Login : Form{
        public Login(){
            InitializeComponent();
        }

        private void bntEntrar_Click(object sender, EventArgs e){

            var _usuario = System.Configuration.ConfigurationManager.AppSettings["usuario"].ToString();
            var _senha = System.Configuration.ConfigurationManager.AppSettings["senha"].ToString();

            if (txtUsuario.Text.Equals(_usuario) && txtSenha.Text.Equals(_senha)){
                this.Hide();

                Principal _principal = new Principal();
                _principal.Show();

            }else{
                MessageBox.Show("Usuário ou Senha incorreto. Tente Novamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            
            }

        }

        private void bntCancelar_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
