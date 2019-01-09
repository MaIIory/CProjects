<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmAccount.aspx.cs" Inherits="Virtual_fluid_bed_dryer.ConfirmAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="main_style.css" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lblResult" CssClass="normal-text" runat="server"></asp:Label>
        <br />
        <asp:HyperLink ID="linkLogin" runat="server" CssClass="normal-link" NavigateUrl="~/Default.aspx" Visible="False">Click here to log in</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
