using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ucb.DataBase;
using System.Data;

namespace com.ucb.Business{
    public class DespesasBusiness : ucb.DataBase.DespesasDAL{

        private DespesasDAL _despesasDAL;

        public DespesasBusiness() {
            if (_despesasDAL == null)
                _despesasDAL = new DespesasDAL();
        }

        public DataTable buscarTodasDespesas() {
            try {
                return _despesasDAL.buscarTodasDespesas();
            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable buscarTodasCompras(){
            try{
                return _despesasDAL.buscarTodasCompras();
            }catch (Exception ex){
                throw ex;
            }
        }


        public bool insertCompras(DataTransferObject.DespesasDTO dto){
            try{
                if ((String.IsNullOrEmpty(dto.nomeProduto)) && 
                    (dto.codFornecedor == null) && 
                    (dto.qtdeComprada == null) && 
                    (dto.precoPorPeca == null) && 
                    (dto.precoTotalCompra == null) &&
                    (dto.precoDeVenda == null)) {

                    return _despesasDAL.insertCompra(dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }


        public bool insertDespesa(DataTransferObject.DespesasDTO dto){
            try{
                if ((dto.preco == null) &&
                    (String.IsNullOrEmpty(dto.nome)) &&
                    (String.IsNullOrEmpty(dto.descricao)) &&
                    (String.IsNullOrEmpty(dto.dataPagamento))){

                    return _despesasDAL.insertDespesa(dto);
                }else{
                    return false;
                }
            }catch (Exception ex){
                throw ex;
            }
        }

    }
}

