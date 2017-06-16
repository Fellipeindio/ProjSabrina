using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace com.ucb.DataBase{
    public class AgendarVisitaDAL{
        public DataTable buscarTodosAgendarVisita(){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    DataSet _dtSet = new DataSet();

                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT Cliente.nome, Funcionario.nome, AgendarVisita.TipoServico, AgendarVisita.diaAgendado FROM AgendarVisita INNER JOIN Cliente on Cliente.codigo = AgendarVisita.codCliente INNER JOIN Funcionario on Funcionario.codigo = AgendarVisita.codFuncionario", _connection);

                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }
            }catch (Exception ex){
                throw ex;
            }
        }

        public bool insertAgendarVisita(DataTransferObject.AgendarVisitaDTO dto){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                    var sql = "INSERT INTO AgendarVisita (codCliente, codFuncionario, tipoServico, diaAgendamento, diaAgendado) VALUES (@codCliente, @codFuncionario, @tipoServico, @diaAgendamento, @diaAgendado)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@codCliente", SqlDbType.Int).Value = dto.codCliente;
                        _command.Parameters.Add("@codFuncionario", SqlDbType.Int).Value = dto.codFuncionario;
                        _command.Parameters.Add("@TipoServico", SqlDbType.VarChar).Value = dto.tipoServico;
                        _command.Parameters.Add("@diaAgendamento", SqlDbType.VarChar).Value = dto.diaAgendamento;
                        _command.Parameters.Add("@diaAgendado", SqlDbType.VarChar).Value = dto.diAgendado;

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
