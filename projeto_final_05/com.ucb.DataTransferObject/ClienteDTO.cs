using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject{

    /// <summary>
    /// Classe que transporta dados entre todas as camadas
    /// </summary>
    public class ClienteDTO{

       
        public int codigo { get; set; }

        public string nome { get; set; }

        public string foneFixo { get; set; }

        public string foneMovel1 { get; set; }

        public string foneMovel2 { get; set; }

        public string email { get; set; }

    }
}
