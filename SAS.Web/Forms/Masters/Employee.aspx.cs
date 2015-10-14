using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAS.Web.Forms.Masters
{
    public partial class Employee : SAS.Web.Common.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER_ID"] == null)
            {
                Response.Redirect(@"~/Forms/SystemPages/SessionExpired.aspx");
            }
        }
    }
}