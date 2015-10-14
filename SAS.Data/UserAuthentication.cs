using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data
{
    public class UserAuthentication
    {
        public DataSet Authenticate(string loginId, string password)
        {
            try
            {
                DbContext dbContext = new DbContext();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "a05014_authenticate_user";

                command.Parameters.AddWithValue("@login_id", loginId);
                command.Parameters.AddWithValue("@password", password);

                DataSet userData = dbContext.GetData(command);

                return userData;
            }
            catch
            {
                throw;
            }
        }
    }
}
