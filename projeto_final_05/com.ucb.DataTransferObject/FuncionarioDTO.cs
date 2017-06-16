using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject{
   public class FuncionarioDTO{

        public int codigo { get; set; }

        public string nome { get; set; }

        public string foneFixo { get; set; }

        public string foneMovel1 { get; set; }

        public string foneMovel2 { get; set; }

        public string email { get; set; }

        public float salario { get; set; }
        
        public string dataAdmissao { get; set; }


/********************************************************************/

        //public int codigo { get; set; }

        public string tipoAdvertencia { get; set; }

        public int codFuncPunido { get; set; }

        public int codFuncPunidor { get; set; }

        public string descricao { get; set; }

        public string dataOcorrencia { get; set; }

        public string dataOcorrido { get; set; }
    }
}
