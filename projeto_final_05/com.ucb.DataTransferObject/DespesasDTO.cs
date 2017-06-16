using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject{
   public class DespesasDTO{

        public int codigo { get; set; }

        public string nome { get; set; }

        public float preco { get; set; }

        public string descricao { get; set; }

        public string dataPagamento { get; set; }


/***************************************************************************************/

        public int codigoProduto { get; set; }

        public string nomeProduto { get; set; }

        public int codFornecedor { get; set; }

        public int qtdeComprada { get; set; }

        public float precoPorPeca { get; set; }

        public float precoTotalCompra { get; set; }

        public float precoDeVenda { get; set; }

   }
}
