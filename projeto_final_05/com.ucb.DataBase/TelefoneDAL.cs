using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace com.ucb.DataBase{
   public class TelefoneDAL{

       public DataTable buscarTelefone() { //Tem que pegar pelo ID do Cliente
           try {
               using (SqlConnection _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConecxao"].ToString())) {
                   DataSet _dtSet = new DataSet();
                   _connection.Open();

                   SqlDataAdapter _dtAdapter = new SqlDataAdapter();
                   _dtAdapter.SelectCommand = new SqlCommand("SELECT * FROM Telefone", _connection);

                   _dtAdapter.Fill(_dtSet);
                   return _dtSet.Tables[0];
               }
           }catch (Exception ex) {
               throw ex;
           }
       }
    }




}

