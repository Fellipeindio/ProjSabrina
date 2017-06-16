using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject{
    public class AgendarVisitaDTO{

        public int codigo { get; set; }

        public int codCliente { get; set; }

        public int codFuncionario { get; set; }

        public string tipoServico { get; set; }

        public string diaAgendamento { get; set; }

        public string diAgendado { get; set; }

    }
}
