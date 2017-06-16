using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{
    public class VendaDAL{
        public DataTable buscarTodasVendas(){
            try {
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                DataSet _dtSet = new DataSet();
                _connection.Open();

                SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                _dtAdapter.SelectCommand = new SqlCommand("SELECT Funcionario.nome, Venda.tipoVenda, Venda.qtdeVendida, Venda.precoTotal, Venda.formaPagamento, Venda.observacao, Venda.dataVenda FROM Venda INNER JOIN Funcionario on Funcionario.codigo = Venda.codFuncionario", _connection);

                _dtAdapter.Fill(_dtSet);
                return _dtSet.Tables[0];
                }
            }catch (Exception ex) {
                throw ex;
            }
        }

        public bool insertVenda(DataTransferObject.VendaDTO dto) {

            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    var sql = "INSERT INTO Venda (codFuncionario, qtdeVendida, precoTotal, formaPagamento, observacao, dataVenda) VALUES (@codFuncionario, @qtdeVendida, @precoTotal, @formaPagamento, @observacao, @dataVenda)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@codFuncionario", SqlDbType.Int).Value = dto.codFuncionario;
                        _command.Parameters.Add("@qtdeVendida", SqlDbType.Int).Value = dto.qtdeVendida;
                        _command.Parameters.Add("@precoTotal", SqlDbType.Float).Value = dto.precoTotal;
                        _command.Parameters.Add("@formaPagamento", SqlDbType.VarChar).Value = dto.formaPagamento;
                        _command.Parameters.Add("@observacao", SqlDbType.VarChar).Value = dto.observacao;
                        _command.Parameters.Add("@dataVenda", SqlDbType.VarChar).Value = dto.dataVenda;

                        _connection.Open();
                        _command.ExecuteNonQuery();

                        return true;
                    }
                }
            }catch (Exception ex){
                throw ex;
            }
        
        }
    }
}
