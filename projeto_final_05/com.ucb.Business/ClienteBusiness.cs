using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

using com.ucb.DataTransferObject;

namespace com.ucb.Business{
    public class ClienteBusiness : ucb.DataBase.ClienteDAL{

        private ClienteDAL _clienteDAL;

        public ClienteBusiness() {
            if (_clienteDAL == null)
                _clienteDAL = new ClienteDAL();
        
        }

        public DataTable buscarTodosClientesEndereco() {
            try {
                return _clienteDAL.buscarTodosClientesEndereco();

            }catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable buscarTodosClientes()
        {
            try
            {
                return _clienteDAL.buscarTodosClientes();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool insertCliente(DataTransferObject.ClienteDTO _dto){
            try {
                if (!String.IsNullOrEmpty(_dto.nome) && 
                    !String.IsNullOrEmpty(_dto.foneFixo) && 
                    !String.IsNullOrEmpty(_dto.foneMovel1) && 
                    !String.IsNullOrEmpty(_dto.foneMovel2) && 
                    !String.IsNullOrEmpty(_dto.email)) {

                    return _clienteDAL.insertCliente(_dto);
                }else {
                    return false;
                }
            }catch(Exception ex){
                throw ex;
            }
        
        }
        
    }
}
