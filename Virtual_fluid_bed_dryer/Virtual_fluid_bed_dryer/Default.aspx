<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Virtual_fluid_bed_dryer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link rel="stylesheet" href="main_style.css" type="text/css" />
    <title></title>
    <style type="text/css">

        .auto-style1 {
            color: #65A9D7;
        }
        .auto-style2 {
            text-decoration: none;
        }

    </style>
</head>
    
<body>
    <form id="form1" runat="server">
    <div class="top_div">
    
        <p class="ThreeDlarge"> Virtual Fluid<br />Bed Dryer</p>
        
        <table aria-orientation="horizontal">
            <tr>
                <td class="LogPassText" >&nbsp; Login:</td>
                <td class="LogPassInput"><asp:TextBox ID="txtLogin" runat="server" CssClass="tb7" Wrap="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLogin" ErrorMessage="Login required" style="color: #CC0000" Font-Names="Verdana" Font-Size="Large">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Password:</td>
                <td class="LogPasssInput"><asp:TextBox ID="txtPass" runat="server" TextMode="Password" CssClass="tb7"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Password required" style="color: #CC0000" Font-Names="Verdana" Font-Size="Large">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        <center>
            <tr>
                <td class="normal-row" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button" Width="6.4em" OnClick="btnLogin_Click"/>
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                <asp:Button ID="btnRegister" runat="server" CausesValidation="False" OnClick="btnRegister_Click" Text="Register" CssClass="button" Width="6.4em"  />
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="validation-row" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="text-align: center" DisplayMode="List" Height="2.5em" ShowMessageBox="True" />
                </td>
            </tr>
            <tr>
                <td class="LogPassInput" colspan="2">
                    <center><p class="normal-row"><a class="auto-style2" href="Retrieve_password.aspx"><span class="auto-style1">Forgot password?</span></a></p></center>
                </td>
            </tr>
            </table></center>
    </div>
    </form>
</body>
</html>
