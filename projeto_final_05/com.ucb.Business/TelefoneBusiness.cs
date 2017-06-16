using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class TelefoneBusiness: ucb.DataBase.TelefoneDAL{

        private TelefoneDAL _telefoneDAL;

        public TelefoneBusiness() {
            if (_telefoneDAL == null)
                _telefoneDAL = new TelefoneDAL();
        }

        public DataTable buscarTelefone() {
            try {
                return _telefoneDAL.buscarTelefone();
            }catch (Exception ex) {
                throw ex;
            }
        
        }

    }
}
