using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.DataTransferObject
{
    public class EnderecoDTO
    {
        public int codigo { get; set; }

        public int codUsuario { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }
    }
}
