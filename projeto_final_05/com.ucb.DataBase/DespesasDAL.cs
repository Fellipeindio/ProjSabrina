using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{
    
    /// <summary>
    /// Classe que trabalha  com a tabela Despesas do banco do dados
    /// </summary>
    public class DespesasDAL{
        public DataTable buscarTodasDespesas() {
            try {
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    DataSet _dtSet = new DataSet();

                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT Despesa.nome, Despesa.preco, Despesa.descricao, Despesa.dataPagamento FROM Despesa", _connection);

                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }
            }catch (Exception ex) {
                throw ex;
            }
        }

        public bool insertDespesa(DataTransferObject.DespesasDTO dto){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                    var sql = "INSERT INTO Despesa (nome, preco, descricao, dataPagamento) VALUES (@nome, @preco, @descricao, @dataPagamento)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@nome", SqlDbType.VarChar).Value = dto.nome;
                        _command.Parameters.Add("@preco", SqlDbType.VarChar).Value = dto.preco;
                        _command.Parameters.Add("@descricao", SqlDbType.VarChar).Value = dto.descricao;
                        _command.Parameters.Add("@dataPagamento", SqlDbType.VarChar).Value = dto.dataPagamento;

                        _connection.Open();
                        _command.ExecuteNonQuery();

                        return true;
                    }
                }
            }catch (Exception ex){
                throw ex;
            }
        }


/*****************************************************************************************************************************************************************/


        public DataTable buscarTodasCompras(){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){
                    DataSet _dtSet = new DataSet();

                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    _dtAdapter.SelectCommand = new SqlCommand("SELECT CompraProduto.nomeProduto, Fornecedor.nome, CompraProduto.qtdeComprada, CompraProduto.precoPorPeca, CompraProduto.precoTotalCompra, CompraProduto.precoDeVenda FROM CompraProduto INNER JOIN Fornecedor on Fornecedor.codigo = CompraProduto.codFornecedor", _connection);

                    _dtAdapter.Fill(_dtSet);
                    return _dtSet.Tables[0];
                }
            }catch (Exception ex){
                throw ex;
            }
        }

        public bool insertCompra(DataTransferObject.DespesasDTO dto){
            try{
                using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString())){

                    var sql = "INSERT INTO Despesa (codigoProduto, nomeProduto, codFornecedor, qtdeComprada, precoPorPeca, precoTotalCompra, precoVenda) VALUES (@codigoProduto, @nomeProduto, @codFornecedor, @qtdeComprada, @precoPorPeca, @precoTotalCompra, @precoVenda)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)){
                        _command.Parameters.Add("@codigoProduto", SqlDbType.Int).Value = dto.codigoProduto;
                        _command.Parameters.Add("@nomeProduto", SqlDbType.VarChar).Value = dto.nomeProduto;
                        _command.Parameters.Add("@codFornecedor", SqlDbType.Int).Value = dto.codFornecedor;
                        _command.Parameters.Add("@qtdeComprada", SqlDbType.Int).Value = dto.qtdeComprada;

                        _command.Parameters.Add("@precoPorPeca", SqlDbType.Float).Value = dto.precoPorPeca;
                        _command.Parameters.Add("@precoTotalCompra", SqlDbType.Float).Value = dto.precoTotalCompra;
                        _command.Parameters.Add("@precoVenda", SqlDbType.Float).Value = dto.precoDeVenda;

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

