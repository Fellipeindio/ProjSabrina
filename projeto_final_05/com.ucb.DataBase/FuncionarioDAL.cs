using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{
    public class FuncionarioDAL{

        public DataTable buscarTodosFuncionarios() {
            try {
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())) {
                    DataSet _dtSet = new DataSet();
                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT Funcionario.nome, Funcionario.foneFixo, Funcionario.foneMovel1, Funcionario.foneMovel2, Funcionario.email, Funcionario.salario, Funcionario.dataAdmissao, Endereco.endereco, Endereco.numero, Endereco.complemento FROM Funcionario INNER JOIN Endereco on Endereco.codUsuario = Funcionario.codigo", _connection);
                    
                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }
            }catch(Exception ex){
                throw ex;
            }
        }

        public bool insertFuncionario(DataTransferObject.FuncionarioDTO dto) {
            try {
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    var sql = "INSERT INTO Funcionario (nome, foneFixo, foneMovel1, foneMovel2, email, salario, dataAdmissao) VALUES (@nome, @foneFixo, @foneMovel1, @foneMovel2, @email, @salario, @dataAdmissao)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@nome", SqlDbType.VarChar).Value = dto.nome;
                        _command.Parameters.Add("@foneFixo", SqlDbType.VarChar).Value = dto.foneFixo;
                        _command.Parameters.Add("@foneMovel1", SqlDbType.VarChar).Value = dto.foneMovel1;
                        _command.Parameters.Add("@foneMovel2", SqlDbType.VarChar).Value = dto.foneMovel2;
                        _command.Parameters.Add("@email", SqlDbType.VarChar).Value = dto.email;
                        _command.Parameters.Add("@salario", SqlDbType.Float).Value = dto.salario;
                        _command.Parameters.Add("@dataAdmissao", SqlDbType.VarChar).Value = dto.dataAdmissao;

                        _connection.Open();
                        _command.ExecuteNonQuery();

                        return true;
                    }
                }
            }catch(Exception ex){
                throw ex;
            }
        
        }

        public bool insertAdvertencia(DataTransferObject.FuncionarioDTO dto) {
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    var sql = "INSERT INTO Funcionario (tipoAdvertencia, codFuncPunido, codFuncPunidor, descricao, dataOcorrencia, dataOcorrido) VALUES (@tipoAdvertencia, @codFuncPunido, @codFuncPunidor, @descricao, @dataOcorrencia, @dataOcorrido)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@tipoAdvertencia", SqlDbType.VarChar).Value = dto.tipoAdvertencia;
                        _command.Parameters.Add("@codFuncPunido", SqlDbType.Int).Value = dto.codFuncPunido;
                        _command.Parameters.Add("@codFuncPunidor", SqlDbType.Int).Value = dto.codFuncPunidor;
                        _command.Parameters.Add("@descricao", SqlDbType.VarChar).Value = dto.descricao;
                        _command.Parameters.Add("@dataOcorrencia", SqlDbType.VarChar).Value = dto.dataOcorrencia;
                        _command.Parameters.Add("@dataOcorrido", SqlDbType.VarChar).Value = dto.dataOcorrido;

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
