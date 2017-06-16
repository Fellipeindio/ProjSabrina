using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class AgendarVisitaBusiness : com.ucb.DataBase.AgendarVisitaDAL{

       private AgendarVisitaDAL _agendarVisitaDAL;

       public AgendarVisitaBusiness(){
           if (_agendarVisitaDAL == null)
               _agendarVisitaDAL = new AgendarVisitaDAL();
        
        }

        public DataTable buscarTodosCarros() {
            try {
                return _agendarVisitaDAL.buscarTodosAgendarVisita();
            }catch (Exception ex) {
                throw ex;
            }
        
        }

        public bool insertAgendarVisita(DataTransferObject.AgendarVisitaDTO _dto){
            try{
                if ((_dto.codCliente != null) && (_dto.codFuncionario != null) && !String.IsNullOrEmpty(_dto.tipoServico) && !String.IsNullOrEmpty(_dto.diaAgendamento) && !String.IsNullOrEmpty(_dto.diAgendado))
                {

                    return _agendarVisitaDAL.insertAgendarVisita(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }
    }
}
