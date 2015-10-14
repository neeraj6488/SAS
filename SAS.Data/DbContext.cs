using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data
{
    internal class DbContext
    {
        #region Public Methods

        public DataSet GetData(SqlCommand command)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                command.Connection = _getConnection();
                adapter.SelectCommand = command;

                DataSet dataResult = new DataSet();

                adapter.Fill(dataResult);

                return dataResult;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataSet Save(SqlCommand command)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                command.Connection = _getConnection();

                adapter.SelectCommand = command;

                DataSet dataResult = new DataSet();

                adapter.Fill(dataResult);

                return dataResult;
            }
            catch
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        #endregion

        #region Private Methods

        private SqlConnection _getConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ToString();
                connection.Open();

                return connection;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
