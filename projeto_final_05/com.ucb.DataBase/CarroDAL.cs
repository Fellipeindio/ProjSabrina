using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{

    /// <summary>
    /// Classe que trabalha  com a tabela Carro do banco do dados
    /// </summary>
    public class CarroDAL{

        public DataTable buscarTodosCarros(){
            try { 
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    DataSet _dtSet = new DataSet();

                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT Carro.marca, Carro.modelo, Carro.ano, Cliente.nome, Cliente.foneMovel1 FROM Carro INNER JOIN Cliente on Cliente.codigo = Carro.codCliente", _connection);
                                                                                                
                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }
              }catch(Exception ex){
                    throw ex;
            }
        }

        public bool insertCarro(DataTransferObject.CarroDTO dto){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                    var sql = "INSERT INTO Carro (codCliente, marca, modelo, ano) VALUES (@codCliente, @marca, @modelo, @ano)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@codCliente", SqlDbType.Int).Value = dto.codCliente;
                        _command.Parameters.Add("@marca", SqlDbType.VarChar).Value = dto.marca;
                        _command.Parameters.Add("@modelo", SqlDbType.VarChar).Value = dto.modelo;
                        _command.Parameters.Add("@ano", SqlDbType.Int).Value = dto.ano;

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
