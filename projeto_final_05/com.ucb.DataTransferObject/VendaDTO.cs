using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject{
    public class VendaDTO{

        public int codFuncionario { get; set; }

        public string tipoVenda { get; set; }

        public int codVenda { get; set; }

        public int qtdeVendida { get; set; }

        public float precoTotal { get; set; }

        public string formaPagamento { get; set; }

        public string dataVenda { get; set; }

        public string observacao { get; set; }

    }
}
