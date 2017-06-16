using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{
    public class FornecedorDAL{

        public DataTable buscarTodosFornecedores() {
            try {
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())) {
                    DataSet _dtSet = new DataSet();
                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT Fornecedor.nome, Fornecedor.foneFixo, Fornecedor.foneMovel1,Fornecedor.FoneMovel2, Fornecedor.email, Endereco.endereco, Endereco.numero, Endereco.complemento FROM Fornecedor INNER JOIN Endereco on Fornecedor.codigo = Endereco.codUsuario ", _connection);
                   
                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }

            }catch (Exception ex) {
                throw ex;
            }
        
        }


        public bool insertFornecedor(DataTransferObject.FornecedorDTO dto){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                    var sql = "INSERT INTO Fornecedor (nome, foneFixo, foneMovel1, foneMovel2, email) VALUES (@nome, @foneFixo, @foneMovel1, @foneMovel2, @email)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@nome", SqlDbType.VarChar).Value = dto.nome;
                        _command.Parameters.Add("@foneFixo", SqlDbType.VarChar).Value = dto.foneFixo;
                        _command.Parameters.Add("@foneMovel1", SqlDbType.VarChar).Value = dto.foneMovel1;
                        _command.Parameters.Add("@foneMovel2", SqlDbType.VarChar).Value = dto.foneMovel2;
                        _command.Parameters.Add("@email", SqlDbType.VarChar).Value = dto.email;

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
