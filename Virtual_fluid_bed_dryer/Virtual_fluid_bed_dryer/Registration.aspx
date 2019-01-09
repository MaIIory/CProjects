<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Virtual_fluid_bed_dryer.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="main_style.css" type="text/css" />
    <title></title>
    <style type="text/css">
    </style>
    </head>
<body>
    <form id="form1" runat="server">

        <p class="ThreeDsmall" style="text-align: center"> Registration form:</p>

        <table>
            <tr>
                <td class="LogPassText">Login:</td>
                <td>
                    <asp:TextBox ID="txtLogin" CssClass="tb7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLogin" ErrorMessage="Login required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" CssClass="tb7" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Confirm password:</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" CssClass="tb7" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Password to confirm required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Passwords are diffrent" style="color: #CC0000">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" CssClass="tb7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email has wrong format" style="color: #CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
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
    </form>
    <center>
    <asp:Label ID="lblConfirmation" CssClass="normal-text" runat="server"></asp:Label><br />
    <asp:HyperLink ID="hlinkDefault" runat="server" CssClass="normal-link" NavigateUrl="~/Default.aspx" Visible="True">Click here to return to login page</asp:HyperLink>
        </center>
</body>
</html>
