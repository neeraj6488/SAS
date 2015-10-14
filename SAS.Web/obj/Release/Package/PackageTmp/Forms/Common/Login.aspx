<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SAS.Web.Forms.Common.Login" %>

<%@ Register Src="~/UserControl/WebMessageBox.ascx" TagPrefix="uc1" TagName="WebMessageBox" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
    <link href="../../Content/WebMessageBox.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="login-box">
                <span>Welcome to my Web Application...!!!</span>

                <uc1:WebMessageBox runat="server" id="wmbLogin" />
                <div>
                    <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
                </div>

                <div>Sing in</div>
                <div>
                    <table>
                        <tr>
                            <td>User Name</td>
                            <td>
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <div>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <input type="reset" value="Reset" />
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
