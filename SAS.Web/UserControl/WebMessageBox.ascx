<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebMessageBox.ascx.cs" Inherits="SAS.Web.UserControl.WebMessageBox" %>
<asp:Panel ID="pnlWebMessageBox" runat="server" CssClass="message-box">
    <div class="message-title">
        <div runat="server" id="divIcon" class="message-icon"></div>
        <asp:Label ID="lblMessageTitle" runat="server" Text="" CssClass="message-title-text"></asp:Label>
    </div>
</asp:Panel>
