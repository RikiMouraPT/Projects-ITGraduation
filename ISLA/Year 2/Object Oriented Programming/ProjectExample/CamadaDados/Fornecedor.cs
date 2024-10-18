using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Fornecedor
    {
        public static DataTable ObterLista()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = Properties.Settings.Default.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ListaFornecedores";

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);
                
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dataTable;
          
        }
    }
}
