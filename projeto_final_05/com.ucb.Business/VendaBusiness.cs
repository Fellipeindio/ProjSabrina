using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class VendaBusiness : ucb.DataBase.VendaDAL{
        private VendaDAL _vendaDAL;

        public VendaBusiness() {
            if (_vendaDAL == null) {
                _vendaDAL = new VendaDAL();
            }
        
        }

        public DataTable buscarTodasVendas(){
            try {
                return _vendaDAL.buscarTodasVendas();
            }catch (Exception ex) {
                throw ex;
            }
        }

        public bool insertVenda(DataTransferObject.VendaDTO _dto) {

            try{
                if ((String.IsNullOrEmpty(_dto.tipoVenda)) &&
                    (String.IsNullOrEmpty(_dto.formaPagamento)) &&
                    (String.IsNullOrEmpty(_dto.dataVenda)) &&
                    (String.IsNullOrEmpty(_dto.observacao)) &&
                    (_dto.codFuncionario == null) &&
                    (_dto.codVenda == null) &&
                    (_dto.qtdeVendida == null) &&
                    (_dto.precoTotal == null))
                {

                    return _vendaDAL.insertVenda(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }

    }
}

