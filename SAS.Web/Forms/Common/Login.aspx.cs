using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAS;
using Para.Utility;

namespace SAS.Web.Forms.Common
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SAS.Business.User bizUser = new Business.User();
            SAS.Entity.User user = null;
            MessageBox message = new MessageBox();

            lblMessage.Text = string.Empty;
            lblMessage.Visible = false;

            message = bizUser.Authenticate(txtUserName.Text, txtPassword.Text);

            if (message.Type == MessageType.Success && message.Entity != null)
            {
                user = (Entity.User)message.Entity;
                Session["USER_ID"] = user.Id;
                Session["LOGIN_ID"] = user.LoginId;
                Session["USER_NAME"] = user.UserName;

                Response.Redirect("~/Forms/Masters/Employee.aspx");
            }
            else
            {
                Session.RemoveAll();
                wmbLogin.SetMessage(message);
            }
        }
    }
}