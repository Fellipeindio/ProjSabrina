using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class FornecedorBusiness : com.ucb.DataBase.FornecedorDAL{

        private FornecedorDAL _fornecedorDAL;

        public FornecedorBusiness() {
            if (_fornecedorDAL == null)
                _fornecedorDAL = new FornecedorDAL();
        }

        public DataTable buscarTodosFornecedores() {
            try {
                return _fornecedorDAL.buscarTodosFornecedores();
            }catch(Exception ex){
                throw ex;
            }
        }

        public bool insertFornecedor(DataTransferObject.FornecedorDTO _dto){
            try{
                if (!String.IsNullOrEmpty(_dto.nome) &&
                    !String.IsNullOrEmpty(_dto.foneFixo) &&
                    !String.IsNullOrEmpty(_dto.foneMovel1) &&
                    !String.IsNullOrEmpty(_dto.foneMovel2) &&
                    !String.IsNullOrEmpty(_dto.email)){

                    return _fornecedorDAL.insertFornecedor(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }
    }
}