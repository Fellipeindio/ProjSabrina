using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using com.ucb.DataTransferObject;
using com.ucb.DataBase.Properties;

namespace com.ucb.DataBase{
    
    /// <summary>
    /// Classe que trabalha  com a tabela Cliente do banco do dados
    /// </summary>
    public class ClienteDAL{

        public DataTable buscarTodosClientesEndereco(){
            try {
                using (SqlConnection _connection = new SqlConnection(Settings.Default.minhaConexao)){

                    DataSet _dtSet = new DataSet();
                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    // _dtAdapter.SelectCommand = new SqlCommand("SELECT Cliente.CodCliente, Cliente.Nome, Cliente.Email, Telefone.FoneFixo, Telefone.FoneMovel1, Telefone.FoneMovel2, Endereco.Endereco, Endereco.Numero, Endereco.Complemento FROM Cliente INNER JOIN Telefone on Cliente.CodCliente = Telefone.CodUsuario INNER JOIN Endereco on Cliente.CodCliente = Endereco.CodUsuario", _connection);
                    _dtAdapter.SelectCommand = new SqlCommand("Select * from Cliente as cliente join Endereco as endereco on cliente.codigo = endereco.codUsuario", _connection);
                    // Mudei o final aqui para ficar mais legivel e bonito  
                    DataTable tabela = new DataTable();
                    _dtAdapter.Fill(tabela);
                    return tabela;

                }

            }catch (Exception ex) {
                throw ex;
            }
        }

        public DataTable buscarTodosClientes()
        {
            /* Permite Buscar todos os cliente
             * Indicaria fazer uma busca por nome ou ID
             */
            try
            {
                using (SqlConnection _connection = new SqlConnection(Settings.Default.minhaConexao))
                {

                    DataSet _dtSet = new DataSet();
                    _connection.Open();

                    SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                    // _dtAdapter.SelectCommand = new SqlCommand("SELECT Cliente.CodCliente, Cliente.Nome, Cliente.Email, Telefone.FoneFixo, Telefone.FoneMovel1, Telefone.FoneMovel2, Endereco.Endereco, Endereco.Numero, Endereco.Complemento FROM Cliente INNER JOIN Telefone on Cliente.CodCliente = Telefone.CodUsuario INNER JOIN Endereco on Cliente.CodCliente = Endereco.CodUsuario", _connection);
                    _dtAdapter.SelectCommand = new SqlCommand("Select * from Cliente", _connection);
                    DataTable tabela = new DataTable();
                    _dtAdapter.Fill(tabela);
                    return tabela;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool insertCliente (DataTransferObject.ClienteDTO dto) {
            try {
                using (SqlConnection _connection = new SqlConnection(Settings.Default.minhaConexao)) {

                    var sql = "INSERT INTO Cliente (nome, foneFixo, foneMovel1, foneMovel2, email) VALUES (@nome, @foneFixo, @foneMovel1, @foneMovel2, @email)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection)) {
                        _command.Parameters.Add("@nome", SqlDbType.VarChar).Value = dto.nome;
                        _command.Parameters.Add("@foneFixo", SqlDbType.VarChar).Value = dto.foneFixo;
                        _command.Parameters.Add("@foneMovel1", SqlDbType.VarChar).Value = dto.foneMovel1;
                        _command.Parameters.Add("@foneMovel2", SqlDbType.VarChar).Value = dto.foneMovel2;
                        _command.Parameters.Add("@email", SqlDbType.VarChar).Value = dto.email;

                        //Console.WriteLine("\n\n\n" + dto.nome + " " + dto.foneFixo + " " + dto.foneMovel1 + " " + dto.foneMovel2 + " " + dto.email + "\n\n\n");

                        _connection.Open();
                        _command.ExecuteNonQuery();

                        return true;
                    }
                }
            }catch(Exception ex){
                throw ex;
            }
        }





    }
}
