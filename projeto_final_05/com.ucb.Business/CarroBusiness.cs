using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class CarroBusiness: ucb.DataBase.CarroDAL{

        private CarroDAL _carroDAL;

        public CarroBusiness() {
            if (_carroDAL == null)
                _carroDAL = new CarroDAL();
        
        }

        public DataTable buscarTodosCarros() {
            try {
                return _carroDAL.buscarTodosCarros();
            }catch (Exception ex) {
                throw ex;
            }
        
        }

        public bool insertCarro(DataTransferObject.CarroDTO _dto){
            try{
                if ((_dto.ano != null) && (_dto.codCliente != null) && !String.IsNullOrEmpty(_dto.marca) && !String.IsNullOrEmpty(_dto.modelo)){

                    return _carroDAL.insertCarro(_dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }
    }
}
