<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Retrieve_password.aspx.cs" Inherits="Virtual_fluid_bed_dryer.Retrieve_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="stylesheet" href="main_style.css" type="text/css" />
    <title></title>
    <style type="text/css">
    </style>
    </head>
<body>
    <form id="form1" runat="server">

        <p class="ThreeDsmall" style="text-align: center"> Password Recovery:</p>

        <table>
            <tr>
                <td class="LogPassText" colspan="2">Enter your email address and click<br />
&nbsp;button to retrieve your password</td>
            </tr>
            <tr>
                <td class="LogPassText" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="LogPassText">E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" CssClass="tb7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                   <center><asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" CssClass="button" Text="Confirm" /></center> 
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="validation-row" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" DisplayMode="List" style="text-align: center" />
                </td>
            </tr>
            <tr>
                <td class="normal-row" style="text-align: center" colspan="2">
                    <br />
                </td>
            </tr>
        </table>
        <p>
            <center>
                    <asp:Label ID="lblConfirmation" CssClass="normal-text" runat="server"></asp:Label><br />
                    <asp:HyperLink ID="hlinkDefault" runat="server" CssClass="normal-link" NavigateUrl="~/Default.aspx" Visible="True">Click here to return to login page</asp:HyperLink>
                </center>
                </p>
    </form>
</body>
</html>
