using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class FuncionarioBusiness : com.ucb.DataBase.FuncionarioDAL{

        private FuncionarioDAL _funcionarioDAL;

        public FuncionarioBusiness(){
            if (_funcionarioDAL == null)
                _funcionarioDAL = new FuncionarioDAL();
        }

        public DataTable buscarTodosFuncionarios() {
            try {
                return _funcionarioDAL.buscarTodosFuncionarios();
            }catch (Exception ex) {
                throw ex;
            }
        }

        public bool insertFuncionario(DataTransferObject.FuncionarioDTO _dto) {
            try{
                if ((String.IsNullOrEmpty(_dto.nome)) && 
                    (String.IsNullOrEmpty(_dto.foneFixo)) &&
                    (String.IsNullOrEmpty(_dto.foneMovel1)) && 
                    (String.IsNullOrEmpty(_dto.foneMovel2)) && 
                    (String.IsNullOrEmpty(_dto.email)) && 
                    (_dto.salario == null) && 
                    (String.IsNullOrEmpty(_dto.dataAdmissao))){

                    return _funcionarioDAL.insertFuncionario(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        
        }

        public bool insertAdvertencia(DataTransferObject.FuncionarioDTO _dto){
            try{
                if ((String.IsNullOrEmpty(_dto.descricao)) &&
                    (String.IsNullOrEmpty(_dto.dataOcorrido)) &&
                    (String.IsNullOrEmpty(_dto.dataOcorrencia)) &&
                    (_dto.codFuncPunidor == null) &&
                    (_dto.codFuncPunido == null) &&
                    (_dto.tipoAdvertencia == null)){

                        return _funcionarioDAL.insertAdvertencia(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }

        }
    }
}
