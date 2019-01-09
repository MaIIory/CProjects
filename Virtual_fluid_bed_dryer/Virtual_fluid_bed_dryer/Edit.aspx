<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Virtual_fluid_bed_dryer.HowTo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .textBoxStyle1 {
	    width: 139px;
	    background: transparent url('images/bg3.jpg') no-repeat;
	    color : #747862;
	    height:20px;
	    border:0;
	    padding:4px 8px;
	    margin-bottom:0px;
        }

        .LogPassText {
        text-align: right;
        height: 1.5em;
        font-family: Verdana, sans-serif;
        width: auto;
        }

        .normal-row {
        clear: both;
        color: #3e779d;
        height: 1em;
        margin: 0;
        font-family: Verdana, sans-serif;
        }

        .button99 {
          border-top: 1px solid #96d1f8;
        background: #74b2db;
        background: -webkit-gradient(linear, left top, left bottom, from(#3e779d), to(#74b2db));
        background: -webkit-linear-gradient(top, #3e779d, #74b2db);
        background: -moz-linear-gradient(top, #3e779d, #74b2db);
        background: -ms-linear-gradient(top, #3e779d, #74b2db);
        background: -o-linear-gradient(top, #3e779d, #74b2db);
        padding: 11px 22px;
   -webkit-border-radius: 14px;
   -moz-border-radius: 14px;
   border-radius: 14px;
   -webkit-box-shadow: rgba(0,0,0,1) 0 1px 0;
   -moz-box-shadow: rgba(0,0,0,1) 0 1px 0;
   box-shadow: rgba(0,0,0,1) 0 1px 0;
   text-shadow: rgba(0,0,0,.4) 0 1px 0;
   color: white;
   font-size: 14px;
   font-family: Georgia, serif;
   text-decoration: none;
   vertical-align: middle;
   margin-top: 25px;
   margin-bottom: 25px;
   }
.button99:hover {
   border-top-color: #28597a;
   background: #28597a;
   color: #ccc;
   }
.button99:active {
   border-top-color: #22242e;
   background: #22242e;
   }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"/>
    
    <p>
        <br />
        <br />
    <center>    
    <span class="ThreeDsmall">Edit profile</span><p>
        </p>
        <br />
        <br />
        <table>
            <tr>
                <td class="LogPassText">Login:</td>
                <td>
                    <asp:TextBox ID="txtLogin" runat="server" CssClass="textBoxStyle1" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

            <tr>
                <td class="LogPassText">Change password?</td>
                <td>
                    <asp:CheckBox ID="chkPassword" runat="server" OnCheckedChanged="chkPassword_CheckedChanged" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td class="LogPassText">
                    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="textBoxStyle1" Enabled="false" TextMode="Password" style="background: transparent url('images/bg4.jpg') no-repeat;"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" Enabled="false" ControlToValidate="txtPass" ID="valid1" ErrorMessage="Password is required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">
                    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm password:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" AutoPostBack="False" CssClass="textBoxStyle1" Enabled="false" TextMode="Password" style="background: transparent url('images/bg4.jpg') no-repeat;"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" Enabled="false" ControlToValidate="txtConfirmPassword" ID="valid2" ErrorMessage="Password to confirm is required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="valid3" runat="server" Enabled="false" ControlToCompare="txtPass" ControlToValidate="txtConfirmPassword" ErrorMessage="Passwords are diffrent" style="color: #CC0000">*</asp:CompareValidator>
                </td>
            </tr>
                    </ContentTemplate>
                </asp:UpdatePanel>
            <tr>
                <td class="LogPassText">E-mail:</td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server" CssClass="textBoxStyle1"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMail" ErrorMessage="Email has wrong format" style="color: #CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Old password:</td>
                <td>
                    <asp:TextBox ID="txtOldPassword" runat="server" CssClass="textBoxStyle1" TextMode="Password" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPassword" ErrorMessage="Old password required" style="color: #CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">
                    <center>
                        <asp:Button ID="btnConfirm" runat="server" CssClass="button99" OnClick="btnConfirm_Click" Text="Confirm" />
                    </center>
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="validation-row" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" style="text-align: center; color: #CC0000;" />
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2" style="text-align: center">
                    <br />
                </td>
            </tr>
        </table>
            <p>
        </p>
            <p>
        </p>
            <p>
        </p>
            <p>
        </p>
            <p>
        </p>
            </p>
<%--        </ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>
