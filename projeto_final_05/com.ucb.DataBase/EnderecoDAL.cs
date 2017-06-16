using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using com.ucb.DataTransferObject;
using com.ucb.DataBase.Properties;

namespace com.ucb.DataBase
{
    public class EnderecoDAL
    {
        public bool insertEndereco(DataTransferObject.EnderecoDTO dto)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(Settings.Default.minhaConexao))
                {

                    var sql = "INSERT INTO Endereco (codUsuario, endereco, numero, complemento) VALUES (@codUsuario, @endereco, @numero, @complemento)";

                    using (SqlCommand _command = new SqlCommand(sql, _connection))
                    {
                        _command.Parameters.Add("@codUsuario", SqlDbType.VarChar).Value = dto.codUsuario;
                        _command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = dto.endereco;
                        _command.Parameters.Add("@numero", SqlDbType.VarChar).Value = dto.numero;
                        _command.Parameters.Add("@complemento", SqlDbType.VarChar).Value = dto.complemento;

                        _connection.Open();
                        _command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
