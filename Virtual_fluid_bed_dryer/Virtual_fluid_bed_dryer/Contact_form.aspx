<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact_form.aspx.cs" Inherits="Virtual_fluid_bed_dryer.Contact_form" %>
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
        text-align: left;
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
        .auto-style2 {
            color: #65A9D7;
            text-align: left;
        }
        .auto-style3 {
            color: #000000;
        }
        .auto-style4 {
            text-align: left;
            height: 1.5em;
            font-family: Verdana, sans-serif;
            width: auto;
        }
        .auto-style5 {
            color: #000000;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"/>
    
    <p>
        <br />
        <br />
    <center>    
    <span class="ThreeDsmall">Contact Form</span>
        <br />
        <br />
        <table>
            <tr>
                <td class="auto-style4">Login:</td>
                <td>
                    <asp:TextBox ID="txtLogin" runat="server" CssClass="textBoxStyle1" Enabled="false"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="LogPassText">E-mail<span class="auto-style2"> </span><span class="auto-style5">to reply</span><span class="auto-style2">*</span>:</td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server" CssClass="textBoxStyle1"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMail" ErrorMessage="Email has wrong format" style="color: #CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" CssClass="textBoxStyle1" Text=""></asp:TextBox>
      
                </td>
            </tr>
            <tr>
                <td class="LogPassText">Topic:</td>
                <td>
                    <asp:TextBox ID="txtTopic" runat="server" CssClass="textBoxStyle1" Text=""></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">&nbsp;</td>
            </tr>
             <tr>
                <td class="normal-row" colspan="2">* <span class="auto-style3">- if other than profiled </span> </td>
            </tr>
            <tr>
                <td class="normal-row" colspan="2">&nbsp;</td>
            </tr>
        </table>
        
        <table>
            
            <tr>
                
                <td class="normal-row" style="">

                     <asp:TextBox ID="txtMessage" runat="server" Height="5em" TextMode="MultiLine" Width="30em" style="max-width: 60em; max-height: 40em"></asp:TextBox>
                </td>
            </tr>
        </table>

        <table>
            <tr>
                <td class="normal-row" colspan="2">
                    <center>
                        <asp:Button ID="btnConfirm" runat="server" CssClass="button99" Text="SEND" ValidateRequestMode="Enabled" OnClick="btnConfirm_Click" />
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


</asp:Content>