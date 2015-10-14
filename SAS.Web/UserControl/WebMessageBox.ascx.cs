using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Para.Utility;

namespace SAS.Web.UserControl
{
    public partial class WebMessageBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetMessage(MessageBox message)
        {
            lblMessageTitle.Text = message.MessageTitle;

            switch (message.Type)
            {
                case MessageType.Success:
                    pnlWebMessageBox.CssClass = "message-box message-success";
                    divIcon.Attributes["class"] = "message-icon message-icon-success";
                    break;
                case MessageType.Failure:
                    pnlWebMessageBox.CssClass = "message-box message-failure";
                    divIcon.Attributes["class"] = "message-icon message-icon-failure";
                    break;
                case MessageType.Warning:
                    pnlWebMessageBox.CssClass = "message-box message-warning";
                    divIcon.Attributes["class"] = "message-icon message-icon-warning";
                    break;
            }
        }
    }
}