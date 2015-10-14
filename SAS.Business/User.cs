using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAS;
using System.Data;
using Para.Utility;

namespace SAS.Business
{
    public class User
    {
        public MessageBox Authenticate(string loginId, string password)
        {
            try
            {
                MessageBox message = new MessageBox();
                Entity.User validUser = null;
                Data.UserAuthentication userAuthentication = new Data.UserAuthentication();
                DataSet userData = new DataSet();

                userData = userAuthentication.Authenticate(loginId, password);

                if (userData != null && userData.Tables.Count > 0 && userData.Tables[0].Rows.Count > 0)
                {
                    DataRow userRow = userData.Tables[0].Rows[0];

                    validUser = new Entity.User();
                    validUser.Id = Convert.ToInt32(userRow["id"]);
                    validUser.LoginId = userRow["login_id"].ToString();
                    validUser.Password = userRow["password"].ToString();
                    validUser.UserName = userRow["user_name"].ToString();
                    validUser.InvalidLoginAttempts = Convert.ToInt32(userRow["invalid_login_attempts"]);
                    validUser.IsLocked = Convert.ToBoolean(userRow["is_locked"]);


                    if (validUser.IsLocked)
                    {
                        message.Type = MessageType.Warning;
                        message.MessageTitle = "Your account has been lcoked. Please contact System Administrator.";
                    }
                    else if (!validUser.IsLocked && !validUser.Password.Equals(password))
                    {
                        message.Type = MessageType.Warning;
                        message.MessageTitle = "Invalid Authentication. You are left with only " + (4 - validUser.InvalidLoginAttempts) + " attempts.";
                    }
                    else if (validUser.Password.Equals(password))
                    {
                        message.Entity = validUser;
                        message.Type = MessageType.Success;
                        message.MessageTitle = "Authentication done successfully.";
                    }
                    else
                    {
                        message.Type = MessageType.Failure;
                        message.MessageTitle = "Invalid Authentication. Please re-login with valid Login Id and Password.";
                    }
                }
                else
                {
                    message.Type = MessageType.Failure;
                    message.MessageTitle = "Invalid Authentication. Please re-login with valid Login Id and Password.";
                }

                return message;
            }
            catch
            {
                throw;
            }
        }
    }
}
