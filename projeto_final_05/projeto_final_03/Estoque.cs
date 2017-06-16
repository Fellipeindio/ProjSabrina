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
    public partial class Estoque : Form{
        public Estoque(){
            InitializeComponent();
        }

        private void bntVoltarEstoque_Click(object sender, EventArgs e){
            this.Close();

            Principal _principal = new Principal();
            _principal.Show();
        }
    }
}
