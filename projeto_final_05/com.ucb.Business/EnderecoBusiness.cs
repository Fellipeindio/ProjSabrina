using com.ucb.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ucb.Business
{
    public class EnderecoBusiness
    {
        private EnderecoDAL _enderecoDAL;

        public EnderecoBusiness()
        {
            if (_enderecoDAL == null)
                _enderecoDAL = new EnderecoDAL();

        }
        public bool insertEndereco(DataTransferObject.EnderecoDTO _dto)
        {
            try
            {
                if (!String.IsNullOrEmpty(_dto.codUsuario.ToString()) &&
                    !String.IsNullOrEmpty(_dto.complemento) &&
                    !String.IsNullOrEmpty(_dto.endereco) &&
                    !String.IsNullOrEmpty(_dto.numero.ToString()))
                {

                    return _enderecoDAL.insertEndereco(_dto);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
