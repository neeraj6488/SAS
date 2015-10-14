using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAS.Web
{
    public partial class Private : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER_NAME"] != null)
            {
                lblLoggedinUser.Text = "Welcome, " + Session["USER_NAME"];
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
        }
    }
}